using PT_Camping.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PT_Camping
{
    /// <summary>
    /// The ManagementUserControl is a UserControl handling the application's management process.
    /// It is designed to be derived by each management process.
    /// It provides a common AppBar for each management process with a back button to return to home,
    /// a title and a logout button.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
    public partial class ManagementUserControl : UserControl
    {
        protected HomeUserControl mHomeUC;
        protected DataBase Db;

        public ManagementUserControl()
        {
            InitializeComponent();
            logoutButton.FlatAppearance.BorderSize = 0;
        }

        public ManagementUserControl(HomeUserControl homeUserControl)
        {
            InitializeComponent();
            mHomeUC = homeUserControl;
            Personne personLoged = mHomeUC.Window.userLoged.Person;
            if (personLoged != null)
            {
                userNameLabel.Text = "Bonjour " + personLoged.Prenom_Personne + " " + personLoged.Nom_Personne;
            }
        }

        private void backArrow_Click(object sender, EventArgs e)
        {
            mHomeUC.Window.WindowPanel.Controls.Add(mHomeUC);
            mHomeUC.Window.WindowPanel.Controls.Remove(this);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            mHomeUC.Window.logout();
            mHomeUC.Window.WindowPanel.Controls.Remove(this);
        }


        internal void HandleResize()
        {
            Size = mHomeUC.Size;
            appBar.Size = new Size(mHomeUC.Size.Width, appBar.Size.Height);
        }


        public HomeUserControl HomeUC { get { return mHomeUC; } set { mHomeUC = value; } }
    }
}
