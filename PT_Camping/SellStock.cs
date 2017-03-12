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
        String productName;
        DataBase database;
        StocksUserControl stockControl;
        public SellStock(StocksUserControl stockControl, String productName)
        {
            InitializeComponent();

            database = new DataBase();

            this.stockControl = stockControl;
            this.productName = productName;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void validButton_Click(object sender, EventArgs e)
        {
            if(amountTextBox.Text != "")
            {
                int code = int.Parse(productName);
                var product = database.Produit.Find(code);
                product.Quantite_Stock = product.Quantite_Stock - Convert.ToInt32(amountTextBox.Text);
                database.SaveChanges();
                stockControl.fillStockListView();
                Close();
            }
        }
    }
}
