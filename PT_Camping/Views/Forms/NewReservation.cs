using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                get { return Client.Personne.Nom_Personne + " " + Client.Personne.Prenom_Personne; }
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
            foreach (Personne person in _db.Personne)
            {
                reservationHolderComboBox.Items.Add(person.Nom_Personne + " " + person.Prenom_Personne);
                reservationHolderComboBox.AutoCompleteCustomSource.Add(person.Nom_Personne + " " + person.Prenom_Personne);
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
            //TODO correct bug
            String text = addLodgerComboBox.SelectedText;
            Client client =
                _db.Client
                    .First();
            if (client == null)
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
            foreach (Personne person in _db.Personne)
            {
                if (!GetAllLodgersAdded().Contains(person))
                {
                    addLodgerComboBox.Items.Add(person.Nom_Personne + " " + person.Prenom_Personne);
                    addLodgerComboBox.AutoCompleteCustomSource.Add(person.Nom_Personne + " " + person.Prenom_Personne);
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
