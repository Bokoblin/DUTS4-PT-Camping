using PT_Camping.Model;
using System;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private String nomPersonne;
        private String prenomPersonne;
        private String emailPersonne;
        public StocksUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = "Gestion des stocks";
            database = new DataBase();

            nomPersonne = homeUserControl.Window.userLoged.Person.Nom_Personne;
            prenomPersonne = homeUserControl.Window.userLoged.Person.Prenom_Personne;
            emailPersonne = homeUserControl.Window.userLoged.Person.Email;

            ProductListView.View = View.Details;
            ProductListView.Columns.Add("Produits",-2);
            ProductListView.Columns.Add("Quantité",-2,HorizontalAlignment.Center);

            fillStockListView();
            handleResize();
        }
        public void fillProviderComboBox()
        {
            providerComboBox.Items.Clear();
            foreach (var provider in database.Fournisseur)
            {
                providerComboBox.Items.Add(provider.Nom_Fournisseur);
            }
            if (providerComboBox.Items != null)
            {
                providerComboBox.Text = providerComboBox.Items[0].ToString();
            }

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
                fillProviderComboBox();
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
                resetButton.Visible = true;
                amountTextBox.ReadOnly = false;
                priceTextBox.ReadOnly = false;
                productNameTextBox.ReadOnly = false;
            }
            else
            {
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
            updateIssueDetails();
        }

        private void commandButton_Click(object sender, EventArgs e)
        {
            string subject = "Commande d'un produit";
            string body = "Dear "+ providerComboBox.SelectedItem.ToString()+ ", <br /> Nous souhaitons vous commander le "
                + "produit "+ productNameTextBox.Text+" en 42 exemplaires. <br /> Cordialement, <br /> "
                + prenomPersonne + " " + nomPersonne;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dear " + providerComboBox.SelectedItem.ToString() +", ").Append("\r\n\r\n");
            sb.AppendLine("Nous souhaitons vous commander le "
                + "produit " + productNameTextBox.Text + " en 42 exemplaires.");
            body = sb.ToString();
            string receiver = emailPersonne;

            Process.Start("mailto:" + receiver + "?subject=" + subject + "&body=" + body);
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            SellStock sellStock = new SellStock(this, ProductListView.SelectedItems[0].Name);
            sellStock.Show();
        }
    }
}
