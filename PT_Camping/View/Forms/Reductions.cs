using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Camping.Model;

namespace PT_Camping.View.Forms
{

    //FAIRE TU SUR LA FONCTION calculPercentFidelity() & calculReducTotal()
    public partial class Reductions : Form
    {
        private int reducPourcentage;
        private int reducFidelity;
        private Client client;
        private int reducTotal;


        public Reductions(Client client)
        {
            InitializeComponent();
            reducPourcentage = 0;
            reducFidelity = 0;
            reducTotal = 0;
            this.client = client;
            calculPercentFidelity();

        }

        private void ReducButtonSelected(object sender, EventArgs e)
        {
            if (radioEtudiantButton.Checked)
                reducPourcentage = 5;
            else if (radioSeniorButton.Checked)
                reducPourcentage = 5;
            else if (radioFamilyButton.Checked)
                reducPourcentage = 10;
            else if (radioGroupButton.Checked)
                reducPourcentage = 15;
        }

        private void calculPercentFidelity()
        {
            int nbYearsFidelity = DateTime.Now.Year - client.Date_Inscription.Year;
            for (int i = 0; i < nbYearsFidelity; i++)
            {
                if(i == 0 % 5)
                {
                  reducFidelity += 2;
                }
            }
            percentageSeniorLabel.Text = reducFidelity.ToString() + " % ";
        }

        private void calculReducTotal()
        {
            reducTotal = reducPourcentage + reducFidelity;
        }

    }

  
}
