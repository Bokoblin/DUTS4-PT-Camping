using PT_Camping.Model;
using System;
using System.Windows.Forms;


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

            updateListViews();
            handleResize();
        }


        private void updateListViews()
        {
            updateLocationsListView();
            updateProductsListView();
            updateIssueslistView();
            updateClientsListView();
        }


        private void updateLocationsListView()
        {
            //TEMPORARY : ALL LOCATIONS DISPLAYING

            mostAskedlocationsListView.View = View.Details;
            mostAskedlocationsListView.Columns.Add("Nom de l'emplacement");

            foreach (Emplacement location in db.Emplacement)
            {
                var item = new ListViewItem(new[] { location.Nom_Emplacement });
                item.Name = location.Code_Emplacement.ToString();
                mostAskedlocationsListView.Items.Add(item);
            }
        }


        private void updateProductsListView()
        {
            //TEMPORARY : ALL PRODUCTS DISPLAYING

            mostAskedProductsListView.View = View.Details;
            mostAskedProductsListView.Columns.Add("Nom du produit");

            foreach (Produit product in db.Produit)
            {
                var item = new ListViewItem(new[] { product.Libelle_Produit });
                item.Name = product.Code_Produit.ToString();
                mostAskedProductsListView.Items.Add(item);
            }
        }


        private void updateIssueslistView()
        {
            //TEMPORARY : ALL ISSUES DISPLAYING  

            mostCommonIssueslistView.View = View.Details;
            mostCommonIssueslistView.Columns.Add("Type d'incident");

            foreach (Type_Incident issueType in db.Type_Incident)
            {
                var item = new ListViewItem(new[] { issueType.Type_Incident1 });
                item.Name = issueType.Code_Type.ToString();
                mostCommonIssueslistView.Items.Add(item);
            }
        }


        private void updateClientsListView()
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

                var item = new ListViewItem(new[] { surname, name, email });
                item.Name = client.Code_Personne.ToString();
                bestClientsListView.Items.Add(item);
            }
        }


        private void mostAskedlocationsListView_Resize(object sender, EventArgs e)
        {
            if (mostAskedlocationsListView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in mostAskedlocationsListView.Columns)
                    columnHeader.Width = mostAskedlocationsListView.Width / mostAskedlocationsListView.Columns.Count;
            }
        }


        private void mostAskedProductsListView_Resize(object sender, EventArgs e)
        {
            if (mostAskedProductsListView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in mostAskedProductsListView.Columns)
                    columnHeader.Width = mostAskedProductsListView.Width / mostAskedProductsListView.Columns.Count;
            }
        }


        private void mostCommonIssueslistView_Resize(object sender, EventArgs e)
        {
            if (mostCommonIssueslistView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in mostCommonIssueslistView.Columns)
                    columnHeader.Width = mostCommonIssueslistView.Width / mostCommonIssueslistView.Columns.Count;
            }
        }


        private void bestClientsListView_Resize(object sender, EventArgs e)
        {
            if (bestClientsListView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in bestClientsListView.Columns)
                    columnHeader.Width = bestClientsListView.Width / bestClientsListView.Columns.Count;
            }
        }
    }
}
