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
    /// Authors : Arthur, Yonnel
    /// Since : 08/02/17
    public partial class StocksUserControl : ManagementUserControl
    {
        
        public StocksUserControl(HomeUserControl home) : base(home)
        {
            InitializeComponent();
            appBarTitle.Text = "Gestion des stocks";
            Db = new DataBase();

            productListView.View = View.Details;
            productListView.Columns.Add("Produits");
            productListView.Columns.Add("Quantité");

            UpdateStockListView();
            HandleResize();
        }


        public void UpdateStockListView()
        {
            productListView.Items.Clear();

            foreach (var product in Db.Produit)
            {
                string name = product.Libelle_Produit;
                string stock = product.Quantite_Stock.ToString();

                var item = new ListViewItem(new[] { name, stock })
                {
                    Name = product.Code_Produit.ToString()
                };

                if(product.Quantite_Stock == 0)
                {
                    item.BackColor = Color.Red;
                }
                else if(product.Quantite_Stock <= 15)
                {
                    item.BackColor = Color.Orange;
                }
                productListView.Items.Add(item);
            }

            //=== Select the first of the list

            if (productListView.Items.Count > 0)
            {
                productListView.Items[0].Selected = true;
                productListView.Select();
            }
        }


        private void UpdateProductDetails()
         {
             if (productListView.SelectedItems.Count != 0)
             {
                int code = int.Parse(productListView.SelectedItems[0].Name);
                var product = Db.Produit.Find(code);

                if (product == null) return;

                idTextBox.Text = product.Code_Produit.ToString();
                productNameTextBox.Text = product.Libelle_Produit;
                amountTextBox.Text = product.Quantite_Stock.ToString();
                priceTextBox.Text = product.Prix.ToString();
                providerComboBox.Items.Clear();
                foreach (var provider in Db.Fournisseur)
                {
                    providerComboBox.Items.Add(provider.Nom_Fournisseur);
                }
                if (providerComboBox.Items.Count != 0)
                    providerComboBox.Text = providerComboBox.Items[0].ToString();
            }
             
         }


        private void AddStockButton_Click(object sender, MouseEventArgs e)
        {
            addStock newStock = new addStock(this);
            newStock.Show();
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(productListView.SelectedItems[0].Name);
            var product = Db.Produit.Find(code);

            if (product != null)
            {
                Db.Produit.Remove(product);
                Db.SaveChanges();
                UpdateStockListView();
            }
                
        }

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            if(priceTextBox.ReadOnly)
            { 
                resetButton.Visible = true;
                priceTextBox.ReadOnly = false;
                amountTextBox.ReadOnly = false;
                productNameTextBox.ReadOnly = false;
                providerComboBox.Enabled = true;
            }
            else
            {
                amountTextBox.ReadOnly = true;
                priceTextBox.ReadOnly = true;
                productNameTextBox.ReadOnly = true;
                resetButton.Visible = false;
                providerComboBox.Enabled = false;

                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(productListView.SelectedItems[0].Name);
                var product = Db.Produit.Find(code);

                if(product != null)
                {
                    //To refactor a lot -- devrait planter en l'état
                    try
                    {
                        product.Quantite_Stock = Convert.ToInt32(amountTextBox.Text);
                        message += "quantité\n";
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("La quantité n'est pas correcte");
                    }

                    product.Libelle_Produit = productNameTextBox.Text;
                    try
                    {
                        product.Prix = Convert.ToDouble(priceTextBox.Text);
                        message += "prix\n";
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Prix incorrect !");
                    }
                    /*
                    try
                    {
                        
                    }
                    catch(DbUpdateException)
                    {
                        MessageBox.Show("Le nom de produit existe déjà !");
                    }*/
                }

                Db.SaveChanges();
                UpdateProductDetails();

                if (cptModifications > 0)
                    MessageBox.Show(message);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetButton.Visible = false;
            UpdateProductDetails();
        }


        private void commandButton_Click(object sender, EventArgs e)
        {
            string nomPersonne = mHomeUserControl.Window.userLoged.Person.Nom_Personne;
            string prenomPersonne = mHomeUserControl.Window.userLoged.Person.Prenom_Personne;
            string emailPersonne = mHomeUserControl.Window.userLoged.Person.Email;

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

        private void SellButton_Click(object sender, EventArgs e)
        {
            SellStock sellStock = new SellStock(this, productListView.SelectedItems[0].Name);
            sellStock.Show();
            
        }



        private void ProductListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            amountTextBox.ReadOnly = true;
            priceTextBox.ReadOnly = true;
            productNameTextBox.ReadOnly = true;
            resetButton.Visible = false;
            providerComboBox.Enabled = false;
            UpdateProductDetails();
        }

        private void productListView_Resize(object sender, EventArgs e)
        {
            if( productListView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in productListView.Columns)
                    columnHeader.Width = productListView.Width / productListView.Columns.Count;
            }
        }
    }
}
