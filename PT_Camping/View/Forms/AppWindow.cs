using PT_Camping.Model;
using System;
using System.Windows.Forms;

namespace PT_Camping
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
        private ConnectionUserControl mConnectionUC;
        private HomeUserControl mHomeUC;

        public AppWindow()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            mConnectionUC = new ConnectionUserControl(this);
            windowPanel.Controls.Add(mConnectionUC);
            userLoged = new LoginTools();
        }

        internal void login()
        {
            mHomeUC = new HomeUserControl(this);
            windowPanel.Controls.Add(mHomeUC);
            windowPanel.Controls.Remove(mConnectionUC);
        }


        internal void logout()
        {
            userLoged.Login = "";
            userLoged.HashedPassword = "";
            mConnectionUC = new ConnectionUserControl(this);
            windowPanel.Controls.Add(mConnectionUC);
        }


        private void Window_Resize(object sender, EventArgs e)
        {
            windowPanel.Size = this.Size;
            if (mConnectionUC != null)
                mConnectionUC.handleResize();
            if (mHomeUC != null)
                mHomeUC.handleResize();
        }


        /// <summary>
        /// Properties (Getters & Setters)
        /// </summary>

        public Panel WindowPanel { get { return windowPanel; } set { windowPanel = value; } }
        public LoginTools userLoged { get; set; }
    }
}
