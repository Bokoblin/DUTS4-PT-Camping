using PT_Camping.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PT_Camping
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
        private AppWindow mWindow;
        private ClientsUserControl mClientsUC;
        private IssuesUserControl mIssuesUC;
        private EmployeesUserControl mEmployeesUC;
        private StocksUserControl mStocksUC;
        private ProvidersUserControl mProvidersUC;
        private StatsUserControl mStatsUC;
        private MapUserControl mMapUC;


        public HomeUserControl(AppWindow window)
        {
            InitializeComponent();
            mWindow = window;
            HandleResize();
            Employe employeeLoged = Window.UserLoged.Employee;
            if (employeeLoged != null)
            {
                userNameLabel.Text = "Bonjour " + employeeLoged.Personne.Prenom_Personne + " " + employeeLoged.Personne.Nom_Personne;
            }
        }


        public void StartLocationsFromStats(int code)
        {
            //TODO : open map with location {code} selected
        }


        public void StartProductsFromStats(int code)
        {
            //TODO : open products with {code} selected
        }


        public void StartClientsFromStats(int code)
        {
            //TODO : open clients with {code} selected
        }


        public void StartIssuesFromStats(int issueCode)
        {
            Cursor.Current = Cursors.WaitCursor;
            mIssuesUC = new IssuesUserControl(this, issueCode);
            mWindow.WindowPanel.Controls.Add(mIssuesUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mWindow.Logout();
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void ClientsButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mClientsUC = new ClientsUserControl(this);
            mWindow.WindowPanel.Controls.Add(mClientsUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void IssuesButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mIssuesUC = new IssuesUserControl(this);
            mWindow.WindowPanel.Controls.Add(mIssuesUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mEmployeesUC = new EmployeesUserControl(this);
            mWindow.WindowPanel.Controls.Add(mEmployeesUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void StocksButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mStocksUC = new StocksUserControl(this);
            mWindow.WindowPanel.Controls.Add(mStocksUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void ProvidersButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mProvidersUC = new ProvidersUserControl(this);
            mWindow.WindowPanel.Controls.Add(mProvidersUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void StatsButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mStatsUC = new StatsUserControl(this);
            mWindow.WindowPanel.Controls.Add(mStatsUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        internal void HandleResize()
        {
            Size = mWindow.Size;
            managementTab.Size = mWindow.Size;
            appBar.Size = new Size(mWindow.Size.Width, appBar.Size.Height);
            homeTabControl.ItemSize = new Size(mWindow.Size.Width / 2-30, homeTabControl.ItemSize.Height);
            if (mClientsUC != null)
                mClientsUC.HandleResize();
            if (mIssuesUC != null)
                mIssuesUC.HandleResize();
            if (mEmployeesUC != null)
                mEmployeesUC.HandleResize();
            if (mStocksUC != null)
                mStocksUC.HandleResize();
            if (mProvidersUC != null)
                mProvidersUC.HandleResize();
            if (mStatsUC != null)
                mStatsUC.HandleResize();
        }


        private void HomeTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    // Do nothing here
                    break;
                case 1:
                    if (mMapUC == null)
                    {
                        mMapUC = new MapUserControl(this);
                        mapTab.Controls.Add(mMapUC);
                    }
                    break;
            }
        }


        /// <summary>
        /// Properties (Getters & Setters)
        /// </summary>

        public AppWindow Window { get { return mWindow; } set { mWindow = value; } }
    }
}
