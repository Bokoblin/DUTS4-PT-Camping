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
    /// Authors : Arthur
    /// Since : 08/08/17
    /// </summary>
    public partial class ProvidersUserControl : ManagementUserControl
    {
        int cpt = 0;
        public ProvidersUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = "Gestion des fournisseurs";
            handleResize();
            /*DataBase bdd = new DataBase();
            foreach (Fournisseur f in bdd.Fournisseur){
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(f.Nom_Fournisseur);
                listView1.Items.AddRange(new ListViewItem[] { item });
            }*/
            DataBase bdd = new DataBase();
            listF.DataSource = bdd.Fournisseur.ToList();
            listF.RowHeadersVisible = false;
            listF.Columns["Code_Fournisseur"].Visible = false;
            listF.Columns["Nom_Fournisseur"].Width = 150;
        }


        private void listF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Fournisseur f = (Fournisseur)sender;
            cpt++;
            detailsF.Items.Clear();
            string nom = "test" + cpt;
            detailsF.Items.Add(nom, 1);
        }
    }
}
