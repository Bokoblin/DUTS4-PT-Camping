using PT_Camping.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Camping.View.Forms
{
    public partial class AddProvider : Form
    {
        private DataBase db;
        private Fournisseur newProvider;
        public AddProvider(DataBase db, int code)
        {
            InitializeComponent();
            this.db = db;
            newProvider = new Fournisseur();

            //var types = db.Produit.Select(t => t.Libelle_Produit).ToList();
            //issueTypecomboBox.DataSource = types;
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameF.Text == "")
                    throw new Exception("Le nom du fournisseur est obligatoire");

                else
                    newProvider.Nom_Fournisseur = nameF.Text;

                if (adresseF.Text == "")
                    throw new Exception("L'adresse du fournisseur est obligatoire");

                else
                    newProvider.Adresse_Fournisseur = adresseF.Text;

                if (mailF.Text == "")
                    throw new Exception("L'e-mail du fournisseur est obligatoire");

                else
                    newProvider.Email_Fournisseur = mailF.Text;

                if (webF.Text != "")
                    newProvider.Site_web_Fournisseur = webF.Text;
                else
                    newProvider.Site_web_Fournisseur = null;

                newProvider.est_approuvé = false;
                db.Fournisseur.Add(newProvider);
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
