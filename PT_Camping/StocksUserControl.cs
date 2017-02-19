using PT_Camping.Model;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PT_Camping
{
    /// <summary>
    /// The StocksUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's products stocks.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
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

            ProductListView.Columns.Add("Produits",-2);
            ProductListView.Columns.Add("Quantité",-2,HorizontalAlignment.Center);
            ProductListView.View = View.Details;
            foreach (var result in database.Produit)
            {
                string[] row1 = { result.Quantite_Stock.ToString() };
                ProductListView.Items.Add(result.Libelle_Produit).SubItems.AddRange(row1);
                //ProductListView.Items.Add(result.Libelle_Produit);
                //ProductListView.Items.Add(result.Quantite_Stock.ToString());
            }
            //ProductDataGridView.DataSource = query.ToList();
        }

        private void ProductListView_MouseClick(object sender, MouseEventArgs e)
        {
            
            string[] ProductInformation = {"jean","jaques" };
            ProductInformationListView.View = View.Details;
            ProductInformationListView.Items.Add("Nom").SubItems.Add(ProductInformation[0]);
            
            ProductInformationPanel.Controls.Add(ProductInformationListView);

            Controls.Add(ProductInformationPanel);
        }

        /*private void buttonAddStock_MouseClick(object sender, MouseEventArgs e)
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
        }*/
    }
}
