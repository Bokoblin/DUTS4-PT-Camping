using MySql.Data.MySqlClient.Memcached;
using PT_Camping.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Camping.View.Forms
{
    public partial class AddClient : Form
    {
        private DataBase db;
        private Model.Client newClient;
        public AddClient(DataBase db)
        {
            InitializeComponent();
            this.db = db;
            newClient = new Model.Client();
            newClient.Personne = new Personne();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (surnameTextBox.Text == "" || nameTextBox.Text == "" || emailTextBox.Text == ""
                    || birthDateTextBox.Text == "")
                    throw new Exception("Toutes les valeurs marquées d'une étoile doivent être remplies.");

                if (surnameTextBox.Text.Any(char.IsDigit) || nameTextBox.Text.Any(char.IsDigit))
                    throw new Exception("Le nom et/ou le prénom ne peuvent contenir de valeur numérique.");

                int num;
                if (phoneTextBox.Text != "" && (!int.TryParse(phoneTextBox.Text, out num) || phoneTextBox.Text.Length != 10))
                    throw new Exception("Le numéro de téléphone doit être un entier de 10 chiffres");

                if ((!emailTextBox.Text.EndsWith(".com") && !emailTextBox.Text.EndsWith(".fr"))
                        || !emailTextBox.Text.Contains("@"))
                    throw new Exception("l'email doit contenir un @ et se terminer par .com ou .fr");


                newClient.Personne.Nom_Personne = surnameTextBox.Text;
                newClient.Personne.Prenom_Personne = nameTextBox.Text;
                newClient.Personne.Date_Naissance = DateTime.Parse(birthDateTextBox.Text);
                if (phoneTextBox.Text != "")
                    newClient.Personne.Telephone = phoneTextBox.Text;
                newClient.Personne.Adresse = addressTextBox.Text;
                newClient.Personne.Email = emailTextBox.Text;
                newClient.Date_Inscription = DateTime.Now;
                db.Client.Add(newClient);
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
