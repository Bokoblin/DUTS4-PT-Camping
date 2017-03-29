using System;
using System.Linq;
using System.Windows.Forms;
using PT_Camping.Model;

namespace PT_Camping.Views.Forms
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
        private readonly DataBase _db;
        private readonly Incident _newIssue;

        public AddIssue(DataBase db)
        {
            InitializeComponent();
            _db = db;
            _newIssue = new Incident()
            {
                Avancement_Incident = "Nouveau",
                Description_Incident = "Sans commentaire"
            };

            var locations = db.Emplacement.Select(l => l.Nom_Emplacement).ToList();
            locationComboBox.DataSource = locations;
            locationComboBox.Text = locationComboBox.Items[0].ToString();

            var types = db.Type_Incident.Select(t => t.Type_Incident1).ToList();
            issueTypecomboBox.DataSource = types;
            criticalityComboBox.Text = criticalityComboBox.Items[0].ToString();
        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                int locationId = _db.Emplacement.First(
                   l => l.Nom_Emplacement == locationComboBox.Text).Code_Emplacement;

                int issueTypeId = _db.Type_Incident.First(
                    t => t.Type_Incident1 == issueTypecomboBox.Text).Code_Type;

                _newIssue.Code_Type = issueTypeId;
                _newIssue.Code_Emplacement = locationId;
                _newIssue.Date_Incident = DateTime.Now;
                _newIssue.Criticite_Incident = int.Parse(criticalityComboBox.Text);
                if (descriptionTextBox.Text != "")
                {
                    _newIssue.Description_Incident = descriptionTextBox.Text;
                }

                _db.Incident.Add(_newIssue);
                _db.SaveChanges();
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
