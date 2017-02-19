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
        private ConnectionUserControl mConnectionUserControl;
        private HomeUserControl mHomeUserControl;

        public AppWindow()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            mConnectionUserControl = new ConnectionUserControl(this);
            windowPanel.Controls.Add(mConnectionUserControl);
        }

        internal void login()
        {
            mHomeUserControl = new HomeUserControl(this);
            windowPanel.Controls.Add(mHomeUserControl);
            windowPanel.Controls.Remove(mConnectionUserControl);
        }


        internal void logout()
        {
            LoginTools.Login = "";
            LoginTools.HashedPassword = "";
            mConnectionUserControl = new ConnectionUserControl(this);
            windowPanel.Controls.Add(mConnectionUserControl);
        }


        private void Window_Resize(object sender, EventArgs e)
        {
            windowPanel.Size = this.Size;
            if (mConnectionUserControl != null)
                mConnectionUserControl.handleResize();
            if (mHomeUserControl != null)
                mHomeUserControl.handleResize();
        }


        /// <summary>
        /// Properties (Getters & Setters)
        /// </summary>

        public Panel WindowPanel { get { return windowPanel; } set { windowPanel = value; } }
    }
}
