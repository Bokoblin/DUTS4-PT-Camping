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
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PT_Camping
{
    public partial class CommandStock : Form
    {
        DataBase database = new DataBase();
        public CommandStock(string productName)
        {
            InitializeComponent();
            var providers = database.Fournisseur;
            foreach(var provider in providers)
            {
                if (provider.est_approuvé == true)
                {
                    providerComboBox.Items.Add(provider.Nom_Fournisseur);
                }
            }
            productNameTextBox.Text = productName;
            if(providerComboBox.Items != null)
            {
                providerComboBox.Text = providerComboBox.Items[0].ToString();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void commandButton_Click(object sender, EventArgs e)
        {
            string subject = "Commande d'un produit";
            string body = "Dear %NAME_FoURNISSEUR%, \n\nNous souhaitons vous commender le "
                + "produits %PODUIT_NAME% en %QUANTITE% exemplaires. \n\nCordialement, \n\n "
                + "%USER NAME% + %USER_SURNAME%";

            string receiver = "UserControl@example.fr";

            Process.Start("mailto:" + receiver +"?subject=" + subject + "&body=" + body);
        }
    }
}
