using PT_Camping.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Camping
{
    public partial class addStock : Form
    {
        DataBase dataBase;
        public addStock()
        {
            InitializeComponent();
            dataBase = new DataBase();
        }

        private void buttonValid_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                if (productNameTextBox.Text == "" || productPriceTextBox.Text == "" || productStockTextBox.Text == "")
                    throw new Exception("Toutes les valeurs marquées d'une étoile doivent être remplies.");

                if (productNameTextBox.Text.Any(char.IsDigit))
                    throw new Exception("Le nom du produit ne peut contenir de valeur numérique.");

                if (int.Parse(productStockTextBox.Text) < 0)
                    throw new Exception("La quantité doit être positive.");


                if (dataBase.Produit.Count(p => p.Libelle_Produit == productNameTextBox.Text) == 1)
                    throw new Exception("Un produit du même nom existe déjà.");

                Produit product = new Produit();
                product.Libelle_Produit = productNameTextBox.Text;
                product.Quantite_Stock = Convert.ToInt32(productStockTextBox.Text);
                product.Prix = Convert.ToDouble(productPriceTextBox.Text);
                dataBase.Produit.Add(product);
                dataBase.SaveChanges();
                Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void productStockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void productPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && e.KeyChar != ',' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
