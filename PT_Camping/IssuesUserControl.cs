using PT_Camping.Model;
using System;
using System.Drawing;
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
            issuesListView.Columns.Add("Description", -2);
            issuesListView.Columns.Add("Date", -2);

            updateIssuesListView();
            handleResize();
        }


        internal new void handleResize()
        {
            base.handleResize();

            issuesListView.Size = new Size(
                Convert.ToInt32(mHomeUC.Size.Width * 0.3),
                Convert.ToInt32(issuesListView.Size.Height)
                );
        }


        private void updateIssuesListView()
        {
            issuesListView.Items.Clear();

            foreach (var incident in db.Incident)
            {
                string description_incident = incident.Description_Incident;
                string date_incident = incident.Date_Incident.ToShortDateString();

                var item = new ListViewItem(new[] { description_incident, date_incident });
                item.Name = incident.Code_Incident.ToString();
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
                var incident = db.Incident.Find(code);

                idTextBox.Text = incident.Code_Incident.ToString();
                emplacementTextBox.Text = incident.Emplacement.Code_Emplacement.ToString();
                typeTextBox.Text = incident.Type_Incident.Type_Incident1;
                creationDateTextBox.Text = incident.Date_Incident.ToShortDateString();
                if (incident.Date_Resolution != null)
                    resolutionDateTextBox.Text = ((DateTime)incident.Date_Resolution).ToShortDateString();
                else
                    resolutionDateTextBox.Text = "";
                criticStateTextBox.Text = incident.Criticite_Incident.ToString() + "/5";
                stateTextBox.Text = incident.Avancement_Incident;
                descriptionTextBox.Text = incident.Description_Incident;

                resolveButton.Enabled = (incident.Avancement_Incident != "Terminé");
            }
            
        }


        private void onAddIssueButtonClick(object sender, EventArgs e)
        {
            //TODO : Open Map's new issue adding

            //Temporary behaviour :

            Incident i = new Incident();
            i.Avancement_Incident = "Nouveau";
            i.Code_Emplacement = 1;
            i.Code_Type = 3;
            i.Criticite_Incident = 2;
            i.Date_Incident = DateTime.Now;
            i.Description_Incident = "Sans commentaire";
            db.Incident.Add(i);
            db.SaveChanges();

            updateIssuesListView();

            MessageBox.Show("A template item has been added. \n"
                + "This is a temporary behaviour until Map issues adding feature is implemented");
        }


        private void onDeleteIssueButtonClick(object sender, EventArgs e)
        {
            int code = int.Parse(issuesListView.SelectedItems[0].Name);
            var incident = db.Incident.Find(code);

            db.Incident.Remove(incident);
            db.SaveChanges();
            updateIssuesListView();
        }


        private void onEditButtonClick(object sender, EventArgs e)
        {
            if (resolutionDateTextBox.ReadOnly == true)
            {
                resolutionDateTextBox.ReadOnly = false;
                criticStateTextBox.ReadOnly = false;
                stateTextBox.ReadOnly = false;
                descriptionTextBox.ReadOnly = false;
            }
            else
            {
                resolutionDateTextBox.ReadOnly = true;
                criticStateTextBox.ReadOnly = true;
                stateTextBox.ReadOnly = true;
                descriptionTextBox.ReadOnly = true;

                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(issuesListView.SelectedItems[0].Name);
                var incident = db.Incident.Find(code);

                if (resolutionDateTextBox.Text != ((DateTime)incident.Date_Resolution).ToShortDateString())
                {
                    try
                    {
                        if (resolutionDateTextBox.Text == "")
                        {
                            incident.Date_Resolution = null;
                            message += "date de résolution\n";
                            cptModifications++;
                        }

                        /* DateTime.Parse isn't 100% working concerning compatibility with datebase DateTime :
                         * db.saveChanges() throws exceptions in certain cases due to that incompatibility
                         */
                        incident.Date_Resolution = DateTime.Parse(resolutionDateTextBox.Text);
                        message += "date de résolution\n";
                        cptModifications++;
                    }
                    catch (ArgumentNullException)
                    {
                        incident.Date_Resolution = null;
                        message += "date de résolution\n";
                        cptModifications++;
                    }
                    catch (FormatException)
                    {
                        resolutionDateTextBox.Text = incident.Date_Resolution.ToString();
                        MessageBox.Show("Le format de date n'est pas correct");
                    }
                }

                if (criticStateTextBox.Text != (incident.Criticite_Incident.ToString() + "/5"))
                {
                    int criticite;
                    if (int.TryParse(criticStateTextBox.Text, out criticite) && criticite >= 1 && criticite <= 5)
                    {
                        incident.Criticite_Incident = criticite;
                        message += "criticité\n";
                        cptModifications++;
                    }
                    else
                        MessageBox.Show("Criticité doit être un entier compris entre 1 et 5");
                }

                if (stateTextBox.Text != incident.Avancement_Incident)
                {
                    incident.Avancement_Incident = stateTextBox.Text;
                    message += "avancement\n";
                    cptModifications++;

                    if (stateTextBox.Text != "Terminé" && resolutionDateTextBox.Text != null)
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
            var incident = db.Incident.Find(code);

            incident.Date_Resolution = DateTime.Now;
            incident.Avancement_Incident = "Terminé";
            db.SaveChanges();

            updateIssueDetails();
        }


        private void issuesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIssueDetails();
        }
    }
}
