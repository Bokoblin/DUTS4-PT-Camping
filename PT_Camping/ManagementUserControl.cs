using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Camping.Model;

namespace PT_Camping
{
    /// <summary>
    /// The ManagementUserControl is a UserControl handling the application's management process.
    /// It is designed to be derived by each management process.
    /// It provides a common AppBar for each management process with a back button to return to home,
    /// a title and a logout button.
    /// 
    /// Authors : Arthur
    /// Since : 08/08/17
    /// </summary>
    public partial class ManagementUserControl : UserControl
    {
        protected HomeUserControl mHomeUserControl;

        public ManagementUserControl()
        {
            InitializeComponent();
            logoutButton.FlatAppearance.BorderSize = 0;
        }

        public ManagementUserControl(HomeUserControl homeUserControl)
        {
            InitializeComponent();
            mHomeUserControl = homeUserControl;
            Personne personLoged = mHomeUserControl.Window.userLoged.Person;
            if (personLoged != null)
            {
                userNameLabel.Text = "Bonjour " + personLoged.Nom_Personne.Substring(0, 1) + " " + personLoged.Prenom_Personne;
            }
        }

        private void backArrow_Click(object sender, EventArgs e)
        {
            mHomeUserControl.Window.WindowPanel.Controls.Add(mHomeUserControl);
            mHomeUserControl.Window.WindowPanel.Controls.Remove(this);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            mHomeUserControl.Window.logout();
            mHomeUserControl.Window.WindowPanel.Controls.Remove(this);
        }


        internal void handleResize()
        {
            Size = mHomeUserControl.Size;
            appBar.Size = new Size(mHomeUserControl.Size.Width, appBar.Size.Height);
        }
    }
}
