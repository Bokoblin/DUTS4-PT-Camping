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

namespace PT_Camping
{
    /// <summary>
    /// The ProvidersUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's stocks providers.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
    public partial class ProvidersUserControl : ManagementUserControl
    {
        public ProvidersUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = "Gestion des fournisseurs";

            db = new DataBase();

            ProvList.View = View.Details;
            ProvList.Columns.Add("Nom du fournisseur", -2);

            updateProviders();

            handleResize();
        }

        public void updateProviders()
        {
            ProvList.Items.Clear();

            foreach (var fournisseur in db.Fournisseur)
            {
                string nom_fournisseur = fournisseur.Nom_Fournisseur;

                /*foreach (var produit in db.Fournisseur){ fjfjf}*/

                var item = new ListViewItem(new[] { nom_fournisseur });
                item.Name = fournisseur.Code_Fournisseur.ToString();
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
                var fournisseur = db.Fournisseur.Find(code);

                if (idTextBox.Text != fournisseur.Nom_Fournisseur)
                {
                    fournisseur.Nom_Fournisseur = idTextBox.Text;
                    message += "- Nom du Fournisseur \n";
                    cptModifications++;
                }

                if (addTextBox.Text != fournisseur.Adresse_Fournisseur)
                {
                    fournisseur.Adresse_Fournisseur = addTextBox.Text;
                    message += "- Adresse du Fournisseur \n";
                    cptModifications++;
                }

                if (MailTextBox.Text != fournisseur.Email_Fournisseur)
                {
                    fournisseur.Email_Fournisseur = MailTextBox.Text;
                    message += "- E-mail du Fournisseur \n";
                    cptModifications++;
                }

                if (WebTextBox.Text != fournisseur.Site_web_Fournisseur && WebTextBox.Text!= sWeb)
                {
                    fournisseur.Site_web_Fournisseur = WebTextBox.Text;
                    message += "- Site web du Fournisseur";
                    cptModifications++;
                }

                db.SaveChanges();

                updateProviders();

                if (cptModifications > 0)
                    MessageBox.Show(message);


            }
        }

        private void ProvList_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (ProvList.SelectedItems.Count != 0)
            {
                int code = int.Parse(ProvList.SelectedItems[0].Name);
                var fournisseur = db.Fournisseur.Find(code);

                idTextBox.Text = fournisseur.Nom_Fournisseur.ToString();
                addTextBox.Text = fournisseur.Adresse_Fournisseur.ToString();
                MailTextBox.Text = fournisseur.Email_Fournisseur.ToString() ;
                if (fournisseur.Site_web_Fournisseur == null)
                {
                    WebTextBox.Text = "Site web inconnu";
                }
                else
                {
                    WebTextBox.Text = fournisseur.Site_web_Fournisseur.ToString();
                }
            }
        }
    }
}

