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
    /// <summary>
    /// Fenêtre de l'écran d'accueil
    /// Permet via deux tabs l'accès aux processus de gestion ou la carte permettant
    /// d'ajouter/déplacer/supprimer des emplacements, d'y créer des incidents
    /// </summary>
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            AccueilTabControl.ItemSize = new Size(AccueilTabControl.Width / AccueilTabControl.TabCount, 0);
        }

        private void boutonClient_Click(object sender, EventArgs e)
        {
            //basculer vers la winform client
        }
    }
}
