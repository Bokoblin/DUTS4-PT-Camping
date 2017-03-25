using System;
using System.Linq;
using System.Windows.Forms;
using PT_Camping.Properties;
using PT_Camping.Views.Forms;

namespace PT_Camping.Views.UserControls
{
    /// <summary>
    /// The IssuesUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's issues.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
    public partial class IssuesUserControl : ManagementUserControl
    {
        public IssuesUserControl(HomeUserControl home) : base(home)
        {
            InitializeComponent();
            appBarTitle.Text = Resources.issues_management;

            issuesListView.View = View.Details;
            issuesListView.Columns.Add("Etat");
            issuesListView.Columns.Add("Type d'incident");
            issuesListView.Columns.Add("Description");
            issuesListView.Columns.Add("Date");

            var imageList = new ImageList();
            imageList.Images.Add("pending", Resources.ic_issue_pending);
            imageList.Images.Add("done", Resources.ic_issue_done);
            imageList.ImageSize = new System.Drawing.Size(20,20);
            issuesListView.SmallImageList = imageList;

            UpdateIssuesListView();
            HandleResize();
            InitPermissions();
        }

        public void InitPermissions()
        {
            addIssueButton.Enabled = UserRights.Any(d => d.Libelle_Droit == "writeIssues");
            deleteButton.Visible = UserRights.Any(d => d.Libelle_Droit == "writeIssues");
            editButton.Visible = UserRights.Any(d => d.Libelle_Droit == "writeIssues");
            resolveButton.Enabled = UserRights.Any(d => d.Libelle_Droit == "writeIssues");
        }

        public IssuesUserControl(HomeUserControl home, int issueCode) : this(home)
        {
            foreach (ListViewItem item in issuesListView.Items)
            {
                item.Selected = item.Name == issueCode.ToString();
            }
        }


        private void UpdateIssuesListView()
        {
            issuesListView.Items.Clear();

            foreach (var issue in Db.Incident)
            {
                string issueType = issue.Type_Incident.Type_Incident1;
                string issueDescription = issue.Description_Incident;
                string issueDate = issue.Date_Incident.ToShortDateString();

                var item = new ListViewItem(new[] { "", issueType, issueDescription, issueDate })
                {
                    Name = issue.Code_Incident.ToString(),
                    ImageKey = (issue.Date_Resolution == null)? "pending":"done"
                };
                issuesListView.Items.Add(item);
            }

            //=== Select the first of the list

            if (issuesListView.Items.Count > 0)
            {
                issuesListView.Items[0].Selected = true;
                issuesListView.Select();
            }

            //=== Order list items by date

            var orderedList = issuesListView.Items.Cast<ListViewItem>().Select(x => x)
                .OrderBy(x => DateTime.Parse(x.SubItems[3].Text)).ToList();
            issuesListView.Items.Clear();
            issuesListView.Items.AddRange(orderedList.ToArray());
        }


        private void UpdateIssueDetails()
        {
            if (issuesListView.SelectedItems.Count != 0)
            {
                int code = int.Parse(issuesListView.SelectedItems[0].Name);
                var issue = Db.Incident.Find(code);

                if (issue != null)
                {
                    idTextBox.Text = Resources.hash_symbol + issue.Code_Incident;
                    locationTextBox.Text = issue.Emplacement.Nom_Emplacement;
                    issueTypeTextBox.Text = issue.Type_Incident.Type_Incident1;
                    creationDateTextBox.Text = issue.Date_Incident.ToShortDateString();
                    resolutionDateTextBox.Text = issue.Date_Resolution?.ToShortDateString() ?? "";
                    criticalityComboBox.SelectedIndex = issue.Criticite_Incident-1;
                    statusTextBox.Text = issue.Avancement_Incident;
                    descriptionTextBox.Text = issue.Description_Incident;
                    
                    resolveButton.Enabled = (issue.Date_Resolution == null)
                        && UserRights.Any(d => d.Libelle_Droit == "writeIssues");
                }
            }
            
        }


        private void OnAddIssueButtonClick(object sender, EventArgs e)
        {
            new AddIssue(Db).ShowDialog();
            Cursor.Current = Cursors.Default;
            UpdateIssuesListView();
        }


        private void OnDeleteIssueButtonClick(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(Resources.delete_item_confirm_message,
                                     "", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int code = int.Parse(issuesListView.SelectedItems[0].Name);
                var issue = Db.Incident.Find(code);

                if (issue != null)
                {
                    Db.Incident.Remove(issue);
                    Db.SaveChanges();
                    UpdateIssuesListView();
                }
            }
        }


        private void OnEditButtonClick(object sender, EventArgs e)
        {
            if (resolutionDateTextBox.ReadOnly)
            {
                resetButton.Visible = true;
                resolutionDateTextBox.ReadOnly = false;
                criticalityComboBox.Enabled = true;
                statusTextBox.ReadOnly = false;
                descriptionTextBox.ReadOnly = false;
                editButton.BackgroundImage = Resources.ic_done;
            }
            else
            {
                resetButton.Visible = false;
                resolutionDateTextBox.ReadOnly = true;
                criticalityComboBox.Enabled = true;
                statusTextBox.ReadOnly = true;
                descriptionTextBox.ReadOnly = true;
                editButton.BackgroundImage = Resources.ic_edit;

                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(issuesListView.SelectedItems[0].Name);
                var issue = Db.Incident.Find(code);

                if (issue != null)
                {
                    #region CHECK & APPLY RESOLUTION DATE CHANGES
                    try
                    {
                        if (resolutionDateTextBox.Text == "" && issue.Date_Resolution != null)
                        {
                            issue.Date_Resolution = null;
                            message += "date de résolution\n";
                            cptModifications++;
                        }
                        else if (resolutionDateTextBox.Text != "")
                        {
                            issue.Date_Resolution = DateTime.Parse(resolutionDateTextBox.Text);

                            if (issue.Date_Resolution < issue.Date_Incident)
                            {
                                if (issue.Date_Resolution.Value.Day == issue.Date_Incident.Day)
                                    issue.Date_Resolution = issue.Date_Incident.AddSeconds(1);
                                else
                                {
                                    issue.Date_Resolution = null;
                                    throw new Exception();
                                }

                            }

                            if (((DateTime)issue.Date_Resolution).ToShortDateString() != resolutionDateTextBox.Text)
                            {
                                message += "date de résolution\n";
                                cptModifications++;
                            }

                        }
                    }
                    catch (Exception)
                    {
                        resolutionDateTextBox.Text = issue.Date_Resolution.ToString();
                        MessageBox.Show(Resources.invalid_date_exception);
                    }
                    #endregion

                    if (criticalityComboBox.SelectedIndex != issue.Criticite_Incident - 1)
                    {
                        issue.Criticite_Incident = criticalityComboBox.SelectedIndex+1;
                        message += "criticité\n";
                        cptModifications++;
                    }

                    if (statusTextBox.Text != issue.Avancement_Incident)
                    {
                        issue.Avancement_Incident = statusTextBox.Text;
                        message += "avancement\n";
                        cptModifications++;

                        if (statusTextBox.Text != Resources.done_issue && resolutionDateTextBox.Text != null)
                        {
                            issue.Date_Resolution = null;
                            message += "date de résolution\n";
                            cptModifications++;
                        }
                        else if (statusTextBox.Text == Resources.done_issue)
                        {
                            message += "date de résolution\n";
                            cptModifications++;
                            OnResolveIssueButtonClick(null, null);
                        }
                    }

                    if (descriptionTextBox.Text != issue.Description_Incident)
                    {
                        issue.Description_Incident = descriptionTextBox.Text;
                        message += "description";
                        cptModifications++;
                    }

                    Db.SaveChanges();

                    UpdateIssueDetails();
                    UpdateIssuesListView();

                    foreach (ListViewItem item in issuesListView.Items)
                    {
                        item.Selected = item.Name == code.ToString();
                    }
                    issuesListView.Select();

                    if (cptModifications > 0)
                        MessageBox.Show(message);
                }
            }
        }


        private void OnResolveIssueButtonClick(object sender, EventArgs e)
        {
            int code = int.Parse(issuesListView.SelectedItems[0].Name);
            var issue = Db.Incident.Find(code);

            if (issue != null)
            {
                issue.Date_Resolution = DateTime.Now;
                issue.Avancement_Incident = Resources.done_issue;


                Db.SaveChanges();

                UpdateIssueDetails();
                UpdateIssuesListView();

                foreach (ListViewItem item in issuesListView.Items)
                {
                    item.Selected = item.Name == code.ToString();
                }
                issuesListView.Select();
            }
        }


        private void IssuesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetButton.Visible = false;
            editButton.BackgroundImage = Resources.ic_edit;
            resolutionDateTextBox.ReadOnly = true;
            criticalityComboBox.Enabled = false;
            statusTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
            UpdateIssueDetails();
        }


        private void IssuesListView_Resize(object sender, EventArgs e)
        {
            if (issuesListView.Columns.Count != 0)
            {
                issuesListView.Columns[0].Width = 33;
                issuesListView.Columns[1].Width = issuesListView.Width / 3 - 11;
                issuesListView.Columns[2].Width = issuesListView.Width / 3 - 11;
                issuesListView.Columns[3].Width = issuesListView.Width / 3 - 11;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UpdateIssueDetails();
            resetButton.Visible = false;
            resolutionDateTextBox.ReadOnly = true;
            criticalityComboBox.Enabled = false;
            statusTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
            editButton.BackgroundImage = Resources.ic_edit;
        }
    }
}
