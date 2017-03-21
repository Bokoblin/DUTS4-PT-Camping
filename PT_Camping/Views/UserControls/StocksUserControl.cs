using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Properties;
using PT_Camping.Views.Forms;

namespace PT_Camping.Views.UserControls
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
            appBarTitle.Text = Resources.product_management;
            appBarTitle.Text = Resources.product_management;

            productListView.View = View.Details;
            productListView.Columns.Add("Etat");
            productListView.Columns.Add("Produit");
            productListView.Columns.Add("Quantité");

            var imageList = new ImageList();
            imageList.Images.Add("low", Resources.ic_stock_low);
            imageList.Images.Add("empty", Resources.ic_stock_empty);
            imageList.ImageSize = new Size(20, 20);
            productListView.SmallImageList = imageList;

            UpdateProductListView();
            HandleResize();
            InitPermissions();
        }

        public void InitPermissions()
        {
            addStockButton.Enabled = UserRights.Any(d => d.Libelle_Droit == "writeStocks");
            deleteProductButton.Visible = UserRights.Any(d => d.Libelle_Droit == "writeStocks");
            editButton.Visible = UserRights.Any(d => d.Libelle_Droit == "writeStocks");
            sellButton.Enabled = UserRights.Any(d => d.Libelle_Droit == "writeStocks");
        }


        public StocksUserControl(HomeUserControl home, int code) : this(home)
        {
            foreach (ListViewItem item in productListView.Items)
            {
                item.Selected = item.Name == code.ToString();
            }
        }


        public void UpdateProductListView()
        {
            productListView.Items.Clear();

            foreach (var product in Db.Produit)
            {
                string name = product.Libelle_Produit;
                string stock = product.Quantite_Stock.ToString();

                var item = new ListViewItem(new[] { "", name, stock })
                {
                    Name = product.Code_Produit.ToString(),
                    ImageKey = (product.Quantite_Stock <= 15) 
                                ? (product.Quantite_Stock == 0)
                                ? "empty" : "low" : ""
                };

                productListView.Items.Add(item);
            }

            //=== Select the first of the list

            if (productListView.Items.Count > 0)
            {
                productListView.Items[0].Selected = true;
                productListView.Select();
            }
        }


        public void UpdateProductDetails()
        {
            if (productListView.SelectedItems.Count != 0)
            {
                int code = int.Parse(productListView.SelectedItems[0].Name);
                var product = Db.Produit.Find(code);

                if (product == null) return;

                idTextBox.Text = product.Code_Produit.ToString();
                productNameTextBox.Text = product.Libelle_Produit;
                amountTextBox.Text = product.Quantite_Stock.ToString();
                priceTextBox.Text = product.Prix.ToString("N2") + CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;
                providerComboBox.Items.Clear();
                providerComboBox.Items.Add("Aucun");
                foreach (var provider in Db.Fournisseur)
                {
                    providerComboBox.Items.Add(provider.Nom_Fournisseur);
                }
                providerComboBox.Text = product.Fournisseur.Count == 0
                    ? providerComboBox.Items[0].ToString()
                    : product.Fournisseur.First().Nom_Fournisseur;
            }
        }


        private void AddStockButton_Click(object sender, MouseEventArgs e)
        {
            AddStock newStock = new AddStock();
            newStock.ShowDialog();
            Cursor.Current = Cursors.Default;
            UpdateProductListView();
        }


        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(Resources.delete_item_confirm_message,
                                        "", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int code = int.Parse(productListView.SelectedItems[0].Name);
                var product = Db.Produit.Find(code);

                if (product != null)
                {
                    Db.Produit.Remove(product);
                    Db.SaveChanges();
                    UpdateProductListView();
                }
            }
        }


        private void EditProductButton_Click(object sender, EventArgs e)
        {
            if (priceTextBox.ReadOnly)
            {
                resetButton.Visible = true;
                priceTextBox.ReadOnly = false;
                amountTextBox.ReadOnly = false;
                productNameTextBox.ReadOnly = false;
                providerComboBox.Enabled = true;
                editButton.BackgroundImage = Resources.ic_done;
            }
            else
            {
                amountTextBox.ReadOnly = true;
                priceTextBox.ReadOnly = true;
                productNameTextBox.ReadOnly = true;
                resetButton.Visible = false;
                providerComboBox.Enabled = false;
                editButton.BackgroundImage = Resources.ic_edit;

                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(productListView.SelectedItems[0].Name);
                var product = Db.Produit.Find(code);

                if (product != null)
                {
                    if (productNameTextBox.Text != product.Libelle_Produit)
                    {
                        if (productNameTextBox.Text == "")
                            MessageBox.Show(Resources.null_product_name_exception);
                        else if (productNameTextBox.Text.Any(char.IsDigit))
                            MessageBox.Show(Resources.novalue_product_name_exception);
                        else
                        {
                            product.Libelle_Produit = productNameTextBox.Text;
                            message += "libellé, ";
                            cptModifications++;
                        }

                    }

                    if (amountTextBox.Text != product.Quantite_Stock.ToString())
                    {
                        try
                        {
                            if (int.Parse(amountTextBox.Text) < 0)
                                MessageBox.Show(Resources.non_positive_quantity_exception);
                            else
                            {
                                product.Quantite_Stock = int.Parse(amountTextBox.Text);
                                message += "quantité, ";
                                cptModifications++;
                            }
                        }
                        catch (OverflowException)
                        {
                            MessageBox.Show(Resources.high_quantity_exception);
                        }
                    }

                    if (priceTextBox.Text != (product.Prix.ToString("N2") + CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol))
                    {
                        product.Prix = double.Parse(priceTextBox.Text.Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, ""));
                        message += "prix, ";
                        cptModifications++;
                    }

                    if ((product.Fournisseur.Count == 0 && providerComboBox.Text != Resources.none)
                        || (product.Fournisseur.Count != 0 && providerComboBox.Text != product.Fournisseur.First().Nom_Fournisseur))
                    {
                        product.Fournisseur.Clear();
                        if (providerComboBox.Text != Resources.none)
                        {
                            product.Fournisseur.Add(Db.Fournisseur.First(
                            f => f.Nom_Fournisseur == providerComboBox.Text));
                        }
                        message += "fournisseur responsable";
                        cptModifications++;
                    }

                    Db.SaveChanges();
                    UpdateProductDetails();
                    UpdateProductListView();

                    foreach (ListViewItem item in productListView.Items)
                    {
                        item.Selected = item.Name == code.ToString();
                    }
                    productListView.Select();

                    if (cptModifications > 0)
                        MessageBox.Show(message);
                }
            }
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            UpdateProductDetails();
            resetButton.Visible = false;
            amountTextBox.ReadOnly = true;
            priceTextBox.ReadOnly = true;
            productNameTextBox.ReadOnly = true;
            providerComboBox.Enabled = false;
            editButton.BackgroundImage = Resources.ic_edit;
        }


        private void CommandButton_Click(object sender, EventArgs e)
        {
            string employeeSurname = LoginTools.Employee.Personne.Nom_Personne;
            string employeeName = LoginTools.Employee.Personne.Prenom_Personne;

            const string subject = "Commande d'un produit";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dear " + providerComboBox.SelectedItem + ", \n");
            sb.AppendLine("Nous souhaitons vous commander le produit " + productNameTextBox.Text + " en 42 exemplaires.");
            sb.AppendLine("Cordialement,");
            sb.AppendLine(employeeName + " " + employeeSurname);
            string body = sb.ToString();
            string receiver = "";
            if (providerComboBox.SelectedItem != null)
            {
                receiver = Db.Fournisseur.Where(f => f.Nom_Fournisseur == providerComboBox.SelectedItem.ToString()).Select(f => f.Email_Fournisseur).First();
            }

            Process.Start("mailto:" + receiver + "?subject=" + subject + "&body=" + body);
        }


        private void SellButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(productListView.SelectedItems[0].Name);
            var product = Db.Produit.Find(code);
            SellStock sellStock = new SellStock(Db, product);
            sellStock.ShowDialog();
            UpdateProductListView();
            UpdateProductDetails();

            foreach (ListViewItem item in productListView.Items)
            {
                item.Selected = item.Name == code.ToString();
            }
            productListView.Select();
        }


        private void ProductListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.BackgroundImage = Resources.ic_edit;
            amountTextBox.ReadOnly = true;
            priceTextBox.ReadOnly = true;
            productNameTextBox.ReadOnly = true;
            resetButton.Visible = false;
            providerComboBox.Enabled = false;
            UpdateProductDetails();
        }


        private void ProductListView_Resize(object sender, EventArgs e)
        {
            if (productListView.Columns.Count != 0)
            {
                productListView.Columns[0].Width = 34;
                productListView.Columns[1].Width = productListView.Width / 2 - 17;
                productListView.Columns[2].Width = productListView.Width / 2 - 17;
            }
        }


        private void ProductNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (productNameTextBox.Text.Length > 30)
                e.Handled = true;
        }


        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != ',' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void PriceTextBox_Enter(object sender, EventArgs e)
        {
            if (!priceTextBox.ReadOnly)
                priceTextBox.Text = priceTextBox.Text.Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, "");
        }


        private void PriceTextBox_Leave(object sender, EventArgs e)
        {
            if (!priceTextBox.ReadOnly)
                priceTextBox.Text = priceTextBox.Text
                + CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;
        }
    }
}