using System;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Views.UserControls;

namespace PT_Camping.Views.Forms
{
    /// <summary>
    /// The windows form Window is the application's window.
    /// It handles UserControls which display the different screens of the app.
    /// 
    /// </summary>
    /// Authors : Alexandre, Arthur
    /// Since : 06/02/17
    public partial class AppWindow : Form
    {
        private ConnectionUserControl _connectionUserControl;
        private HomeUserControl _homeUserControl;

        public AppWindow()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _connectionUserControl = new ConnectionUserControl(this);
            WindowPanel.Controls.Add(_connectionUserControl);
        }

        internal void Login()
        {
            _homeUserControl = new HomeUserControl(this);
            WindowPanel.Controls.Add(_homeUserControl);
            WindowPanel.Controls.Remove(_connectionUserControl);
        }
        
        internal void Logout()
        {
            LoginTools.Login = "";
            LoginTools.HashedPassword = "";
            _connectionUserControl = new ConnectionUserControl(this);
            WindowPanel.Controls.Add(_connectionUserControl);
        }
        
        private void Window_Resize(object sender, EventArgs e)
        {
            WindowPanel.Size = Size;
            _connectionUserControl?.HandleResize();
            _homeUserControl?.HandleResize();
        }
    }
}
