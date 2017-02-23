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
    public partial class addNewStock : Form
    {
        DataBase dataBase;
        StocksUserControl stockControl;
        public addNewStock(StocksUserControl stockControl)
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
            product.Quantite_Stock = Convert.ToInt32(productStockTextBox.Text);
            product.Prix = Convert.ToDouble(productPriceTextBox.Text);
            dataBase.Produit.Add(product);
            dataBase.SaveChanges();
            stockControl.fillStockListView();
            
        }
    }
}
