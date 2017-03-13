using PT_Camping.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Camping
{
    public partial class SellStock : Form
    {
        string productName;
        DataBase database;
        public SellStock(DataBase db, string productName)
        {
            InitializeComponent();

            database = db;

            this.productName = productName;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void validButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(productName);
            var product = database.Produit.Find(code);
            try
            {
                if (amountTextBox.Text == "")
                    throw new Exception("La quantité ne peut pas être nulle.");

                if (int.Parse(amountTextBox.Text.ToString()) > product.Quantite_Stock)
                    throw new Exception("La quantité à vendre doit être inférieure au stock.");

                if (int.Parse(amountTextBox.Text) <= 0)
                    throw new Exception("La quantité doit être supérieure à 0.");

                product.Quantite_Stock = product.Quantite_Stock - Convert.ToInt32(amountTextBox.Text);
                database.SaveChanges();
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
