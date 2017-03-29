using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Properties;
using PT_Camping.Views.UserControls;

namespace PT_Camping.Views.Forms
{
    /// <summary>
    /// The Reservation is a Form that show all the 
    /// reservations for a specific client
    /// 
    /// </summary>
    /// Authors : Alexandre
    /// Since : 20/03/17
    /// 
    public partial class Reservations : Form
    {
        private DataBase _db;
        private int _codePerson;
        private HomeUserControl _homeUserControl;

        public Reservations(HomeUserControl homeUserControl, int codeClient)
        {
            InitializeComponent();
            _homeUserControl = homeUserControl;
            _db = new DataBase();
            if (_db.Client.Any(c => c.Code_Personne == codeClient))
            {
                Personne person = _db.Client.First(a => a.Code_Personne == codeClient).Personne;
                titleLabel.Text = Resources.reservationTitleLabel + person.Nom_Personne + Resources.one_space + person.Prenom_Personne;
                _codePerson = codeClient;
                RefreshReservations();
            }
        }

        private void RefreshReservations()
        {
            reservationsList.Items.Clear();
            foreach (Reservation res in _db.Reservation.Where(a => a.Code_Personne == _codePerson))
            {
                String[] itemArr = new string[5];
                itemArr[0] = res.Date_Debut.ToString(CultureInfo.InvariantCulture);
                itemArr[1] = res.Date_Fin.ToString(CultureInfo.InvariantCulture);
                itemArr[2] =
                    _db.Loge.Where(a => a.Code_Reservation == res.Code_Reservation)
                        .Select(a => a.Emplacement)
                        .Count().ToString();
                itemArr[3] = res.Est_Paye.ToString();
                itemArr[4] = res.Code_Reservation.ToString();
                ListViewItem item = new ListViewItem(itemArr);

                reservationsList.Items.Add(item);
            }
        }

        private void deleteReservationButton_Click(object sender, EventArgs e)
        {
            if (reservationsList.SelectedItems.Count > 0 && reservationsList.SelectedItems[0] != null)
            {
                int codeRes = int.Parse(reservationsList.SelectedItems[0].SubItems[4].Text);
                foreach (Loge loge in _db.Loge.Where(a => a.Code_Reservation == codeRes))
                {
                    _db.Loge.Remove(loge);
                }
                Reservation res = _db.Reservation.FirstOrDefault(a => a.Code_Reservation == codeRes);
                if (res != null)
                {
                    _db.Facture.Remove(res.Facture);
                    _db.Reservation.Remove(res);
                    _db.SaveChanges();
                }
                RefreshReservations();
            }
        }

        private void factureButton_Click(object sender, EventArgs e)
        {
            if (reservationsList.SelectedItems.Count > 0 && reservationsList.SelectedItems[0] != null)
            {
                int codeRes = int.Parse(reservationsList.SelectedItems[0].SubItems[4].Text);
                Reservation reservation = _db.Reservation.FirstOrDefault(a => a.Code_Reservation == codeRes);
                Client client = null;
                Facture facture = null;
                if (reservation != null)
                {
                    client = reservation.Personne.Client;
                    facture = reservation.Facture;
                }
                if (reservation != null && client != null && facture != null)
                {
                    //TODO Ecrire le code de generation de facture ici et modifier l'entité facture avec le prix
                    _db.SaveChanges();
                }
            }

        }

        private void reservationsList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            locationsList.Items.Clear();
            lodgerList.Items.Clear();
            int resId = -1;
            if (reservationsList.SelectedItems.Count > 0)
            {
                resId = int.Parse(e.Item.SubItems[4].Text);
            }
            Reservation res = _db.Reservation.FirstOrDefault(a => a.Code_Reservation == resId);
            if (res != null)
            {
                foreach (Emplacement location in res.Loge.Select(a => a.Emplacement).Distinct())
                {
                    locationsList.Items.Add(location.Nom_Emplacement);
                }
            }
        }

        private void newReservationButton_Click(object sender, EventArgs e)
        {
            new NewReservation(_homeUserControl, _db, _codePerson).Show();
        }

        private void locationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reservationsList.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = reservationsList.SelectedItems[0] as ListViewItem;
                if (listViewItem != null)
                {
                    int resId = int.Parse(listViewItem.SubItems[4].Text);
                    Reservation res =
                        _db.Reservation.FirstOrDefault(
                            a => a.Code_Reservation == resId);
                    ListBox listBox = sender as ListBox;
                    if (listBox?.SelectedItem != null)
                    {
                        String locationName = (string)listBox.SelectedItem;
                        Emplacement loc = _db.Emplacement.FirstOrDefault(a => a.Nom_Emplacement == locationName);
                        lodgerList.Items.Clear();
                        foreach (Personne lodger in _db.Loge.Where(a => a.Code_Reservation == res.Code_Reservation && a.Code_Emplacement == loc.Code_Emplacement).
                            Select(a => a.Personne))
                        {
                            lodgerList.Items.Add(lodger.Nom_Personne + " " + lodger.Prenom_Personne);
                        }
                    }
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = reservationsList.SelectedItems[0] as ListViewItem;
            if (listViewItem != null)
            {
                int resId = int.Parse(listViewItem.SubItems[4].Text);
                new NewReservation(_homeUserControl, _db, _codePerson, NewReservation.Mode.Edit, resId).Show();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshReservations();
        }
    }
}
