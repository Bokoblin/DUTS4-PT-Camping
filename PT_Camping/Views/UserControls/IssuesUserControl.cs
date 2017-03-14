using PT_Camping.Model;
using System;
using System.Windows.Forms;


namespace PT_Camping
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
        public IssuesUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = "Gestion des incidents";
            Db = new DataBase();

            issuesListView.View = System.Windows.Forms.View.Details;
            issuesListView.Columns.Add("Type d'incident", -2);
            issuesListView.Columns.Add("Description", -2);
            issuesListView.Columns.Add("Date", -2);

            UpdateIssuesListView();
            HandleResize();
        }


        private void UpdateIssuesListView()
        {
            issuesListView.Items.Clear();

            foreach (var issue in Db.Incident)
            {
                string type_incident = issue.Type_Incident.Type_Incident1;
                string description_incident = issue.Description_Incident;
                string date_incident = issue.Date_Incident.ToShortDateString();

                var item = new ListViewItem(new[] {type_incident, description_incident, date_incident})
                {
                    Name = issue.Code_Incident.ToString()
                };
                issuesListView.Items.Add(item);
            }

            //=== Select the first of the list

            if (issuesListView.Items.Count > 0)
            {
                issuesListView.Items[0].Selected = true;
                issuesListView.Select();
            }
        }


        private void UpdateIssueDetails()
        {
            if (issuesListView.SelectedItems.Count != 0)
            {
                int code = int.Parse(issuesListView.SelectedItems[0].Name);
                var issue = Db.Incident.Find(code);

                if (issue == null) return;

                idTextBox.Text = issue.Code_Incident.ToString();
                emplacementTextBox.Text = issue.Emplacement.Code_Emplacement.ToString();
                typeTextBox.Text = issue.Type_Incident.Type_Incident1;
                creationDateTextBox.Text = issue.Date_Incident.ToShortDateString();
                resolutionDateTextBox.Text = issue.Date_Resolution?.ToShortDateString() ?? "";
                criticalityTextBox.Text = issue.Criticite_Incident + "/5";
                statusTextBox.Text = issue.Avancement_Incident;
                descriptionTextBox.Text = issue.Description_Incident;

                resolveButton.Enabled = (issue.Avancement_Incident != "Terminé");
            }
            
        }


        private void OnAddIssueButton_Click(object sender, EventArgs e)
        {
            /* TODO ***
            
            Expected behaviour after merging this branch + Alex's branch + 1 commit : 
            
            This method opens Map's issue section with aside a card with a drag & drop issue icon
            By dragging this icon on a campground and dropping it, it opens a dialog 
            where you have to add issue type, description and criticality. 
            Automactic DateTime.now() is set at OkButton event with status "Nouveau" and the issue is now added.

            */

            //TEMPORARY BEHAVIOUR : "AddIssue" dialog called here with Code_Emplacement = 1

            new AddIssue(Db, 1).ShowDialog();
            UpdateIssuesListView();
        }


        private void OnDeleteIssueButton_Click(object sender, EventArgs e)
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


        private void OnEditButtonClick(object sender, EventArgs e)
        {
            if (resolutionDateTextBox.ReadOnly)
            {
                resetButton.Visible = true;
                resolutionDateTextBox.ReadOnly = false;
                criticalityTextBox.ReadOnly = false;
                statusTextBox.ReadOnly = false;
                descriptionTextBox.ReadOnly = false;
                editButton.BackgroundImage = Properties.Resources.ic_done;
            }
            else
            {
                resetButton.Visible = false;
                resolutionDateTextBox.ReadOnly = true;
                criticalityTextBox.ReadOnly = true;
                statusTextBox.ReadOnly = true;
                descriptionTextBox.ReadOnly = true;
                editButton.BackgroundImage = Properties.Resources.ic_edit;

                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(issuesListView.SelectedItems[0].Name);
                var incident = Db.Incident.Find(code);

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

                        if ( ((DateTime)incident.Date_Resolution).ToShortDateString() != resolutionDateTextBox.Text)
                        {
                            message += "date de résolution\n";
                            cptModifications++;
                        }
                        
                    }
                }
                catch (Exception)
                {
                    resolutionDateTextBox.Text = incident.Date_Resolution.ToString();
                    MessageBox.Show("La date n'est pas valide. \nVérifier que la date au format YYYY-MM-DD HH:MM:SS \net supérieure à la date de l'incident.");
                }
                #endregion

                if (criticalityTextBox.Text != (incident.Criticite_Incident.ToString() + "/5"))
                {
                    int criticality;
                    if (int.TryParse(criticalityTextBox.Text, out criticality) && criticality >= 1 && criticality <= 5)
                    {
                        incident.Criticite_Incident = criticality;
                        message += "criticité\n";
                        cptModifications++;
                    }
                    else
                        MessageBox.Show("Criticité doit être un entier compris entre 1 et 5");
                }

                if (statusTextBox.Text != incident.Avancement_Incident)
                {
                    incident.Avancement_Incident = statusTextBox.Text;
                    message += "avancement\n";
                    cptModifications++;

                    if (statusTextBox.Text != "Terminé" && resolutionDateTextBox.Text != null)
                    {
                        incident.Date_Resolution = null;
                        message += "date de résolution\n";
                        cptModifications++;
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


        private void OnResolveIssueButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(issuesListView.SelectedItems[0].Name);
            var issue = Db.Incident.Find(code);

            issue.Date_Resolution = DateTime.Now;
            issue.Avancement_Incident = "Terminé";
            Db.SaveChanges();

            UpdateIssueDetails();
            UpdateIssuesListView();

            foreach (ListViewItem item in issuesListView.Items)
            {
                item.Selected = item.Name == code.ToString();
            }
            issuesListView.Select();
        }


        private void IssuesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            resolutionDateTextBox.ReadOnly = true;
            criticalityTextBox.ReadOnly = true;
            statusTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
            UpdateIssueDetails();
        }

        private void IssuesListView_Resize(object sender, EventArgs e)
        {
            if ( issuesListView.Columns.Count == 3)
            {
                issuesListView.Columns[0].Width = issuesListView.Width / 3;
                issuesListView.Columns[1].Width = issuesListView.Width / 3;
                issuesListView.Columns[2].Width = issuesListView.Width / 3;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UpdateIssueDetails();
            resetButton.Visible = false;
            resolutionDateTextBox.ReadOnly = true;
            criticalityTextBox.ReadOnly = true;
            statusTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
            editButton.BackgroundImage = Properties.Resources.ic_edit;
        }
    }
}
