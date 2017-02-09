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
        private AppWindow mWindow;


        public ConnectionUserControl(AppWindow window)
        {
            InitializeComponent();
            mWindow = window;
            handleResize();
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            mWindow.login();
        }

        internal void handleResize()
        {
            Size = mWindow.Size;
            appBar.Size = new Size(mWindow.Size.Width, appBar.Size.Height);
        }
    }
}
