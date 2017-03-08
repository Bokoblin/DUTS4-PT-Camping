using PT_Camping.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PT_Camping
{
    /// <summary>
    /// This dialog allows to add a new employee
    /// by choosing a name, a surname, a date of birth, a phone number,
    /// an address, an email, a login and a password
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 24/02/17
    public partial class AddEmployee : Form
    {
        private DataBase db;
        private Employe newEmployee;

        public AddEmployee(DataBase db)
        {
            InitializeComponent();
            this.db = db;
            newEmployee = new Employe()
            {
                Personne = new Personne()
            };
            toolTip1.SetToolTip(birthDateTextBox, "Au format : 1970-01-01 00:00");
        }


        private void OnPermissionButtonClick(object sender, EventArgs e)
        {
            new Permissions(newEmployee, db).ShowDialog();
        }


        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }


        private void OnOkButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (surnameTextBox.Text == "" || nameTextBox.Text == "" || emailTextBox.Text == ""
                    || birthDateTextBox.Text == "" || loginTextBox.Text == "" || passwordTextBox.Text == "")
                    throw new Exception("Toutes les valeurs marquées d'une étoile doivent être remplies.");

                if (surnameTextBox.Text.Any(char.IsDigit) || nameTextBox.Text.Any(char.IsDigit))
                    throw new Exception("Le nom et/ou le prénom ne peuvent contenir de valeur numérique.");

                int phone;
                if (phoneTextBox.Text != "" && (!int.TryParse(phoneTextBox.Text, out phone) || phoneTextBox.Text.Length != 10))
                    throw new Exception("Téléphone doit être un entier de 10 chiffres");

                if ((!emailTextBox.Text.EndsWith(".com") && !emailTextBox.Text.EndsWith(".fr"))
                        || !emailTextBox.Text.Contains("@"))
                    throw new Exception("Email doit contenir un @ et se terminer par .com/.fr");


                newEmployee.Personne.Nom_Personne = surnameTextBox.Text;
                newEmployee.Personne.Prenom_Personne = nameTextBox.Text;
                newEmployee.Personne.Date_Naissance = DateTime.Parse(birthDateTextBox.Text);
                if (phoneTextBox.Text != "")
                    newEmployee.Personne.Telephone = phoneTextBox.Text;
                newEmployee.Personne.Adresse = addressTextBox.Text;
                newEmployee.Personne.Email = emailTextBox.Text;
                newEmployee.Login = loginTextBox.Text;
                newEmployee.Password = LoginTools.sha256_hash(passwordTextBox.Text);

                db.Employe.Add(newEmployee);
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
