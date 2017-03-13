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
            Db = new DataBase();

            issuesListView.View = View.Details;
            issuesListView.Columns.Add("Description", -2);
            issuesListView.Columns.Add("Date", -2);

            fillIssuesListView();
            handleResize();
        }


        public void fillIssuesListView()
        {
            issuesListView.Items.Clear();

            foreach (var incident in Db.Incident)
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


        internal new void handleResize()
        {
            base.HandleResize();

            issuesListView.Size = new Size(
                Convert.ToInt32(mHomeUserControl.Size.Width * 0.3),
                Convert.ToInt32(issuesListView.Size.Height)
                );
        }


        private void updateIssuesListView()
        { 
            foreach (ListViewItem item in issuesListView.Items)
            {
                int code = int.Parse(issuesListView.SelectedItems[0].Name);
                var incident = Db.Incident.Find(code);

                item.SubItems[0].Text = incident.Description_Incident;
                item.SubItems[0].Text = incident.Date_Incident.ToShortDateString();
            }
        }


        private void updateIssueDetails()
        {
            if (issuesListView.SelectedItems.Count != 0)
            {
                int code = int.Parse(issuesListView.SelectedItems[0].Name);
                var incident = Db.Incident.Find(code);

                idTextBox.Text = incident.Code_Incident.ToString();
                emplacementTextBox.Text = incident.Emplacement.Code_Emplacement.ToString();
                typeTextBox.Text = incident.Type_Incident.Type_Incident1;
                creationDateTextBox.Text = incident.Date_Incident.ToShortDateString();
                resolutionDateTextBox.Text = incident.Date_Resolution.ToString();
                criticStateTextBox.Text = incident.Criticite_Incident.ToString() + "/5";
                stateTextBox.Text = incident.Avancement_Incident;
                descriptionTextBox.Text = incident.Description_Incident;

                resolveButton.Enabled = (incident.Avancement_Incident != "Terminé");
            }
            
        }


        private void newIssueButton_Click(object sender, EventArgs e)
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
            Db.Incident.Add(i);
            Db.SaveChanges();

            fillIssuesListView();

            MessageBox.Show("A template item has been added. \n"
                + "This is a temporary behaviour until Map issues adding feature is implemented");
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(issuesListView.SelectedItems[0].Name);
            var incident = Db.Incident.Find(code);

            Db.Incident.Remove(incident);
            Db.SaveChanges();
            fillIssuesListView();
        }


        private void editButton_Click(object sender, EventArgs e)
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
                var incident = Db.Incident.Find(code);

                try
                {
                    if (resolutionDateTextBox.Text != incident.Date_Resolution.ToString())
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
                }
                catch (ArgumentNullException ANE)
                {
                    incident.Date_Resolution = null;
                    message += "date de résolution\n";
                    cptModifications++;
                }
                catch (FormatException FE)
                {
                    resolutionDateTextBox.Text = incident.Date_Resolution.ToString();
                    MessageBox.Show("Le format de date n'est pas correct");
                }
                try
                {
                    if ( criticStateTextBox.Text != (incident.Criticite_Incident.ToString() + "/5") )
                    {
                        int criticite;
                        if (int.TryParse(criticStateTextBox.Text, out criticite) && criticite >= 1 && criticite <= 5)
                        {
                            incident.Criticite_Incident = criticite;
                            message += "criticité\n";
                            cptModifications++;
                        }
                        else
                            throw new Exception("Criticité doit être un entier compris entre 1 et 5");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

                Db.SaveChanges();

                updateIssueDetails();

                if (cptModifications > 0)
                    MessageBox.Show(message);
            }
        }


        private void resolveButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(issuesListView.SelectedItems[0].Name);
            var incident = Db.Incident.Find(code);

            incident.Date_Resolution = DateTime.Now;
            incident.Avancement_Incident = "Terminé";
            Db.SaveChanges();

            updateIssueDetails();
        }


        private void issuesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIssueDetails();
        }
    }
}
