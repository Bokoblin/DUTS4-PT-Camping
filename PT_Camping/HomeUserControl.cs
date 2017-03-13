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
            handleResize();
            Personne personLoged = Window.userLoged.Person;
            if (personLoged != null)
            {
                userNameLabel.Text = "Bonjour " + personLoged.Prenom_Personne + " " + personLoged.Nom_Personne;
            }
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            mWindow.logout();
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void clientsButton_Click(object sender, EventArgs e)
        {
            mClientsUC = new ClientsUserControl(this);
            mWindow.WindowPanel.Controls.Add(mClientsUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void issuesButton_Click(object sender, EventArgs e)
        {
            mIssuesUC = new IssuesUserControl(this);
            mWindow.WindowPanel.Controls.Add(mIssuesUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void employeesButton_Click(object sender, EventArgs e)
        {
            mEmployeesUC = new EmployeesUserControl(this);
            mWindow.WindowPanel.Controls.Add(mEmployeesUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void stocksButton_Click(object sender, EventArgs e)
        {
            mStocksUC = new StocksUserControl(this);
            mWindow.WindowPanel.Controls.Add(mStocksUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void providersButton_Click(object sender, EventArgs e)
        {
            mProvidersUC = new ProvidersUserControl(this);
            mWindow.WindowPanel.Controls.Add(mProvidersUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        private void statsButton_Click(object sender, EventArgs e)
        {
            mStatsUC = new StatsUserControl(this);
            mWindow.WindowPanel.Controls.Add(mStatsUC);
            mWindow.WindowPanel.Controls.Remove(this);
        }


        internal void handleResize()
        {
            Size = mWindow.Size;
            managementTab.Size = mWindow.Size;
            appBar.Size = new Size(mWindow.Size.Width, appBar.Size.Height);
            homeTabControl.ItemSize = new Size(mWindow.Size.Width / 2-30, homeTabControl.ItemSize.Height);
            if (mClientsUC != null)
                mClientsUC.HandleResize();
            if (mIssuesUC != null)
                mIssuesUC.handleResize();
            if (mEmployeesUC != null)
                mEmployeesUC.HandleResize();
            if (mStocksUC != null)
                mStocksUC.HandleResize();
            if (mProvidersUC != null)
                mProvidersUC.HandleResize();
            if (mStatsUC != null)
                mStatsUC.HandleResize();
        }


        private void homeTabControl_SelectedIndexChanged(object sender, EventArgs e)
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
