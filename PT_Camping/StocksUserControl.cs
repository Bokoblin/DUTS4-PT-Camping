using PT_Camping.Model;
using System;
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
            ProductListView.View = View.Details;
            ProductListView.Columns.Add("Produits",-2);
            ProductListView.Columns.Add("Quantité",-2,HorizontalAlignment.Center);

            fillStockListView();
            handleResize();
        }

        public void fillStockListView()
        {
            ProductListView.Items.Clear();
            foreach (var product in database.Produit)
            {
                string product_name = product.Libelle_Produit;
                string product_stock = product.Quantite_Stock.ToString();

                var item = new ListViewItem(new[] { product_name, product_stock });
                item.Name = product.Code_Produit.ToString();
                ProductListView.Items.Add(item);
            }

            if (ProductListView.Items.Count > 0)
            {
                ProductListView.Items[0].Selected = true;
                ProductListView.Select();
            }
        }

        private void updateIssueDetails()
         {
             if (ProductListView.SelectedItems.Count != 0)
             {
                 int code = int.Parse(ProductListView.SelectedItems[0].Name);
                 var product = db.Produit.Find(code);
 
                 idTextBox.Text = product.Code_Produit.ToString();
                 emplacementTextBox.Text = incident.Emplacement.Code_Emplacement.ToString();
                 typeTextBox.Text = incident.Type_Incident.Type_Incident1;
                 creationDateTextBox.Text = incident.Date_Incident.ToShortDateString();
                 resolutionDateTextBox.Text = incident.Date_Resolution.ToString();
                 criticStateTextBox.Text = incident.Criticite_Incident.ToString() + "/5";
                 stateTextBox.Text = incident.Avancement_Incident;
                 descriptionTextBox.Text = incident.Description_Incident;
             }
             
         }
        private void issuesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
             updateIssueDetails();
        }

        private void addStockButton_MouseClick(object sender, MouseEventArgs e)
        {
            addNewStock newStock = new addNewStock(this);
            newStock.Show();
        }
    }
}
