using PT_Camping.Model;
using System;
using System.Data.Entity.Infrastructure;
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
                if(product.Quantite_Stock<=5)
                {
                    item.BackColor = Color.Red;
                }
                else if(product.Quantite_Stock>5 && product.Quantite_Stock<=15)
                {
                    item.BackColor = Color.Orange;
                }
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
                var product = database.Produit.Find(code);

                idTextBox.Text = product.Code_Produit.ToString();
                productNameTextBox.Text = product.Libelle_Produit.ToString();
                amountTextBox.Text = product.Quantite_Stock.ToString();
                priceTextBox.Text = product.Prix.ToString();

            }
             
         }

        private void addStockButton_MouseClick(object sender, MouseEventArgs e)
        {
            addStock newStock = new addStock(this);
            newStock.Show();
        }

        private void ProductListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIssueDetails();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(ProductListView.SelectedItems[0].Name);
            var product = database.Produit.Find(code);

            database.Produit.Remove(product);
            database.SaveChanges();
            fillStockListView();
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            if(amountTextBox.ReadOnly)
            { 
                editProductButton.Text = "Valider";
                resetButton.Visible = true;
                amountTextBox.ReadOnly = false;
                priceTextBox.ReadOnly = false;
                productNameTextBox.ReadOnly = false;
            }
            else
            {
                editProductButton.Text = "Modifier";
                amountTextBox.ReadOnly = true;
                priceTextBox.ReadOnly = true;
                productNameTextBox.ReadOnly = true;
                resetButton.Visible = false;

                int code = int.Parse(ProductListView.SelectedItems[0].Name);
                var product = database.Produit.Find(code);

                try
                {
                    product.Quantite_Stock = Convert.ToInt32(amountTextBox.Text);
                }
                catch(FormatException fe)
                {
                    MessageBox.Show("La quantité n'est pas correcte");
                }

                product.Libelle_Produit = productNameTextBox.Text;
                try
                {
                    product.Prix = Convert.ToDouble(priceTextBox.Text);
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Prix incorrect !");
                }
                try
                {
                    database.SaveChanges();
                }
                catch(DbUpdateException)
                {
                    MessageBox.Show("Le nom de produit existe déjà !");
                }
                
                updateIssueDetails();
                fillStockListView();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetButton.Visible = false;
            editProductButton.Text = "Modifier";
            updateIssueDetails();
        }

        private void productProviderButton_Click(object sender, EventArgs e)
        {
            ProviderChoice providerChoice = new ProviderChoice();
            providerChoice.ShowDialog();
        }

        private void commandButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(ProductListView.SelectedItems[0].Name);
            var product = database.Produit.Find(code);
            CommandStock commandStock = new CommandStock(productNameTextBox.Text);
            commandStock.ShowDialog();
        }
    }
}
