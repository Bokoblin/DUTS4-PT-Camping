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
                    itemArr[2] = _db.Loge.First(a => a.Code_Reservation == res.Code_Reservation);
                    itemArr[3] =
                        _db.Loge.Where(a => a.Code_Personne == res.Code_Personne).SelectMany(a => a.Emplacement)
                        .Count().ToString();
                    itemArr[4] = res.Est_Paye.ToString();
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

        private void newReservationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
