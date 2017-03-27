using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Properties;

namespace PT_Camping.Views.Forms
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
        private readonly DataBase _db;
        private readonly Employe _newEmployee;

        public AddEmployee(DataBase db)
        {
            InitializeComponent();
            _db = db;
            _newEmployee = new Employe()
            {
                Personne = new Personne()
            };
            birthDateTimePicker.MinDate = DateTime.Now.AddYears(-100);
            birthDateTimePicker.MaxDate = DateTime.Now.AddYears(-16);
        }


        private void PermissionButton_Click(object sender, EventArgs e)
        {
            new Permissions(_newEmployee, _db).ShowDialog();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (surnameTextBox.Text == "" || nameTextBox.Text == "" || emailTextBox.Text == "" 
                    || phoneTextBox.Text == "" || loginTextBox.Text == "" || passwordTextBox.Text == "")
                    throw new Exception(Resources.compulsary_values_exception);

                if (surnameTextBox.Text.Any(char.IsDigit))
                    throw new Exception("Le prénom ne peut contenir de valeur numérique.");

                if (nameTextBox.Text.Any(char.IsDigit))
                    throw new Exception("Le nom ne peut contenir de valeur numérique.");

                try
                {
                    _newEmployee.Personne.Email = new MailAddress(emailTextBox.Text).ToString();
                }
                catch (FormatException)
                {
                    throw new Exception(Resources.unrecognized_email);
                }


                _newEmployee.Personne.Nom_Personne = surnameTextBox.Text;
                _newEmployee.Personne.Prenom_Personne = nameTextBox.Text;
                _newEmployee.Personne.Date_Naissance = birthDateTimePicker.Value.Date;
                _newEmployee.Personne.Telephone = phoneTextBox.Text;
                _newEmployee.Personne.Adresse = addressTextBox.Text;
                _newEmployee.Personne.Email = emailTextBox.Text;
                _newEmployee.Login = loginTextBox.Text;
                _newEmployee.Password = LoginTools.Sha256_hash(passwordTextBox.Text);

                _db.Employe.Add(_newEmployee);
                _db.SaveChanges();
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


        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
            showPasswordCheckBox.Text = showPasswordCheckBox.Checked ? "Masquer" : "Afficher";
        }
    }
}
