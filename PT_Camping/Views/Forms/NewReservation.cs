using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
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

            public string ClientFullName
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

            public string LocationName => Location.Nom_Emplacement;
        }

        public enum Mode
        {
            Add,
            Edit
        }

        private readonly DataBase _db;
        private readonly HomeUserControl _homeUserControl;
        private readonly Mode _mode;
        private readonly int _resToEditCode;
        private readonly bool _fromMap;

        public delegate void LocationSelectedDelegate(int locationId);

        public NewReservation(HomeUserControl homeUserControl, DataBase context, Mode mode = Mode.Add, int resCode = -1)
        {
            InitializeComponent();
            _homeUserControl = homeUserControl;
            _fromMap = false;
            _db = context ?? new DataBase();

            foreach (Client person in _db.Client)
            {
                reservationHolderComboBox.Items.Add(person.Personne.Nom_Personne + " " + person.Personne.Prenom_Personne);
                reservationHolderComboBox.AutoCompleteCustomSource.Add(person.Personne.Nom_Personne + " " + person.Personne.Prenom_Personne);
            }
            locationsListBox.DisplayMember = "LocationName";
            lodgersListBox.DisplayMember = "ClientFullName";
            _mode = mode;
            Text = Resources.add_a_reservation;

            _resToEditCode = resCode;
            if (_mode == Mode.Edit)
            {
                reservationHolderComboBox.Enabled = false;
                addReservationButton.Text = Resources.edit;
                Text = Resources.edit_a_reservation;
                Reservation reservation = _db.Reservation.FirstOrDefault(a => a.Code_Reservation == resCode);
                if (reservation != null)
                {
                    beginDateTimePicker.Value = reservation.Date_Debut;
                    endDateTimePicker.Value = reservation.Date_Fin;
                    PayedCheckBox.Checked = reservation.Est_Paye;
                }
                foreach (Emplacement location in _db.Loge.Where(a => a.Code_Reservation == resCode).Select(a => a.Emplacement).Distinct())
                {
                    LocationItem locationItem = new LocationItem
                    {
                        Lodgers = new HashSet<Lodger>(),
                        Location = location
                    };
                    locationsListBox.Items.Add(locationItem);
                    foreach (Personne lodger in _db.Loge.Where(a => a.Code_Emplacement == location.Code_Emplacement).Select(a => a.Personne).Distinct())
                    {
                        if (lodger.Client != null)
                        {
                            locationItem.Lodgers.Add(new Lodger
                            {
                                Client = lodger.Client
                            });
                        }
                    }
                }
            }
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public NewReservation(HomeUserControl homeUserControl, DataBase context, int codePerson, Mode mode = Mode.Add, int resCode = -1)
            : this(homeUserControl, context, mode, resCode)
        {
            Personne client = _db.Personne.Find(codePerson);
            if (client != null)
            {
                reservationHolderComboBox.Text = client.Nom_Personne + Resources.one_space + client.Prenom_Personne;
            }
        }

        public NewReservation(HomeUserControl homeUserControl, DataBase context, Emplacement emplacement, Mode mode = Mode.Add, int resCode = -1) :
            this(homeUserControl, context, mode, resCode)
        {
            _fromMap = true;
            locationsListBox.Items.Add(new LocationItem
            {
                Location = _db.Emplacement.First(a => a.Code_Emplacement == emplacement.Code_Emplacement),
                Lodgers = new HashSet<Lodger>()
            });
        }

        private List<Personne> GetAllLodgersAdded()
        {
            var lodgers = new List<Personne>();
            foreach (LocationItem locationItem in locationsListBox.Items)
            {
                lodgers.AddRange(locationItem.Lodgers.Select(lodger => lodger.Client.Personne));
            }
            return lodgers;
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            LocationSelectedDelegate caller = LocationPicked;
            _homeUserControl.StartLocationsFromClients();
            _homeUserControl.MapUserControl.StartPickLocation(caller, beginDateTimePicker.Value);
        }

        private void LocationPicked(int locationId)
        {
            if (_fromMap)
            {
                _homeUserControl.HomeTabControl.SelectTab(1);
            }
            else
            {
                _homeUserControl.StartClientsFromLocations();
            }
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

        private void DeleteLocationButton_Click(object sender, EventArgs e)
        {
            if (locationsListBox.SelectedItem != null)
            {
                locationsListBox.Items.Remove(locationsListBox.SelectedItem);
            }
        }

        private void AddLodgerButton_Click(object sender, EventArgs e)
        {
            string text = addLodgerComboBox.Text;
            Client client =
                _db.Client.FirstOrDefault(a => text.Equals(a.Personne.Nom_Personne + " " + a.Personne.Prenom_Personne));
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
            RefreshLodgers();
        }

        private void RemoveLodgerButton_Click(object sender, EventArgs e)
        {
            LocationItem locationItem = locationsListBox.SelectedItem as LocationItem;
            if (lodgersListBox.SelectedItem != null)
            {
                locationItem?.Lodgers.Remove((Lodger)lodgersListBox.SelectedItem);
            }
            RefreshLodgers();
        }

        private void AddReservationButton_Click(object sender, EventArgs e)
        {
            Reservation newReservation;
            DateTime beginDate = beginDateTimePicker.Value;
            DateTime endDate = endDateTimePicker.Value;
            string reservationHolderName = reservationHolderComboBox.Text;
            Client client = _db.Client.FirstOrDefault(
                a => reservationHolderName.Equals(a.Personne.Nom_Personne + " " + a.Personne.Prenom_Personne));

            if (client?.Personne == null)
            {
                MessageBox.Show(Resources.client_not_found);
                return;
            }

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
            foreach (LocationItem locationItem in locationsListBox.Items)
            {
                if (!locationItem.Lodgers.Any())
                {
                    string message = "L'emplacement %1$ ne contient aucun résident";
                    message = message.Replace("%1$", locationItem.LocationName);
                    MessageBox.Show(message);
                    return;
                }
                if (_db.Reservation.Where(a => ((beginDate >= a.Date_Debut && beginDate <= a.Date_Fin) ||
                                               (endDate >= a.Date_Debut && endDate <= a.Date_Fin)) && a.Code_Reservation != _resToEditCode)
                    .SelectMany(a => a.Loge)
                    .Any(a => a.Code_Emplacement == locationItem.Location.Code_Emplacement))
                {
                    string message = "L'emplacement %1$ n'est pas libre pendant la période sélectionnée";
                    message = message.Replace("%1$", locationItem.LocationName);
                    MessageBox.Show(message);
                    return;
                }
            }

            if (_mode == Mode.Add)
            {
                newReservation = new Reservation
                {
                    Personne = client.Personne
                };
                _db.Reservation.Add(newReservation);
                newReservation.Facture = new Facture { Date_Emission = DateTime.Now, Montant = 0 };
            }
            else
            {
                newReservation = _db.Reservation.FirstOrDefault(a => a.Code_Reservation == _resToEditCode);
                if (newReservation != null)
                {
                    foreach (Loge loge in _db.Loge.Where(a => a.Code_Reservation == _resToEditCode))
                    {
                        _db.Loge.Remove(loge);
                    }
                }
            }

            if (newReservation != null)
            {
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
                newReservation.Date_Debut = beginDate;
                newReservation.Date_Fin = endDate;
                newReservation.Est_Paye = PayedCheckBox.Checked;

                try
                {
                    _db.SaveChanges();
                    _homeUserControl.MapUserControl.RefreshLocations();
                    MessageBox.Show(_mode == Mode.Add
                        ? Resources.reservation_done
                        : Resources.reservation_edited);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(Resources.db_save_error + Resources.new_line + ex.InnerException?.InnerException);
                }
            }
        }

        private void RefreshLodgers()
        {
            LocationItem locationItem = locationsListBox.SelectedItem as LocationItem;
            if (locationItem != null)
            {
                lodgersListBox.DataSource = locationItem.Lodgers.ToList();
            }
            addLodgerComboBox.Items.Clear();
            addLodgerComboBox.AutoCompleteCustomSource.Clear();
            var allLodgers = GetAllLodgersAdded();
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

        private void LocationsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshLodgers();
        }
    }
}
