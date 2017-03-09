using PT_Camping.Model;
using System;
using System.Linq;
using System.Net.Mail;
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
            birthDateTimePicker.MinDate = DateTime.Now.AddYears(-100);
            birthDateTimePicker.MaxDate = DateTime.Now.AddYears(-16);
        }


        private void PermissionButton_Click(object sender, EventArgs e)
        {
            new Permissions(newEmployee, db).ShowDialog();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (surnameTextBox.Text == "" || nameTextBox.Text == "" || emailTextBox.Text == "" 
                    || phoneTextBox.Text == "" || loginTextBox.Text == "" || passwordTextBox.Text == "")
                    throw new Exception("Toutes les valeurs marquées d'une étoile doivent être remplies.");

                if (surnameTextBox.Text.Any(char.IsDigit))
                    throw new Exception("Le prénom ne peut contenir de valeur numérique.");

                if (nameTextBox.Text.Any(char.IsDigit))
                    throw new Exception("Le nom ne peut contenir de valeur numérique.");

                try
                {
                    var test = new MailAddress(emailTextBox.Text);
                }
                catch (FormatException)
                {
                    throw new Exception("Email n'est pas une adresse mail valide");
                }


                newEmployee.Personne.Nom_Personne = surnameTextBox.Text;
                newEmployee.Personne.Prenom_Personne = nameTextBox.Text;
                newEmployee.Personne.Date_Naissance = birthDateTimePicker.Value.Date;
                newEmployee.Personne.Telephone = phoneTextBox.Text;
                newEmployee.Personne.Adresse = addressTextBox.Text;
                newEmployee.Personne.Email = emailTextBox.Text;
                newEmployee.Login = loginTextBox.Text;
                newEmployee.Password = LoginTools.Sha256_hash(passwordTextBox.Text);

                db.Employe.Add(newEmployee);
                db.SaveChanges();
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        /**
         * Prevent typing non digit values in the phone textbox
         */
        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
