using System;
using System.Drawing;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Properties;

namespace PT_Camping.Views.UserControls
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
        protected DataBase Db;

        public ManagementUserControl()
        {
            InitializeComponent();
            logoutButton.FlatAppearance.BorderSize = 0;
        }

        public ManagementUserControl(HomeUserControl homeUserControl)
        {
            InitializeComponent();
            HomeUc = homeUserControl;
            Employe employeeLoged = HomeUc.Window.UserLoged.Employee;
            if (employeeLoged != null)
            {
                userNameLabel.Text = Resources.hello_user + employeeLoged.Personne.Prenom_Personne + " " + employeeLoged.Personne.Nom_Personne;
            }
        }

        private void BackArrow_Click(object sender, EventArgs e)
        {
            HomeUc.Window.WindowPanel.Controls.Add(HomeUc);
            HomeUc.Window.WindowPanel.Controls.Remove(this);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            HomeUc.Window.Logout();
            HomeUc.Window.WindowPanel.Controls.Remove(this);
        }


        internal void HandleResize()
        {
            Size = HomeUc.Size;
            appBar.Size = new Size(HomeUc.Size.Width, appBar.Size.Height);
        }


        public HomeUserControl HomeUc {get; set; }
    }
}
