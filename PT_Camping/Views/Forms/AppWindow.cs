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
        private ConnectionUserControl _connectionUc;
        private HomeUserControl _homeUc;


        public AppWindow()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _connectionUc = new ConnectionUserControl(this);
            WindowPanel.Controls.Add(_connectionUc);
            UserLoged = new LoginTools();
        }

        internal void Login()
        {
            _homeUc = new HomeUserControl(this);
            WindowPanel.Controls.Add(_homeUc);
            WindowPanel.Controls.Remove(_connectionUc);
        }


        internal void Logout()
        {
            UserLoged.Login = "";
            UserLoged.HashedPassword = "";
            _connectionUc = new ConnectionUserControl(this);
            WindowPanel.Controls.Add(_connectionUc);
        }


        private void Window_Resize(object sender, EventArgs e)
        {
            WindowPanel.Size = Size;
            _connectionUc?.HandleResize();
            _homeUc?.HandleResize();
        }


        /// <summary>
        /// Properties (Getters & Setters)
        /// </summary>

        public Panel WindowPanel { get; set; }

        public LoginTools UserLoged { get; set; }
    }
}
