using PT_Camping.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;


namespace PT_Camping
{
    /// <summary>
    /// The StatsUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's statistics.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
    public partial class StatsUserControl : ManagementUserControl
    {
        public StatsUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = "Gestion des statistiques";
            db = new DataBase();

            UpdateListViews();
            HandleResize();
        }


        private void UpdateListViews()
        {
            UpdateLocationsListView();
            UpdateProductsListView();
            UpdateIssueslistView();
            UpdateClientsListView();
        }


        private void UpdateLocationsListView()
        {
            //TEMPORARY : ALL LOCATIONS DISPLAYING

            mostAskedlocationsListView.View = View.Details;
            mostAskedlocationsListView.Columns.Add("Nom de l'emplacement");

            foreach (Emplacement location in db.Emplacement)
            {
                var item = new ListViewItem(new[] { location.Nom_Emplacement })
                {
                    Name = location.Code_Emplacement.ToString()
                };
                mostAskedlocationsListView.Items.Add(item);
            }
        }


        private void UpdateProductsListView()
        {
            //TEMPORARY : ALL PRODUCTS DISPLAYING

            mostAskedProductsListView.View = View.Details;
            mostAskedProductsListView.Columns.Add("Nom du produit");

            foreach (Produit product in db.Produit)
            {
                var item = new ListViewItem(new[] { product.Libelle_Produit })
                {
                    Name = product.Code_Produit.ToString()
                };
                mostAskedProductsListView.Items.Add(item);
            }
        }


        private void UpdateIssueslistView()
        {
            mostCommonIssueslistView.View = View.Details;
            mostCommonIssueslistView.Columns.Add("#");
            mostCommonIssueslistView.Columns.Add("Type d'incident");
            mostCommonIssueslistView.Columns.Add("Nombre d'incidents associés");

            var statsIssues = new Dictionary<String, int>();

            foreach (Type_Incident issueType in db.Type_Incident)
            {
                statsIssues.Add(issueType.Type_Incident1, 
                    db.Incident.Where(it => it.Code_Type == issueType.Code_Type).Count());
            }

            foreach (Type_Incident issueType in db.Type_Incident)
            {
                var item = new ListViewItem(new[] { "", issueType.Type_Incident1, statsIssues[issueType.Type_Incident1].ToString() })
                {
                    Name = issueType.Code_Type.ToString()
                };
                mostCommonIssueslistView.Items.Add(item);
            }

            //=== Sorting by incident type

            var orderedList =  mostCommonIssueslistView.Items.Cast<ListViewItem>()
                .Select(x => x).OrderByDescending(x => x.SubItems[2].Text).Take(10).ToList();
            mostCommonIssueslistView.Items.Clear();
            mostCommonIssueslistView.Items.AddRange(orderedList.ToArray());

            int cpt = 1;
            foreach (ListViewItem item in mostCommonIssueslistView.Items)
            {
                item.SubItems[0].Text = cpt.ToString();
                cpt++;
            }
        }


        private void UpdateClientsListView()
        {
            //TEMPORARY : ALL CLIENTS DISPLAYING

            bestClientsListView.View = View.Details;
            bestClientsListView.Columns.Add("Nom du client");
            bestClientsListView.Columns.Add("Prénom du client");

            foreach (Client client in db.Client)
            {
                string surname = client.Personne.Nom_Personne.ToUpper();
                string name = client.Personne.Prenom_Personne;
                string email = client.Personne.Email;

                var item = new ListViewItem(new[] { surname, name, email })
                {
                    Name = client.Code_Personne.ToString()
                };
                bestClientsListView.Items.Add(item);
            }
        }


        private void MostAskedlocationsListView_Resize(object sender, EventArgs e)
        {
            if (mostAskedlocationsListView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in mostAskedlocationsListView.Columns)
                    columnHeader.Width = mostAskedlocationsListView.Width / mostAskedlocationsListView.Columns.Count;
            }
        }


        private void MostAskedProductsListView_Resize(object sender, EventArgs e)
        {
            if (mostAskedProductsListView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in mostAskedProductsListView.Columns)
                    columnHeader.Width = mostAskedProductsListView.Width / mostAskedProductsListView.Columns.Count;
            }
        }


        private void MostCommonIssueslistView_Resize(object sender, EventArgs e)
        {
            if (mostCommonIssueslistView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in mostCommonIssueslistView.Columns)
                    columnHeader.Width = mostCommonIssueslistView.Width / mostCommonIssueslistView.Columns.Count;
            }
            mostCommonIssueslistView.Columns[0].Width = 30;
            mostCommonIssueslistView.Columns[1].Width = mostCommonIssueslistView.Width / 2 - 15;
            mostCommonIssueslistView.Columns[2].Width = mostCommonIssueslistView.Width / 2 - 15;
        }


        private void BestClientsListView_Resize(object sender, EventArgs e)
        {
            if (bestClientsListView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in bestClientsListView.Columns)
                    columnHeader.Width = bestClientsListView.Width / bestClientsListView.Columns.Count;
            }
        }

        private void MostCommonIssueslistView_DoubleClick(object sender, EventArgs e)
        {
            if (mostCommonIssueslistView.SelectedItems.Count > 0)
            {
                int code = int.Parse(mostCommonIssueslistView.SelectedItems[0].Name);
                mHomeUC.Window.WindowPanel.Controls.Remove(this);
                mHomeUC.StartIssuesFromStats(code);
            }
        }
    }
}
