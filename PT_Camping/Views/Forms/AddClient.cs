using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Properties;

namespace PT_Camping.Views.Forms
{
    /// <summary>
    /// This dialog allows to add a new client
    /// by choosing a name, a surname, a date of birth, a phone number,
    /// an address and an email. Address is not compulsary
    /// 
    /// </summary>
    /// Authors : Valentine
    /// Since : 08/03/17
    public partial class AddClient : Form
    {
        private readonly DataBase _db;
        private readonly Client _newClient;

        public AddClient(DataBase db)
        {
            InitializeComponent();
            _db = db;
            _newClient = new Client
            {
                Personne = new Personne()
            };
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
                    || phoneTextBox.Text == "")
                    throw new Exception(Resources.compulsary_values_exception);

                if (surnameTextBox.Text.Any(char.IsDigit) || nameTextBox.Text.Any(char.IsDigit))
                    throw new Exception("Le nom et/ou le prénom ne peuvent contenir de valeur numérique.");

                if (phoneTextBox.Text.Length != 10)
                    throw new Exception("Le numéro de téléphone doit être un entier de 10 chiffres");

                try
                {
                    _newClient.Personne.Email = new MailAddress(emailTextBox.Text).ToString();
                }
                catch (FormatException)
                {
                    throw new Exception(Resources.unrecognized_email);
                }

                _newClient.Personne.Nom_Personne = surnameTextBox.Text;
                _newClient.Personne.Prenom_Personne = nameTextBox.Text;
                _newClient.Personne.Date_Naissance = birthDateTimePicker.Value.Date;
                _newClient.Personne.Telephone = phoneTextBox.Text;
                _newClient.Personne.Adresse = addressTextBox.Text;
                _newClient.Personne.Email = emailTextBox.Text;
                _newClient.Date_Inscription = DateTime.Now;
                _db.Client.Add(_newClient);
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
    }
}
