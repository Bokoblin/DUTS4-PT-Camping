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
            db = new DataBase();

            issuesListView.View = View.Details;
            issuesListView.Columns.Add("Type d'incident");
            issuesListView.Columns.Add("Description");
            issuesListView.Columns.Add("Date");

            updateIssuesListView();
            handleResize();
        }


        private void updateIssuesListView()
        {
            issuesListView.Items.Clear();

            foreach (var issue in db.Incident)
            {
                string issueType = issue.Type_Incident.Type_Incident1;
                string issueDescription = issue.Description_Incident;
                string issueDate = issue.Date_Incident.ToShortDateString();

                var item = new ListViewItem(new[] { issueType, issueDescription, issueDate });
                item.Name = issue.Code_Incident.ToString();
                issuesListView.Items.Add(item);
            }

            if (issuesListView.Items.Count > 0)
            {
                issuesListView.Items[0].Selected = true;
                issuesListView.Select();
            }
        }


        private void updateIssueDetails()
        {
            if (issuesListView.SelectedItems.Count != 0)
            {
                int code = int.Parse(issuesListView.SelectedItems[0].Name);
                var issue = db.Incident.Find(code);

                idTextBox.Text = issue.Code_Incident.ToString();
                locationTextBox.Text = issue.Emplacement.Code_Emplacement.ToString();
                issueTypeTextBox.Text = issue.Type_Incident.Type_Incident1;
                creationDateTextBox.Text = issue.Date_Incident.ToShortDateString();
                if (issue.Date_Resolution != null)
                    resolutionDateTextBox.Text = ((DateTime)issue.Date_Resolution).ToShortDateString();
                else
                    resolutionDateTextBox.Text = "";
                criticalityTextBox.Text = issue.Criticite_Incident.ToString() + "/5";
                statusTextBox.Text = issue.Avancement_Incident;
                descriptionTextBox.Text = issue.Description_Incident;

                resolveButton.Enabled = (issue.Avancement_Incident != "Terminé");
            }
            
        }


        private void onAddIssueButtonClick(object sender, EventArgs e)
        {
            /* TODO ***
            
            Expected behaviour after merging this branch + Alex's branch + 1 commit : 
            
            This method opens Map's issue section with aside a card with a drag & drop issue icon
            By dragging this icon on a campground and dropping it, it opens a dialog 
            where you have to add issue type, description and criticality. 
            Automactic DateTime.now() is set at OkButton event with status "Nouveau" and the issue is now added.

            */

            //TEMPORARY BEHAVIOUR : "AddIssue" dialog called here with Code_Emplacement = 1

            new AddIssue(db, 1).ShowDialog();
            updateIssuesListView();
        }


        private void onDeleteIssueButtonClick(object sender, EventArgs e)
        {
            int code = int.Parse(issuesListView.SelectedItems[0].Name);
            var issue = db.Incident.Find(code);

            db.Incident.Remove(issue);
            db.SaveChanges();
            updateIssuesListView();
        }


        private void onEditButtonClick(object sender, EventArgs e)
        {
            if (resolutionDateTextBox.ReadOnly == true)
            {
                resolutionDateTextBox.ReadOnly = false;
                criticalityTextBox.ReadOnly = false;
                statusTextBox.ReadOnly = false;
                descriptionTextBox.ReadOnly = false;
            }
            else
            {
                resolutionDateTextBox.ReadOnly = true;
                criticalityTextBox.ReadOnly = true;
                statusTextBox.ReadOnly = true;
                descriptionTextBox.ReadOnly = true;

                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(issuesListView.SelectedItems[0].Name);
                var incident = db.Incident.Find(code);

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

                db.SaveChanges();

                updateIssueDetails();

                if (cptModifications > 0)
                    MessageBox.Show(message);
            }
        }


        private void onResolveIssueButtonClick(object sender, EventArgs e)
        {
            int code = int.Parse(issuesListView.SelectedItems[0].Name);
            var issue = db.Incident.Find(code);

            issue.Date_Resolution = DateTime.Now;
            issue.Avancement_Incident = "Terminé";
            db.SaveChanges();

            updateIssueDetails();
        }


        private void issuesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            resolutionDateTextBox.ReadOnly = true;
            criticalityTextBox.ReadOnly = true;
            statusTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
            updateIssueDetails();
        }


        private void issuesListView_Resize(object sender, EventArgs e)
        {
            if (issuesListView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in issuesListView.Columns)
                    columnHeader.Width = issuesListView.Width / issuesListView.Columns.Count;
            }
        }
    }
}
