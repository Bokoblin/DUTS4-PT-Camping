using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Camping.Model;
using System.Security.Cryptography;

namespace PT_Camping
{
    /// <summary>
    /// The windows form Window is the application's window.
    /// It handles UserControls which display the different screens of the app.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 06/08/17
    /// </summary>
    public partial class AppWindow : Form
    {
        private ConnectionUserControl mConnectionUserControl;
        private HomeUserControl mHomeUserControl;
        public String CurrentUser { get; set; }
        public String HashedPassword { get; set; }

        public AppWindow()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            mConnectionUserControl = new ConnectionUserControl(this);
            windowPanel.Controls.Add(mConnectionUserControl);
        }

        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                {
                    Sb.Append(b.ToString("x2"));
                }
            }

            return Sb.ToString();
        }

        public bool checkConnection()
        {
            DataBase db = new DataBase();
            return (db.Employe.Where(u => u.Login == CurrentUser && u.Password == HashedPassword).Count() >= 1);
        }

        internal void login()
        {
            mHomeUserControl = new HomeUserControl(this);
            windowPanel.Controls.Add(mHomeUserControl);
            windowPanel.Controls.Remove(mConnectionUserControl);
        }


        internal void logout()
        {
            CurrentUser = "";
            HashedPassword = "";
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
