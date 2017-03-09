using System;
using System.Drawing;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Views.Forms;

namespace PT_Camping.Views.UserControls
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
        private readonly AppWindow _window;


        public ConnectionUserControl(AppWindow window)
        {
            InitializeComponent();
            _window = window;
            HandleResize();
            errorLabel.Visible = false;
        }

        private void TryToConnect()
        {
            string passwordEntered = passwordTextBox.Text;
            _window.UserLoged.Login = userTextBox.Text;
            _window.UserLoged.HashedPassword = LoginTools.Sha256_hash(passwordEntered);
            try
            {
                if (_window.UserLoged.CheckConnection())
                {
                    if (_window.UserLoged.Employee.EstLicencie)
                        throw new UnauthorizedAccessException("Cet utilisateur n'a pas la permission d'accéder à l'application");
                    _window.Login();
                }
                else
                {
                    errorLabel.Visible = true;
                    passwordTextBox.Text = "";
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
            Size = _window.Size;
            appBar.Size = new Size(_window.Size.Width, appBar.Size.Height);
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
