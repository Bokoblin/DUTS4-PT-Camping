using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Camping.Model;
using System.Data.Entity;

namespace PT_Camping
{
    public partial class ProviderChoice : Form
    {
        DataBase database;
        CheckBox providerCheckBox;
        List<CheckBox> providersCheckBox;
        int i;
        public ProviderChoice()
        {
            InitializeComponent();
            database = new DataBase();
            providersCheckBox = new List<CheckBox>();

            var providers = database.Fournisseur;
            foreach(Fournisseur provider in providers)
            {
                providerCheckBox = new CheckBox();
                providerCheckBox.Name = provider.Code_Fournisseur.ToString();
                providerCheckBox.Text = provider.Nom_Fournisseur;
                providerCheckBox.Size = new Size(80, 17);
                providerCheckBox.CheckedChanged += providersCheckBox_CheckedChanged;
                if (provider.est_approuvé == true)
                {
                    providerCheckBox.Checked = true;
                }
                providersCheckBox.Add(providerCheckBox);
            }
            i = 0;
            foreach(CheckBox checkBox in providersCheckBox)
            {
                checkBox.Location = new Point(90*i, 20);
                this.Controls.Add(checkBox);
                i++;
            }

        }
        private void providersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach(var providerCheckBox in providersCheckBox)
            {
                int code = int.Parse(providerCheckBox.Name);
                var provider = database.Fournisseur.Find(code);
                if (providerCheckBox.Checked == true)
                {
                    provider.est_approuvé = true;
                }
                else
                {
                    provider.est_approuvé = false;
                }
                database.SaveChanges();
            }
            
        }

        private void validButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
