using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Properties;
using PT_Camping.Views.UserControls;

namespace PT_Camping.Views.Forms
{
    public partial class NewReservation : Form
    {
        internal class Lodger
        {
            public Client Client;

            public String ClientFullName
            {
                get
                {
                    if (Client?.Personne != null) return Client.Personne.Nom_Personne + " " + Client.Personne.Prenom_Personne;
                    return "";
                }
            }
        }

        internal class LocationItem
        {
            public Emplacement Location;
            public HashSet<Lodger> Lodgers;

            public String LocationName
            {
                get { return Location.Nom_Emplacement; }
            }
        }

        private DataBase _db;
        private HomeUserControl _homeUserControl;

        public delegate void LocationSelectedDelegate(int locationId);

        public NewReservation(HomeUserControl homeUserControl)
        {
            InitializeComponent();
            _homeUserControl = homeUserControl;
            _db = new DataBase();
            foreach (Client person in _db.Client)
            {
                reservationHolderComboBox.Items.Add(person.Personne.Nom_Personne + " " + person.Personne.Prenom_Personne);
                reservationHolderComboBox.AutoCompleteCustomSource.Add(person.Personne.Nom_Personne + " " + person.Personne.Prenom_Personne);
            }
            locationsListBox.DisplayMember = "LocationName";
            lodgersListBox.DisplayMember = "ClientFullName";
        }

        private List<Personne> GetAllLodgersAdded()
        {
            List<Personne> lodgers = new List<Personne>();
            foreach (LocationItem locationItem in locationsListBox.Items)
            {
                foreach (Lodger lodger in locationItem.Lodgers)
                {
                    lodgers.Add(lodger.Client.Personne);
                }
            }
            return lodgers;
        }

        public NewReservation(HomeUserControl homeUserControl, int codePerson): this(homeUserControl)
        {
            Personne client = _db.Personne.Find(codePerson);
            if (client != null)
            {
                reservationHolderComboBox.SelectedText = client.Nom_Personne + " " + client.Prenom_Personne;
            }
        }

        private void addLocationButton_Click(object sender, EventArgs e)
        {
            LocationSelectedDelegate caller = LocationPicked;
            _homeUserControl.Window.WindowPanel.Controls.Clear();
            _homeUserControl.Window.WindowPanel.Controls.Add(_homeUserControl);
            _homeUserControl.HomeTabControl.SelectTab(1);
            _homeUserControl.Window.BringToFront();
            _homeUserControl.MapUserControl.StartPickLocation(caller, beginDateTimePicker.Value);
        }

        private void LocationPicked(int locationId)
        {
            _homeUserControl.Window.WindowPanel.Controls.Clear();
            _homeUserControl.Window.WindowPanel.Controls.Add(new ClientsUserControl(_homeUserControl));
            BringToFront();
            Emplacement locationToAdd = _db.Emplacement.First(a => a.Code_Emplacement == locationId);
            if (locationsListBox.Items.Cast<LocationItem>().Any(locationItem => locationItem.Location.Code_Emplacement == locationToAdd.Code_Emplacement))
            {
                return;
            }
            locationsListBox.Items.Add(new LocationItem
            {
                Location = locationToAdd,
                Lodgers = new HashSet<Lodger>()
            });
        }

        private void deleteLocationButton_Click(object sender, EventArgs e)
        {
            if (locationsListBox.SelectedItem != null)
            {
                locationsListBox.Items.Remove(locationsListBox.SelectedItem);
            }
        }

        private void addLodgerButton_Click(object sender, EventArgs e)
        {
            String text = addLodgerComboBox.Text;
            Client client =
                _db.Client.First(a => text.Equals(a.Personne.Nom_Personne + " " + a.Personne.Prenom_Personne));
            if (client?.Personne == null)
            {
                MessageBox.Show(Resources.client_not_found);
                return;
            }
            if (GetAllLodgersAdded().Contains(client.Personne))
            {
                MessageBox.Show(Resources.client_already_added);
                return;
            }
            LocationItem locationItem = locationsListBox.SelectedItem as LocationItem;
            locationItem?.Lodgers.Add(new Lodger
            {
                Client = client
            });
            refreshLodgers();
        }

        private void removeLodgerButton_Click(object sender, EventArgs e)
        {
            LocationItem locationItem = locationsListBox.SelectedItem as LocationItem;
            if (lodgersListBox.SelectedItem != null)
            {
                locationItem?.Lodgers.Remove((Lodger)lodgersListBox.SelectedItem);
            }
            refreshLodgers();
        }

        private void addReservationButton_Click(object sender, EventArgs e)
        {
            String reservationHolderName = reservationHolderComboBox.Text;
            Client client =
                _db.Client.First(a => reservationHolderName.Equals(a.Personne.Nom_Personne + " " + a.Personne.Prenom_Personne));
            if (client?.Personne == null)
            {
                MessageBox.Show(Resources.client_not_found);
                return;
            }
            DateTime beginDate = beginDateTimePicker.Value;
            DateTime endDate = endDateTimePicker.Value;
            if (endDate < beginDate)
            {
                MessageBox.Show(Resources.beginDate_superior_endDate);
                return;
            }
            if (locationsListBox.Items.Count == 0)
            {
                MessageBox.Show(Resources.reservation_need_at_least_1_location);
                return;
            }
            foreach (LocationItem locationItem  in locationsListBox.Items)
            {
                if (!locationItem.Lodgers.Any())
                {
                    MessageBox.Show("L'emplacement " + locationItem.LocationName + " ne contient aucun résident");
                    return;
                }
                if (_db.Reservation.Where(a => (beginDate >= a.Date_Debut && beginDate <= a.Date_Fin) ||
                                               (endDate >= a.Date_Debut && endDate <= a.Date_Fin))
                    .SelectMany(a => a.Loge)
                    .Any(a => a.Code_Emplacement == locationItem.Location.Code_Emplacement))
                {
                    MessageBox.Show("L'emplacement " + locationItem.LocationName +
                                    " n'est pas libre pendant la période sélectionnée");
                    return;
                }
            }
            Reservation newReservation = new Reservation
            {
                Date_Debut = beginDate,
                Date_Fin = endDate,
                Est_Paye = false,
                Personne = client.Personne
            };
            _db.Reservation.Add(newReservation);
            newReservation.Facture.Add(new Facture
            {
                Montant = 0,
                Date_Emission = DateTime.Now
            });
            foreach (LocationItem locationItem in locationsListBox.Items)
            {
                foreach (Lodger lodger in locationItem.Lodgers)
                {
                    Loge loge = new Loge
                    {
                        Emplacement = locationItem.Location,
                        Personne = lodger.Client.Personne,
                        Reservation = newReservation
                    };
                    newReservation.Loge.Add(loge);
                }
            }
            try
            {
                _db.SaveChanges();
                MessageBox.Show(Resources.reservation_done);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(Resources.db_save_error + "\n" + ex.InnerException?.InnerException?.ToString());
            }
        }

        private void refreshLodgers()
        {
            LocationItem locationItem = locationsListBox.SelectedItem as LocationItem;
            if (locationItem != null)
            {
                lodgersListBox.DataSource = locationItem.Lodgers.ToList();
            }
            addLodgerComboBox.Items.Clear();
            addLodgerComboBox.AutoCompleteCustomSource.Clear();
            List<Personne> allLodgers = GetAllLodgersAdded();
            foreach (Client client in _db.Client)
            {
                if (!allLodgers.Contains(client.Personne))
                {
                    addLodgerComboBox.Items.Add(client.Personne.Nom_Personne + " " + client.Personne.Prenom_Personne);
                    addLodgerComboBox.AutoCompleteCustomSource.Add(client.Personne.Nom_Personne + " " + client.Personne.Prenom_Personne);
                }
            }
            addLodgerComboBox.Refresh();
        }

        private void locationsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            refreshLodgers();
        }
    }
}
