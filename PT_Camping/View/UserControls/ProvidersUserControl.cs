using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.View.Forms;
using System.Diagnostics;

namespace PT_Camping
{
    /// <summary>
    /// The ProvidersUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's stocks providers.
    /// 
    /// </summary>
    /// Authors : Claire MARCINIAK
    /// Since : 13/02/17  & End : /03/17
    public partial class ProvidersUserControl : ManagementUserControl
    {

        private String providerMail;
        public ProvidersUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = "Gestion des fournisseurs";

            db = new DataBase();

            ProvList.View = System.Windows.Forms.View.Details;
            ProvList.Columns.Add("Nom du fournisseur", -2);
            ProvList.Columns.Add("Adresse mail du fournisseur", -2);

            updateProviders();

            handleResize();
        }

        public void updateProviders()
        {
            ProvList.Items.Clear();

            foreach (var provider in db.Fournisseur)
            {
                string providerEmail = provider.Email_Fournisseur;
                string providerName = provider.Nom_Fournisseur;

                var item = new ListViewItem(new[] { providerName, providerEmail });
                item.Name = provider.Code_Fournisseur.ToString();
                ProvList.Items.Add(item);
            }

            if (ProvList.Items.Count > 0)
            {
                ProvList.Items[0].Selected = true;
                ProvList.Select();
            }
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            string receiver = providerMail;

            Process.Start("mailto:" + receiver);
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.ReadOnly == true)
            {
                idTextBox.ReadOnly = false;
                addTextBox.ReadOnly = false;
                MailTextBox.ReadOnly = false;
                WebTextBox.ReadOnly = false;
            }
            else
            {
                idTextBox.ReadOnly = true;
                addTextBox.ReadOnly = true;
                MailTextBox.ReadOnly = true;
                WebTextBox.ReadOnly = true;
                string sWeb = WebTextBox.Text;


                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(ProvList.SelectedItems[0].Name);
                var provider = db.Fournisseur.Find(code);

                if (idTextBox.Text != provider.Nom_Fournisseur)
                {
                    provider.Nom_Fournisseur = idTextBox.Text;
                    message += "- Nom du Fournisseur \n";
                    cptModifications++;
                }

                if (addTextBox.Text != provider.Adresse_Fournisseur)
                {
                    provider.Adresse_Fournisseur = addTextBox.Text;
                    message += "- Adresse du Fournisseur \n";
                    cptModifications++;
                }

                if (MailTextBox.Text != provider.Email_Fournisseur)
                {
                    provider.Email_Fournisseur = MailTextBox.Text;
                    message += "- E-mail du Fournisseur \n";
                    cptModifications++;
                }

                if (WebTextBox.Text != provider.Site_web_Fournisseur && WebTextBox.Text != sWeb)
                {
                    provider.Site_web_Fournisseur = WebTextBox.Text;
                    message += "- Site web du Fournisseur";
                    cptModifications++;
                }

                db.SaveChanges();

                updateProviders();

                if (cptModifications > 0)
                    MessageBox.Show(message);


            }
        }

        private void newP_Click(object sender, EventArgs e)
        {
            new AddProvider(db, 1).ShowDialog();
            updateProviders();
        }

        private void ProvList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ProvList.SelectedItems.Count != 0)
            {
                int code = int.Parse(ProvList.SelectedItems[0].Name);
                var provider = db.Fournisseur.Find(code);

                providerMail = provider.Email_Fournisseur;

                idTextBox.Text = provider.Nom_Fournisseur.ToString();
                addTextBox.Text = provider.Adresse_Fournisseur.ToString();
                MailTextBox.Text = provider.Email_Fournisseur.ToString();
                if (provider.Site_web_Fournisseur == null)
                {
                    WebTextBox.Text = "Site web inconnu";
                }
                else
                {
                    WebTextBox.Text = provider.Site_web_Fournisseur.ToString();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(ProvList.SelectedItems[0].Name);
            var fournisseur = db.Fournisseur.Find(code);

            db.Fournisseur.Remove(fournisseur);
            db.SaveChanges();
            updateProviders();
        }
    }
}

