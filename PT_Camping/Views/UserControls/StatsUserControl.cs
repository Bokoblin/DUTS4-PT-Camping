using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Properties;

namespace PT_Camping.Views.UserControls
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
        private int _currentYear;
        public StatsUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = Resources.stats_management;
            Db = new DataBase();

            UpdateListViews();
            HandleResize();
            yearPicker.MinDate = DateTime.Now.AddYears(-10);
            yearPicker.MaxDate = DateTime.Now.Date;
            yearPicker.Enabled = true;
        }


        private void UpdateListViews()
        {
            mostAskedlocationsListView.Items.Clear();
            mostAskedProductsListView.Items.Clear();
            mostCommonIssueslistView.Items.Clear();
            bestClientsListView.Items.Clear();

            _currentYear = yearPicker.Value.Year;

            UpdateLocationsListView();
            UpdateProductsListView();
            UpdateIssueslistView();
            UpdateClientsListView();
        }


        private void UpdateLocationsListView()
        {
            mostAskedlocationsListView.View = View.Details;
            mostAskedlocationsListView.Columns.Add("#");
            mostAskedlocationsListView.Columns.Add("Nom de l'emplacement");
            mostAskedlocationsListView.Columns.Add("Type d'emplacement");
            mostAskedlocationsListView.Columns.Add("Réservations");

            var statsClients = Db.Emplacement.ToDictionary(
                location => location.Code_Emplacement, 
                location => Db.Reservation.Count(
                    res => res.Code_Personne == location.Code_Emplacement 
                    && (res.Date_Debut.Year == _currentYear || res.Date_Debut.Year == _currentYear)));

            foreach (Emplacement location in Db.Emplacement)
            {
                string name = location.Nom_Emplacement;
                string type = location.Type_Emplacement.Libelle_Type;
                string nbReservations = statsClients[location.Code_Emplacement].ToString();

                var item = new ListViewItem(new[] { "", name, type, nbReservations })
                {
                    Name = location.Code_Emplacement.ToString()
                };
                mostAskedlocationsListView.Items.Add(item);
            }

            //=== Sorting by incident number

            var orderedList = mostAskedlocationsListView.Items.Cast<ListViewItem>()
                .Select(x => x).OrderByDescending(x => x.SubItems[2].Text).Take(10).ToList();
            mostAskedlocationsListView.Items.Clear();
            mostAskedlocationsListView.Items.AddRange(orderedList.ToArray());

            var cpt = 1;
            foreach (ListViewItem item in mostAskedlocationsListView.Items)
            {
                item.SubItems[0].Text = cpt.ToString();
                cpt++;
            }
        }


        private void UpdateProductsListView()
        {
            mostAskedProductsListView.View = View.Details;
            mostAskedProductsListView.Columns.Add("#");
            mostAskedProductsListView.Columns.Add("Nom du produit");
            mostAskedProductsListView.Columns.Add("Quantité vendue");

            var statsItem = new Dictionary<int, int>();

            foreach (var product in Db.Produit)
            {
                var soldPerProduct = Db.A_vendu.Where(
                        av => av.Code_Produit == product.Code_Produit
                        && av.Date_Vente.Year == _currentYear).ToList();

                int count = 0;
                soldPerProduct.ForEach(s => {
                    count += s.Quantite_Produit;
                });

                statsItem.Add(product.Code_Produit, count);
            }

            foreach (var product in Db.Produit)
            {
                var item = new ListViewItem(new[] { "", product.Libelle_Produit, statsItem[product.Code_Produit].ToString() })
                {
                    Name = product.Code_Produit.ToString()
                };
                mostAskedProductsListView.Items.Add(item);
            }

            //=== Sorting by number of sold products

            var orderedList = mostAskedProductsListView.Items.Cast<ListViewItem>()
                .Select(x => x).OrderByDescending(x => x.SubItems[2].Text).Take(10).ToList();
            mostAskedProductsListView.Items.Clear();
            mostAskedProductsListView.Items.AddRange(orderedList.ToArray());

            int cpt = 1;
            foreach (ListViewItem item in mostAskedProductsListView.Items)
            {
                item.SubItems[0].Text = cpt.ToString();
                cpt++;
            }
        }


        private void UpdateIssueslistView()
        {
            mostCommonIssueslistView.View = View.Details;
            mostCommonIssueslistView.Columns.Add("#");
            mostCommonIssueslistView.Columns.Add("Type d'incident");
            mostCommonIssueslistView.Columns.Add("Incidents associés");

            var statsIssues = Db.Type_Incident.ToDictionary(
                issueType => issueType.Code_Type,
                issueType => Db.Incident.Count(
                    it => it.Code_Type == issueType.Code_Type
                    && (it.Date_Incident.Year == _currentYear || it.Date_Resolution.Value.Year == _currentYear))
                    );

            foreach (Type_Incident issueType in Db.Type_Incident)
            {
                var item = new ListViewItem(new[] { "", issueType.Type_Incident1, statsIssues[issueType.Code_Type].ToString() })
                {
                    Name = issueType.Code_Type.ToString()
                };
                mostCommonIssueslistView.Items.Add(item);
            }

            //=== Sorting by incident number

            var orderedList = mostCommonIssueslistView.Items.Cast<ListViewItem>()
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
            bestClientsListView.View = View.Details;
            bestClientsListView.Columns.Add("#");
            bestClientsListView.Columns.Add("Nom");
            bestClientsListView.Columns.Add("Prénom");
            bestClientsListView.Columns.Add("Réservations");

            var statsClients = Db.Client.ToDictionary(
                client => client.Code_Personne,
                client => Db.Reservation.Count(
                    res => res.Code_Personne == client.Code_Personne
                    && (res.Date_Debut.Year == _currentYear || res.Date_Debut.Year == _currentYear))
                    );

            foreach (Client client in Db.Client)
            {
                string surname = client.Personne.Nom_Personne.ToUpper();
                string name = client.Personne.Prenom_Personne;
                string nbReservations = statsClients[client.Code_Personne].ToString();

                var item = new ListViewItem(new[] { "", surname, name, nbReservations })
                {
                    Name = client.Code_Personne.ToString()
                };
                bestClientsListView.Items.Add(item);
            }

            //=== Sorting by incident number

            var orderedList = bestClientsListView.Items.Cast<ListViewItem>()
                .Select(x => x).OrderByDescending(x => x.SubItems[3].Text).Take(10).ToList();
            bestClientsListView.Items.Clear();
            bestClientsListView.Items.AddRange(orderedList.ToArray());

            int cpt = 1;
            foreach (ListViewItem item in bestClientsListView.Items)
            {
                item.SubItems[0].Text = cpt.ToString();
                cpt++;
            }
        }


        private void MostAskedlocationsListView_Resize(object sender, EventArgs e)
        {

            if (mostAskedlocationsListView.Columns.Count != 0)
            {
                mostAskedlocationsListView.Columns[0].Width = 30;
                mostAskedlocationsListView.Columns[1].Width = mostAskedlocationsListView.Width / 3 - 10;
                mostAskedlocationsListView.Columns[2].Width = mostAskedlocationsListView.Width / 3 - 10;
                mostAskedlocationsListView.Columns[3].Width = mostAskedlocationsListView.Width / 3 - 10;
            }
        }


        private void MostAskedProductsListView_Resize(object sender, EventArgs e)
        {
            if (mostAskedProductsListView.Columns.Count != 0)
            {
                mostAskedProductsListView.Columns[0].Width = 30;
                mostAskedProductsListView.Columns[1].Width = mostAskedProductsListView.Width / 2 - 15;
                mostAskedProductsListView.Columns[2].Width = mostAskedProductsListView.Width / 2 - 15;
            }
        }


        private void MostCommonIssueslistView_Resize(object sender, EventArgs e)
        {
            if (mostCommonIssueslistView.Columns.Count != 0)
            {
                mostCommonIssueslistView.Columns[0].Width = 30;
                mostCommonIssueslistView.Columns[1].Width = mostCommonIssueslistView.Width / 2 - 15;
                mostCommonIssueslistView.Columns[2].Width = mostCommonIssueslistView.Width / 2 - 15;
            }
        }


        private void BestClientsListView_Resize(object sender, EventArgs e)
        {
            if (bestClientsListView.Columns.Count != 0)
            {
                bestClientsListView.Columns[0].Width = 30;
                bestClientsListView.Columns[1].Width = bestClientsListView.Width / 3 - 10;
                bestClientsListView.Columns[2].Width = bestClientsListView.Width / 3 - 10;
                bestClientsListView.Columns[3].Width = bestClientsListView.Width / 3 - 10;
            }
        }


        private void MostAskedLocationsListView_DoubleClick(object sender, EventArgs e)
        {
            if (mostAskedlocationsListView.SelectedItems.Count > 0)
            {
                int code = int.Parse(mostAskedlocationsListView.SelectedItems[0].Name);
                HomeUserControl.Window.WindowPanel.Controls.Remove(this);
                HomeUserControl.StartLocationsFromStats(code);
            }
        }


        private void MostAskedProductsListView_DoubleClick(object sender, EventArgs e)
        {
            if (mostAskedProductsListView.SelectedItems.Count > 0)
            {
                var code = int.Parse(mostAskedProductsListView.SelectedItems[0].Name);
                code = Db.Produit.First(i => i.Code_Produit == code).Code_Produit;
                HomeUserControl.Window.WindowPanel.Controls.Remove(this);
                HomeUserControl.StartProductsFromStats(code);
            }
        }


        private void MostCommonIssuesListView_DoubleClick(object sender, EventArgs e)
        {
            if (mostCommonIssueslistView.SelectedItems.Count > 0)
            {
                if (mostCommonIssueslistView.SelectedItems[0].SubItems[2].Text != 0.ToString())
                {
                    int codeType = int.Parse(mostCommonIssueslistView.SelectedItems[0].Name);
                    int code = Db.Incident.First(i => i.Code_Type == codeType).Code_Incident;
                    HomeUserControl.Window.WindowPanel.Controls.Remove(this);
                    HomeUserControl.StartIssuesFromStats(code);
                }
                else
                    MessageBox.Show(Resources.no_issue_corresponding);

            }
        }


        private void BestClientsListView_DoubleClick(object sender, EventArgs e)
        {
            if (bestClientsListView.SelectedItems.Count > 0)
            {
                int code = int.Parse(bestClientsListView.SelectedItems[0].Name);
                code = Db.Client.First(i => i.Code_Personne == code).Code_Personne;
                HomeUserControl.Window.WindowPanel.Controls.Remove(this);
                HomeUserControl.StartClientsFromStats(code);
            }
        }


        private void YearPicker_ValueChanged(object sender, EventArgs e)
        {
            //Prevents twice launching updateListView() at startup
            if (yearPicker.Enabled)
            {
                Cursor.Current = Cursors.WaitCursor;
                tableLayoutPanel.Hide();

                UpdateListViews();

                Cursor.Current = Cursors.Default;
                tableLayoutPanel.Show();
            }
        }
    }
}