using System;
using System.Windows.Forms;
using PT_Camping.Model;

namespace PT_Camping.Views.Forms
{
    public partial class SellStock : Form
    {
        readonly Produit _product;
        readonly DataBase _db;
        public SellStock(DataBase db, Produit product)
        {
            InitializeComponent();
            _db = db;
            _product = product;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ValidButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (amountTextBox.Text == "")
                    throw new Exception("La quantité ne peut pas être nulle.");

                if (int.Parse(amountTextBox.Text) > _product.Quantite_Stock)
                    throw new Exception("La quantité à vendre doit être inférieure au stock.");

                if (int.Parse(amountTextBox.Text) <= 0)
                    throw new Exception("La quantité doit être supérieure à 0.");

                _product.Quantite_Stock = _product.Quantite_Stock - Convert.ToInt32(amountTextBox.Text);
                _db.SaveChanges();
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
