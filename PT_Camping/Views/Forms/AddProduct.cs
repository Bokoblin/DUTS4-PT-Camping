using System;
using System.Linq;
using System.Windows.Forms;
using PT_Camping.Model;

namespace PT_Camping.Views.Forms
{
    /// <summary>
    /// This dialog allows to add a new product
    /// by choosing a name, a quantity and a price
    /// 
    /// </summary>
    /// Authors : Yonnel
    /// Since : 09/03/17
    public partial class AddProduct : Form
    {
        private readonly DataBase _db;
        public AddProduct()
        {
            InitializeComponent();
            _db = new DataBase();
        }

        private void ButtonValid_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (productNameTextBox.Text == "" || productPriceTextBox.Text == "" 
                    || productStockTextBox.Text == "" || productCriticStockTextBox.Text == "")
                    throw new Exception("Toutes les valeurs marquées d'une étoile doivent être remplies.");

                if (productNameTextBox.Text.Any(char.IsDigit))
                    throw new Exception("Le nom du produit ne peut contenir de valeur numérique.");

                if (int.Parse(productStockTextBox.Text) < 0 || int.Parse(productCriticStockTextBox.Text) < 0)
                    throw new Exception("La quantité doit être positive.");


                if (_db.Produit.Count(p => p.Libelle_Produit == productNameTextBox.Text) == 1)
                    throw new Exception("Un produit du même nom existe déjà.");

                Produit product = new Produit
                {
                    Libelle_Produit = productNameTextBox.Text,
                    Quantite_Stock = Convert.ToInt32(productStockTextBox.Text),
                    Quantite_Critique = Convert.ToInt32(productCriticStockTextBox.Text),
                    Prix = Convert.ToDouble(productPriceTextBox.Text)
                };
                _db.Produit.Add(product);
                _db.SaveChanges();
                Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            } 
        }

        private void ProductStockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void ProductCriticStockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void ProductPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && e.KeyChar != ',' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
