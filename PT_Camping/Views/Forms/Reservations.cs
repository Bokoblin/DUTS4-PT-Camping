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

        public Reservations(int codeClient)
        {
            InitializeComponent();
            _db = new DataBase();
            if (_db.Client.Any(c => c.Code_Personne == codeClient))
            {
                _codePerson = codeClient;
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
        }

        private void deleteReservationButton_Click(object sender, EventArgs e)
        {

        }

        private void factureButton_Click(object sender, EventArgs e)
        {

        }

        private void reservationsList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            locationsList.Items.Clear();
            lodgerList.Items.Clear();
            Reservation res = _db.Reservation.First(a => a.Code_Reservation == int.Parse(e.Item.SubItems[4].Text));
            foreach (Emplacement location in res.Loge.Select(a => a.Emplacement))
            {
                locationsList.Items.Add(location.Nom_Emplacement);
            }
        }

        private void newReservationButton_Click(object sender, EventArgs e)
        {
            new NewReservation(_codePerson).ShowDialog();
        }

        private void locationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservation res =
                _db.Reservation.First(
                    a => a.Code_Reservation == int.Parse((locationsList.SelectedItem as ListViewItem).SubItems[4].Text));
            Emplacement loc = _db.Emplacement.First(a => a.Nom_Emplacement == (string)(sender as ListBox).SelectedItem);
            lodgerList.Items.Clear();
            foreach (Personne lodger in _db.Loge.Where(a => a.Code_Reservation == res.Code_Reservation && a.Code_Emplacement == loc.Code_Emplacement).
                Select(a => a.Personne))
            {
                lodgerList.Items.Add(lodger.Nom_Personne + lodger.Prenom_Personne);
            }
        }
    }
}
