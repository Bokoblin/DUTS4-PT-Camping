using PT_Camping.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PT_Camping
{
    /// <summary>
    /// This dialog allows to add a new issue
    /// by choosing the type, the criticality and the description
    /// Opening issue time is set to DateTime::now and status to "Nouveau" (New)
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 25/02/17
    public partial class AddIssue : Form
    {
        private DataBase db;
        private Incident newIssue;

        public AddIssue(DataBase db, int code)
        {
            InitializeComponent();
            this.db = db;
            newIssue = new Incident();
            newIssue.Code_Emplacement = code;

            var types = db.Type_Incident.Select(t => t.Type_Incident1).ToList();
            issueTypecomboBox.DataSource = types;
        }


        private void onCancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }


        private void onOkButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (criticalityTextBox.Text == "")
                    throw new Exception("Criticité est un champs obligatoire (entier compris entre 1 et 5).");

                int criticality;
                if (int.TryParse(criticalityTextBox.Text, out criticality) && criticality >= 1 && criticality <= 5)
                {
                        newIssue.Criticite_Incident = criticality;
                }
                else
                    throw new Exception("Criticité doit être un entier compris entre 1 et 5");

                newIssue.Code_Type = db.Type_Incident.Where(t => t.Type_Incident1 == issueTypecomboBox.Text).FirstOrDefault().Code_Type;
                if (descriptionTextBox.Text != "")
                    newIssue.Description_Incident = descriptionTextBox.Text;
                else
                    newIssue.Description_Incident = "Sans commentaire";
                newIssue.Date_Incident = DateTime.Now;
                newIssue.Avancement_Incident = "Nouveau";

                db.Incident.Add(newIssue);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
