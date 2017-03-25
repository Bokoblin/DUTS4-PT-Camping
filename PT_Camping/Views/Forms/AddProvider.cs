using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using PT_Camping.Model;

namespace PT_Camping.Views.Forms
{
    /// <summary>
    /// This dialog allows to add a new provider
    /// by choosing a name, an email, an address, and optionally a website
    /// 
    /// </summary>
    /// Authors : Claire
    /// Since : 02/03/17
    public partial class AddProvider : Form
    {
        private readonly DataBase _db;
        private readonly Fournisseur _newProvider;
        public AddProvider(DataBase db)
        {
            InitializeComponent();
            _db = db;
            _newProvider = new Fournisseur();            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (nameTextBox.Text == "" || addressTextBox.Text == "" || emailTextBox.Text == "")
                    throw new Exception("Toutes les valeurs marquées d'une étoile doivent être remplies.");

                if (nameTextBox.Text.Any(char.IsDigit))
                    throw new Exception("Le nom ne peut contenir de valeur numérique.");

                try
                {
                    _newProvider.Email_Fournisseur = new MailAddress(emailTextBox.Text).ToString();
                }
                catch (FormatException)
                {
                    throw new Exception("Email n'est pas une adresse mail valide");
                }

                _newProvider.Nom_Fournisseur = nameTextBox.Text;
                _newProvider.Adresse_Fournisseur = addressTextBox.Text;
                _newProvider.Email_Fournisseur = emailTextBox.Text;
                _newProvider.Site_web_Fournisseur = websiteTextBox.Text != "" ? websiteTextBox.Text : null;
                _newProvider.est_approuvé = false;

                _db.Fournisseur.Add(_newProvider);
                _db.SaveChanges();
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

    }
}
