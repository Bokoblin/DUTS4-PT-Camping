using PT_Camping.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PT_Camping
{
    /// <summary>
    /// The ConnectionUserControl is a UserControl handling the application's authentication at launch.
    /// Home can't be accessed if the user is not authenticated.
    /// 
    /// </summary>
    /// Authors : Alexandre, Arthur
    /// Since : 07/02/17
    public partial class ConnectionUserControl : UserControl
    {
        private AppWindow mWindow;


        public ConnectionUserControl(AppWindow window)
        {
            InitializeComponent();
            mWindow = window;
            handleResize();
            errorLabel.Visible = false;
        }

        private void tryToConnect()
        {
            String passwordEntered = this.passwordTextBox.Text;
            mWindow.userLoged.Login = this.userTextBox.Text;
            mWindow.userLoged.HashedPassword = LoginTools.sha256_hash(passwordEntered);
            if (mWindow.userLoged.checkConnection())
            {
                mWindow.login();
            }
            else
            {
                errorLabel.Visible = true;
                this.passwordTextBox.Text = "";
            }
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            tryToConnect();
        }

        internal void handleResize()
        {
            Size = mWindow.Size;
            appBar.Size = new Size(mWindow.Size.Width, appBar.Size.Height);
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tryToConnect();
            }
        }

        private void userTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tryToConnect();
            }
        }
    }
}
