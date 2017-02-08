using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Camping
{
    /// <summary>
    /// The HomeUserControl is a UserControl handling the application's home screen.
    /// It allows access to a management process screen or the Card screen with a tab system.
    /// 
    /// Authors : Arthur
    /// Since : 08/08/17
    /// </summary>
    public partial class HomeUserControl : UserControl
    {
        private PT_Camping.Window mWindow;


        public HomeUserControl(PT_Camping.Window window)
        {
            InitializeComponent();
            mWindow = window;
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            mWindow.logout();
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void clientButton_Click(object sender, EventArgs e)
        {
            mWindow.WindowPanel.Controls.Add(new ClientsUserControl(this));
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void issuesButton_Click(object sender, EventArgs e)
        {
            mWindow.WindowPanel.Controls.Add(new IssuesUserControl(this));
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void employeeButton_Click(object sender, EventArgs e)
        {
            mWindow.WindowPanel.Controls.Add(new EmployeesUserControl(this));
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void stocksButton_Click(object sender, EventArgs e)
        {
            mWindow.WindowPanel.Controls.Add(new StocksUserControl(this));
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void providerButton_Click(object sender, EventArgs e)
        {
            mWindow.WindowPanel.Controls.Add(new ProvidersUserControl(this));
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void statsButton_Click(object sender, EventArgs e)
        {
            mWindow.WindowPanel.Controls.Add(new StatsUserControl(this));
            mWindow.WindowPanel.Controls.Remove(this);
        }

        /// <summary>
        /// Properties (Getters & Setters)
        /// </summary>

        public PT_Camping.Window Window { get { return mWindow; } set { mWindow = value; } }
    }
}
