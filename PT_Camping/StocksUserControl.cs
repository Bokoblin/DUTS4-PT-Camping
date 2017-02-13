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
    /// The StocksUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's products stocks.
    /// 
    /// Authors : Arthur
    /// Since : 08/08/17
    /// </summary>
    public partial class StocksUserControl : ManagementUserControl
    {
        private DataBase database;

        public StocksUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = "Gestion des stocks";
            database = new DataBase();
            handleResize();

            /* -- Working example (to not execute again)
            Produit p = new Produit();
            p.Libelle_Produit = "Bouteille d'eau";
            p.Prix = 0.56F;
            p.Quantite_Stock = 54;
            database.Produit.Add(p);
            database.SaveChanges();
            */
            //DataGridView
            //SaveChanges()
            DataGridViewProduct.ReadOnly = true;
            DataGridViewProduct.DataSource = database.Produit.ToList();
            DataGridViewProduct.Columns["Code_Produit"].Visible = false;
            DataGridViewProduct.Columns["A_Vendu"].Visible = false;
            DataGridViewProduct.Columns["Fournisseur"].Visible = false;
            MessageBox.Show("There are : " + database.Produit.Count().ToString() + " products in store.");
        }
    }
}
