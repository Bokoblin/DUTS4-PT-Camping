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
using System.Data.Entity.Core.Objects;

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
            //SaveChanges()
            /*
            MessageBox.Show("There are : " + database.Produit.Count().ToString() + " products in store.");*/
            //var query = from produit in database.Produit select produit.Libelle_Produit;

            foreach (var result in database.Produit )
            {
                ProductListView.Items.Add(result.Libelle_Produit);
            }
            //ProductDataGridView.DataSource = query.ToList();
        }

        private void buttonAddStock_MouseClick(object sender, MouseEventArgs e)
        {
            Panel dynamicPanel = new Panel();
            dynamicPanel.Location = new System.Drawing.Point(26, 12);
            dynamicPanel.Name = "Panel1";
            dynamicPanel.Size = new System.Drawing.Size(228, 200);
            dynamicPanel.BackColor = Color.LightBlue;


            TextBox textBox1 = new TextBox();
            textBox1.Location = new Point(10, 10);
            textBox1.Text = "I am a TextBox5";
            textBox1.Size = new Size(200, 30);

            CheckBox checkBox1 = new CheckBox();
            checkBox1.Location = new Point(10, 50);
            checkBox1.Text = "Check Me";
            checkBox1.Size = new Size(200, 30);

            dynamicPanel.Controls.Add(textBox1);
            dynamicPanel.Controls.Add(checkBox1);

            Controls.Add(dynamicPanel);
        }
    }
}
