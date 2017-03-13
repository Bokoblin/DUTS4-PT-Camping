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
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameP.Text == "")
                    throw new Exception("Le nom du fournisseur est obligatoire");

                else
                    newProvider.Nom_Fournisseur = nameP.Text;

                if (adresseP.Text == "")
                    throw new Exception("L'adresse du fournisseur est obligatoire");

                else
                    newProvider.Adresse_Fournisseur = adresseP.Text;

                if (mailP.Text == "")
                    throw new Exception("L'e-mail du fournisseur est obligatoire");

                else
                    newProvider.Email_Fournisseur = mailP.Text;

                if (webP.Text != "")
                    newProvider.Site_web_Fournisseur = webP.Text;
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
