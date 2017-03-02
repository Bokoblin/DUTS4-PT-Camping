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
        StocksUserControl stockControl;
        public addStock(StocksUserControl stockControl)
        {
            InitializeComponent();
            dataBase = new DataBase();
            this.stockControl = stockControl;
        }

        public object Integer { get; private set; }

        private void buttonValid_MouseClick(object sender, MouseEventArgs e)
        {
            Produit product = new Produit();
            product.Libelle_Produit = productNameTextBox.Text;
            try
            {  
                product.Quantite_Stock = Convert.ToInt32(productStockTextBox.Text);
            }
            catch(FormatException fe)
            {
                MessageBox.Show("La quantité n'est pas correcte !");
            }
            try
            {
                product.Prix = Convert.ToDouble(productPriceTextBox.Text);
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Prix incorrect !");
            }
            try
            {
                if (productNameTextBox.Text != "" && productPriceTextBox.Text != "" && productStockTextBox.Text != "")
                {
                    dataBase.Produit.Add(product);
                    dataBase.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Tout les champs ne sont pas remplis !");
                }
            }
            catch(DbUpdateException)
            {
                MessageBox.Show("Impossible d'insérer le produit : celui-ci existe déjà !");
                productNameTextBox.Text = "";
                productPriceTextBox.Text = "";
                productStockTextBox.Text = "";
            }
            stockControl.fillStockListView();
        }
    }
}
