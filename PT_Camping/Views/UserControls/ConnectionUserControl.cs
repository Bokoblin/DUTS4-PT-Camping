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
        private readonly AppWindow _appWindow;


        public ConnectionUserControl(AppWindow window)
        {
            InitializeComponent();
            _appWindow = window;
            HandleResize();
            errorLabel.Visible = false;
        }

        private void TryToConnect()
        {
            string passwordEntered = passwordTextBox.Text;
            LoginTools.Login = userTextBox.Text;
            LoginTools.HashedPassword = LoginTools.Sha256_hash(passwordEntered);
            try
            {
                if (LoginTools.CheckConnection())
                {
                    if (LoginTools.Employee.EstLicencie)
                        throw new UnauthorizedAccessException("Cet utilisateur n'a pas la permission d'accéder à l'application");
                    _appWindow.Login();
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
            if (userTextBox.Text != "" && passwordTextBox.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                TryToConnect();
            }
            else
            {
                errorLabel.Visible = true;
                passwordTextBox.Text = "";
            }
        }

        internal void HandleResize()
        {
            Size = _appWindow.Size;
            appBar.Size = new Size(_appWindow.Size.Width, appBar.Size.Height);
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter
                && userTextBox.Text != "" && passwordTextBox.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                TryToConnect();
            }
            else
                errorLabel.Visible = false;
        }

        private void UserTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter 
                && userTextBox.Text != "" && passwordTextBox.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                TryToConnect();
            }
            else
                errorLabel.Visible = false;
        }


        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
            showPasswordCheckBox.Text = showPasswordCheckBox.Checked ? "Masquer" : "Afficher";
        }


        private void ConnectionUserControl_Paint(object sender, PaintEventArgs e)
        {
            var buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle newRectangle = panel1.ClientRectangle;
            newRectangle.Inflate(76,78);
            buttonPath.AddEllipse(newRectangle);
            panel1.Region = new Region(buttonPath);
        }
    }
}
