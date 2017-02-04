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
    /// Fenêtre de connexion à l'application.
    /// L'accès à l'application ne se fait que si le nom d'utilisateur 
    /// et le mot de passe sont valides.
    /// </summary>
    public partial class Connexion : Form
    {
        public Connexion()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void boutonEntrer_Click(object sender, EventArgs e)
        {
            //stub -- à implémenter
            Accueil accueil = new Accueil();
            accueil.Width = this.Width;
            accueil.Height = this.Height;
            accueil.StartPosition = this.StartPosition;
            accueil.Show();
            this.Hide();
        }
    }
}
