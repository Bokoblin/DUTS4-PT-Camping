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
            HandleResize();
            errorLabel.Visible = false;
        }

        private void TryToConnect()
        {
            String passwordEntered = this.passwordTextBox.Text;
            mWindow.UserLoged.Login = this.userTextBox.Text;
            mWindow.UserLoged.HashedPassword = LoginTools.Sha256_hash(passwordEntered);
            try
            {
                if (mWindow.UserLoged.CheckConnection())
                {
                    if (mWindow.UserLoged.Employee.EstLicencie)
                        throw new UnauthorizedAccessException("Cet utilisateur n'a pas la permission d'accéder à l'application");
                    else
                        mWindow.Login();
                }
                else
                {
                    errorLabel.Visible = true;
                    this.passwordTextBox.Text = "";
                }
            }
            catch (UnauthorizedAccessException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            TryToConnect();
        }

        internal void HandleResize()
        {
            Size = mWindow.Size;
            appBar.Size = new Size(mWindow.Size.Width, appBar.Size.Height);
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor.Current = Cursors.WaitCursor;
                TryToConnect();
            }
        }

        private void UserTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor.Current = Cursors.WaitCursor;
                TryToConnect();
            }
        }
    }
}
