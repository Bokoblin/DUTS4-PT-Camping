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

namespace PT_Camping.Views.Forms
{
    public partial class NewReservation : Form
    {
        private DataBase _db;

        public NewReservation()
        {
            InitializeComponent();
            _db = new DataBase();
            foreach (Personne person in _db.Personne)
            {
                reservationHolderComboBox.Items.Add(person.Nom_Personne + " " + person.Prenom_Personne);
                reservationHolderComboBox.AutoCompleteCustomSource.Add(person.Nom_Personne + " " + person.Prenom_Personne);
            }
        }

        public NewReservation(int codePerson): this()
        {
            Personne client = _db.Personne.Find(codePerson);
            if (client != null)
            {
                reservationHolderComboBox.SelectedText = client.Nom_Personne + " " + client.Prenom_Personne;
            }
        }

        private void addLocationButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteLocationButton_Click(object sender, EventArgs e)
        {

        }

        private void addLodgerButton_Click(object sender, EventArgs e)
        {

        }

        private void removeLodgerButton_Click(object sender, EventArgs e)
        {

        }

        private void addReservationButton_Click(object sender, EventArgs e)
        {

        }

        private void reservationHolderComboBox_TextChanged(object sender, EventArgs e)
        {
            /*String text = reservationHolderComboBox.SelectedText;
            reservationHolderComboBox.Items.Clear();
            foreach (Personne person in _db.Personne.Where(a => a.Nom_Personne.Contains(text) || a.Prenom_Personne.Contains(text)))
            {
                reservationHolderComboBox.Items.Add(person.Nom_Personne + " " + person.Prenom_Personne);
            }
            reservationHolderComboBox.DroppedDown = true;
            reservationHolderComboBox.Refresh();
            reservationHolderComboBox.Focus();
            if (reservationHolderComboBox.Text.Length > 0)
            {
                reservationHolderComboBox.SelectionStart = reservationHolderComboBox.Text.Length;
                reservationHolderComboBox.SelectionLength = 0;
            }*/
        }
    }
}
