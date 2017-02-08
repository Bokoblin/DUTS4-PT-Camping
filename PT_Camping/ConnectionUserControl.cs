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
    /// The ConnectionUserControl is a UserControl handling the application's authentication at launch.
    /// Home can't be accessed if the user is not authenticated.
    /// 
    /// Authors : Arthur
    /// Since : 07/08/17
    /// </summary>
    public partial class ConnectionUserControl : UserControl
    {
        private PT_Camping.Window mWindow;


        public ConnectionUserControl(PT_Camping.Window window)
        {
            InitializeComponent();
            mWindow = window;
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            mWindow.login();
        }
    }
}
