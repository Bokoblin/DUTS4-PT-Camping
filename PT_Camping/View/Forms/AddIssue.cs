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
            newIssue = new Incident()
            {
                Code_Emplacement = code
            };
            var types = db.Type_Incident.Select(t => t.Type_Incident1).ToList();
            issueTypecomboBox.DataSource = types;
            criticalityComboBox.Text = criticalityComboBox.Items[0].ToString();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (criticalityComboBox.Text == "")
                    throw new Exception("Criticité est un champs obligatoire (entier compris entre 1 et 5).");

                newIssue.Criticite_Incident = int.Parse(criticalityComboBox.Text);

                newIssue.Code_Type = db.Type_Incident.Where(t => t.Type_Incident1 == issueTypecomboBox.Text).FirstOrDefault().Code_Type;
                if (descriptionTextBox.Text != "")
                    newIssue.Description_Incident = descriptionTextBox.Text;
                else
                    newIssue.Description_Incident = "Sans commentaire";
                newIssue.Date_Incident = DateTime.Now;
                newIssue.Avancement_Incident = "Nouveau";

                db.Incident.Add(newIssue);
                db.SaveChanges();
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
