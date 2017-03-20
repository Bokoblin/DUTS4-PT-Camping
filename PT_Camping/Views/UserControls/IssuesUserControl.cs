using System;
using System.Linq;
using System.Windows.Forms;
using PT_Camping.Model;
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
            Db = new DataBase();

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
                    criticalityComboBox.Text = issue.Criticite_Incident + Resources.criticality_max;
                    statusTextBox.Text = issue.Avancement_Incident;
                    descriptionTextBox.Text = issue.Description_Incident;

                    resolveButton.Enabled = (issue.Date_Resolution == null);
                }
            }
            
        }


        private void OnAddIssueButtonClick(object sender, EventArgs e)
        {
            /* TODO : New issue in map or via combobox
            
            Proposed expected behaviour : 
            
            This method opens Map's issue section with aside a card with a drag & drop issue icon
            By dragging this icon on a campground and dropping it, it opens a dialog 
            where you have to add issue type, description and criticality. 
            Automactic DateTime.now() is set at OkButton event with status "Nouveau" and the issue is now added.

            */

            //TEMPORARY BEHAVIOUR : "AddIssue" dialog called here with Code_Emplacement = 25

            new AddIssue(Db, 25).ShowDialog();
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
                var incident = Db.Incident.Find(code);

                if (incident != null)
                {
                    #region CHECK & APPLY RESOLUTION DATE CHANGES
                    try
                    {
                        if (resolutionDateTextBox.Text == "" && incident.Date_Resolution != null)
                        {
                            incident.Date_Resolution = null;
                            message += "date de résolution\n";
                            cptModifications++;
                        }
                        else if (resolutionDateTextBox.Text != "")
                        {
                            incident.Date_Resolution = DateTime.Parse(resolutionDateTextBox.Text);

                            if (incident.Date_Resolution < incident.Date_Incident)
                            {
                                if (incident.Date_Resolution.Value.Day == incident.Date_Incident.Day)
                                    incident.Date_Resolution = incident.Date_Incident.AddSeconds(1);
                                else
                                {
                                    incident.Date_Resolution = null;
                                    throw new Exception();
                                }

                            }

                            if (((DateTime)incident.Date_Resolution).ToShortDateString() != resolutionDateTextBox.Text)
                            {
                                message += "date de résolution\n";
                                cptModifications++;
                            }

                        }
                    }
                    catch (Exception)
                    {
                        resolutionDateTextBox.Text = incident.Date_Resolution.ToString();
                        MessageBox.Show(Resources.invalid_date_exception);
                    }
                    #endregion

                    if (criticalityComboBox.Text != (incident.Criticite_Incident + Resources.criticality_max))
                    {
                        incident.Criticite_Incident = int.Parse(criticalityComboBox.Text);
                        message += "criticité\n";
                        cptModifications++;
                    }

                    if (statusTextBox.Text != incident.Avancement_Incident)
                    {
                        incident.Avancement_Incident = statusTextBox.Text;
                        message += "avancement\n";
                        cptModifications++;

                        if (statusTextBox.Text != Resources.done_issue && resolutionDateTextBox.Text != null)
                        {
                            incident.Date_Resolution = null;
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

                    if (descriptionTextBox.Text != incident.Description_Incident)
                    {
                        incident.Description_Incident = descriptionTextBox.Text;
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
