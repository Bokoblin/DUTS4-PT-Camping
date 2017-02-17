using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PT_Camping.Model;


namespace PT_Camping
{
    /// <summary>
    /// The IssuesUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's issues.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
    public partial class IssuesUserControl : ManagementUserControl
    {
        public IssuesUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = "Gestion des incidents";
            db = new DataBase();

            issuesListView.View = View.Details;
            issuesListView.Columns.Add("Description", -2);
            issuesListView.Columns.Add("Date", -2);

            fillIssuesListView();
            handleResize();
        }

        public void fillIssuesListView()
        {
            foreach (var incident in db.Incident)
            {
                string description_incident = incident.Description_Incident;
                string date_incident = incident.Date_Incident.ToShortDateString();

                var item = new ListViewItem(new[] { description_incident, date_incident });
                issuesListView.Items.Add(item);
            }
        }

        internal new void handleResize()
        {
            base.handleResize();

            issuesListView.Size = new Size(
                Convert.ToInt32(mHomeUserControl.Size.Width * 0.3),
                Convert.ToInt32(issuesListView.Size.Height)
                );
        }

    }
}
