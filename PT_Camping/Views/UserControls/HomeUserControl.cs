using System;
using System.Drawing;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Properties;
using PT_Camping.Views.Forms;

namespace PT_Camping.Views.UserControls
{
    /// <summary>
    /// The HomeUserControl is a UserControl handling the application's home screen.
    /// It allows access to a management process screen or the Map screen with a tab system.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
    public partial class HomeUserControl : UserControl
    {
        private ClientsUserControl _clientsUserControl;
        private IssuesUserControl _issuesUserControl;
        private EmployeesUserControl _employeesUserControl;
        private StocksUserControl _stocksUserControl;
        private ProvidersUserControl _providersUserControl;
        private StatsUserControl _statsUserControl;
        private MapUserControl _mapUserControl;


        public HomeUserControl(AppWindow window)
        {
            InitializeComponent();
            Window = window;
            HandleResize();
            Employe employeeLoged = Window.UserLoged.Employee;
            if (employeeLoged != null)
            {
                userNameLabel.Text = Resources.hello_user 
                    + employeeLoged.Personne.Prenom_Personne 
                    + Resources.one_space + employeeLoged.Personne.Nom_Personne;
            }
        }


        public void StartLocationsFromStats(int code)
        {
            //TODO : open map with location {code} selected
        }


        public void StartProductsFromStats(int productCode)
        {
            Cursor.Current = Cursors.WaitCursor;
            _stocksUserControl = new StocksUserControl(this, productCode);
            Window.WindowPanel.Controls.Add(_stocksUserControl);
            Window.WindowPanel.Controls.Remove(this);
        }


        public void StartClientsFromStats(int clientCode)
        {
            Cursor.Current = Cursors.WaitCursor;
            _clientsUserControl = new ClientsUserControl(this, clientCode);
            Window.WindowPanel.Controls.Add(_clientsUserControl);
            Window.WindowPanel.Controls.Remove(this);
        }


        public void StartIssuesFromStats(int issueCode)
        {
            Cursor.Current = Cursors.WaitCursor;
            _issuesUserControl = new IssuesUserControl(this, issueCode);
            Window.WindowPanel.Controls.Add(_issuesUserControl);
            Window.WindowPanel.Controls.Remove(this);
        }


        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Window.Logout();
            Window.WindowPanel.Controls.Remove(this);
        }


        private void ClientsButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _clientsUserControl = new ClientsUserControl(this);
            Window.WindowPanel.Controls.Add(_clientsUserControl);
            Window.WindowPanel.Controls.Remove(this);
        }


        private void IssuesButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _issuesUserControl = new IssuesUserControl(this);
            Window.WindowPanel.Controls.Add(_issuesUserControl);
            Window.WindowPanel.Controls.Remove(this);
        }


        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _employeesUserControl = new EmployeesUserControl(this);
            Window.WindowPanel.Controls.Add(_employeesUserControl);
            Window.WindowPanel.Controls.Remove(this);
        }


        private void StocksButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _stocksUserControl = new StocksUserControl(this);
            Window.WindowPanel.Controls.Add(_stocksUserControl);
            Window.WindowPanel.Controls.Remove(this);
        }


        private void ProvidersButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _providersUserControl = new ProvidersUserControl(this);
            Window.WindowPanel.Controls.Add(_providersUserControl);
            Window.WindowPanel.Controls.Remove(this);
        }


        private void StatsButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _statsUserControl = new StatsUserControl(this);
            Window.WindowPanel.Controls.Add(_statsUserControl);
            Window.WindowPanel.Controls.Remove(this);
        }


        internal void HandleResize()
        {
            Size = Window.Size;
            managementTab.Size = Window.Size;
            appBar.Size = new Size(Window.Size.Width, appBar.Size.Height);
            homeTabControl.ItemSize = new Size(Window.Size.Width / 2 - 30, 
                homeTabControl.ItemSize.Height);
            _clientsUserControl?.HandleResize();
            _issuesUserControl?.HandleResize();
            _employeesUserControl?.HandleResize();
            _stocksUserControl?.HandleResize();
            _providersUserControl?.HandleResize();
            _statsUserControl?.HandleResize();
        }


        private void HomeTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex == 1)
            {
                if (_mapUserControl == null)
                {
                    _mapUserControl = new MapUserControl(this);
                    mapTab.Controls.Add(_mapUserControl);
                }
            }
        }


        /// <summary>
        /// Properties (Getters & Setters)
        /// </summary>

        public AppWindow Window { get; set; }
    }
}