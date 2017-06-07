using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private readonly List<Droit> _userRights;

        public HomeUserControl(AppWindow window)
        {
            InitializeComponent();
            Window = window;
            HandleResize();
            Employe employeeLoged = LoginTools.Employee;
            if (employeeLoged != null)
            {
                userNameButton.Text = Resources.hello_user 
                    + employeeLoged.Personne.Prenom_Personne 
                    + Resources.one_space + employeeLoged.Personne.Nom_Personne;
            }
            DataBase db = new DataBase();
            _userRights = db.Personne.First(
                    a => a.Code_Personne == LoginTools.Employee.Personne.Code_Personne).Droit.ToList();
            db.Dispose();

            InitPermissions();
        }

        public void InitPermissions()
        {
            DataBase db = new DataBase();
            var userRights = db.Personne.First(a => a.Code_Personne == LoginTools.Employee.Code_Personne).Droit.ToList();
            clientButton.Enabled = userRights.Any(d => d.Libelle_Droit == "readClients");
            issuesButton.Enabled = userRights.Any(d => d.Libelle_Droit == "readIssues");
            employeeButton.Enabled = userRights.Any(d => d.Libelle_Droit == "readEmployees");
            stocksButton.Enabled = userRights.Any(d => d.Libelle_Droit == "readStocks");
            providerButton.Enabled = userRights.Any(d => d.Libelle_Droit == "readProviders");
            statsButton.Enabled = userRights.Any(d => d.Libelle_Droit == "readStats");
            db.Dispose();
        }


        public void StartEmployeesFromTitleBar(UserControl sender)
        {
            Cursor.Current = Cursors.WaitCursor;
            _employeesUserControl = new EmployeesUserControl(this, LoginTools.Employee.Code_Personne);
            Window.WindowPanel.Controls.Add(_employeesUserControl);
            Window.WindowPanel.Controls.Remove(sender);
        }


        public void StartLocationsFromClients()
        {
            Cursor.Current = Cursors.WaitCursor;
            Window.WindowPanel.Controls.Add(this);
            HomeTabControl.SelectedIndex = 1;
            if (MapUserControl == null)
            {
                MapUserControl = new MapUserControl(this);
            }

            mapTab.Controls.Add(MapUserControl);
            MapUserControl?.HandleResize(managementTab.Size);
            Window.WindowPanel.Controls.Remove(_clientsUserControl);
            Window.BringToFront();
        }


        public void StartClientsFromLocations()
        {
            Cursor.Current = Cursors.WaitCursor;
            _clientsUserControl = new ClientsUserControl(this);
            Window.WindowPanel.Controls.Add(_clientsUserControl);
            HomeTabControl.SelectedIndex = 0;
            Window.WindowPanel.Controls.Remove(this);
        }

        public void StartLocationsFromStats(int locationCode)
        {
            Cursor.Current = Cursors.WaitCursor;
            Window.WindowPanel.Controls.Add(this);
            HomeTabControl.SelectedIndex = 1;
            if (MapUserControl == null)
            {
                MapUserControl = new MapUserControl(this, locationCode);
            }
            else
            {
                MapUserControl.SelectFromStats(locationCode);
            }
                
            mapTab.Controls.Add(MapUserControl);
            MapUserControl?.HandleResize(managementTab.Size);
            Window.WindowPanel.Controls.Remove(_statsUserControl);
        }
        
        public void StartProductsFromStats(int productCode)
        {
            Cursor.Current = Cursors.WaitCursor;
            _stocksUserControl = new StocksUserControl(this, productCode);
            Window.WindowPanel.Controls.Add(_stocksUserControl);
            Window.WindowPanel.Controls.Remove(_statsUserControl);
        }
        
        public void StartClientsFromStats(int clientCode)
        {
            Cursor.Current = Cursors.WaitCursor;
            _clientsUserControl = new ClientsUserControl(this, clientCode);
            Window.WindowPanel.Controls.Add(_clientsUserControl);
            Window.WindowPanel.Controls.Remove(_statsUserControl);
        }
        
        public void StartIssuesFromStats(int issueCode)
        {
            Cursor.Current = Cursors.WaitCursor;
            _issuesUserControl = new IssuesUserControl(this, issueCode);
            Window.WindowPanel.Controls.Add(_issuesUserControl);
            Window.WindowPanel.Controls.Remove(_statsUserControl);
        }
        
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Window.Logout();
            Window.WindowPanel.Controls.Remove(this);
        }
        
        private void UserNameButton_Click(object sender, EventArgs e)
        {
            if (_userRights.Any(d => d.Libelle_Droit == "readEmployees"))
            {
                StartEmployeesFromTitleBar(this);
            }
            else
            {
                MessageBox.Show(Resources.denied_access);
            }
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
            HomeTabControl.ItemSize = new Size(Window.Size.Width / 2 - 30, 
                HomeTabControl.ItemSize.Height);
            _clientsUserControl?.HandleResize();
            _issuesUserControl?.HandleResize();
            _employeesUserControl?.HandleResize();
            _stocksUserControl?.HandleResize();
            _providersUserControl?.HandleResize();
            _statsUserControl?.HandleResize();
            MapUserControl?.HandleResize(mapTab.Size);
        }
        
        private void HomeTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex == 1)
            {
                if (_userRights.Any(d => d.Libelle_Droit == "readMap"))
                {
                    if (MapUserControl == null)
                    {
                        MapUserControl = new MapUserControl(this);
                        mapTab.Controls.Add(MapUserControl);
                        MapUserControl?.HandleResize(managementTab.Size);
                    }
                }
                else
                {
                    MessageBox.Show(Resources.denied_access);
                    ((TabControl) sender).SelectedIndex = 0;
                }
                MapUserControl.ResetMode();
            }
        }
        

        /// <summary>
        /// Properties (Getters & Setters)
        /// </summary>

        public AppWindow Window { get; }

        public MapUserControl MapUserControl { get; private set; }

        public TabControl HomeTabControl { get; set; }
    }
}
