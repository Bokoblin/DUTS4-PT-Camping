using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PT_Camping.Model;
using PT_Camping.Properties;
using PT_Camping.Views.UserControls;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

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
        private readonly DataBase _db;
        private readonly int _codePerson;
        private readonly HomeUserControl _homeUserControl;

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
            InitPermissions();
        }

        private void InitPermissions()
        {
            var userRights = _db.Personne.First(a => a.Code_Personne == LoginTools.Employee.Code_Personne).Droit.ToList();
            deleteReservationButton.Enabled = userRights.Any(d => d.Libelle_Droit == "writeReservations");
            editButton.Enabled = userRights.Any(d => d.Libelle_Droit == "writeReservations");
            newReservationButton.Enabled = userRights.Any(d => d.Libelle_Droit == "writeReservations");
        }

        private void RefreshReservations()
        {
            reservationsList.Items.Clear();
            foreach (Reservation res in _db.Reservation.Where(a => a.Code_Personne == _codePerson))
            {
                var itemArr = new string[5];
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

        private void DeleteReservationButton_Click(object sender, EventArgs e)
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

        private void FactureButton_Click(object sender, EventArgs e)
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
                    ApplyReduction applyReduction = new ApplyReduction(client);
                    if (applyReduction.ShowDialog() == DialogResult.OK)
                    {
                        int totalReduction = applyReduction.TotalReduction;
                        facture.Montant = 23;
                        _db.SaveChanges();

                        PdfDocument document = new PdfDocument();

                        // Create an empty page
                        PdfPage page = document.AddPage();

                        // Get an XGraphics object for drawing
                        XGraphics gfx = XGraphics.FromPdfPage(page);
                        XTextFormatter tf = new XTextFormatter(gfx);

                        // Set format of string.
                        XStringFormat drawFormat = new XStringFormat {Alignment = XStringAlignment.Near};

                        //font
                        XFont boldLarge = new XFont("Arial", 20, XFontStyle.Bold);
                        XFont boldSmall = new XFont("Arial", 15, XFontStyle.Bold);
                        XFont italicLarge = new XFont("Arial", 20, XFontStyle.Italic);
                        XFont italicSmall = new XFont("Arial", 15, XFontStyle.Italic);
                        XFont normal = new XFont("Arial", 15, XFontStyle.Regular);

                        // CAMPING NAME
                        tf.DrawString("Les flots blancs", boldLarge, XBrushes.Black, new XRect(5, 1, page.Width, page.Height), XStringFormats.TopLeft);
                        tf.DrawString("\n" + "camping", italicLarge, XBrushes.Black, new XRect(5, 1, page.Width, page.Height), drawFormat);

                        //INFOS FACTURE
                        const int prixUnitaire = 23;
                        int nbEmplacement = locationsList.Items.Count;
                        TimeSpan ts = reservation.Date_Fin - reservation.Date_Debut;
                        int dureeSejour = ts.Days;
                        int montantBrut = prixUnitaire * nbEmplacement * dureeSejour;
                        facture.Date_Emission = DateTime.Today;
                        string labelDateEmission = "Date: " + facture.Date_Emission.Value.Day + "-" + facture.Date_Emission.Value.Month + "-" + facture.Date_Emission.Value.Year;
                        string labelFact = "Facture n° " + codeRes;
                        
                        if (totalReduction != 0)
                        {
                            facture.Montant = montantBrut * 100 / totalReduction;
                        }
                        else
                        {
                            facture.Montant = montantBrut;
                        }  
                      
                        tf.DrawString(labelFact + "\n" + labelDateEmission + "\nNum Client: " + client.Code_Personne, boldSmall, XBrushes.Blue, new XRect(430, 10, page.Width, page.Height));

                        //Infos client
                        tf.DrawString("M." + client.Personne.Prenom_Personne + " " + client.Personne.Nom_Personne, boldSmall, XBrushes.Black, new XRect(400, 100, page.Width, page.Height));
                        tf.DrawString("\n" + client.Personne.Adresse,italicSmall, XBrushes.Black, new XRect(380, 105, page.Width, page.Height));

                        //Infos camping
                        tf.DrawString("17 Route de Sarnac" + "\n" + "33930 MONTALIVET" + "\n" + "Tel : 05 56 41 70 44", normal, XBrushes.Black, new XRect(5, 105, page.Width, page.Height));
                        int cmp = 20;

                        // TABLEAU
                        tf.DrawString("Emplacement : ", boldSmall, XBrushes.Black, new XRect(60, 200, page.Width, page.Height));
                        tf.DrawString("Prix unitaire: ", boldSmall, XBrushes.Black, new XRect(260, 200, page.Width, page.Height));
                        tf.DrawString("Durée du séjour: ", boldSmall, XBrushes.Black, new XRect(450, 200, page.Width, page.Height));

                        for (int i = 1; i <= locationsList.Items.Count; i++)
                        {                      
                            tf.DrawString(i + ". " + locationsList.Items[i - 1] + "\n", normal, XBrushes.Black, new XRect(50, 220+cmp, page.Width, page.Height));
                            tf.DrawString(prixUnitaire + " €" + "\n", normal, XBrushes.Black, new XRect(280, 220+cmp, page.Width, page.Height));
                            tf.DrawString(dureeSejour + " jours" + "\n", normal, XBrushes.Black, new XRect(450, 220 + cmp, page.Width, page.Height));
                       
                            cmp += 20;

                            if (i == locationsList.Items.Count)
                            {
                                tf.DrawString("TOTAL Hors réduction : " + montantBrut + " € \n", boldSmall, XBrushes.Black, new XRect(80, 240 + (i - 2) * cmp + cmp, page.Width, page.Height));
                                tf.DrawString("TOTAL Net à Payer : " + facture.Montant + "€ \n", boldSmall, XBrushes.Red, new XRect(80, 260 + (i - 2) * cmp + cmp, page.Width, page.Height));
                            }
                        }

                        tf.DrawString("Signature : " , normal, XBrushes.Black, new XRect(400, 700, page.Width, page.Height));
                        // Save the document...
                        const string filename = "Facture.pdf";
                        document.Save(filename);
                        Process.Start(filename);

                        _db.SaveChanges();
                    }
                }
            }
        }

        private void ReservationsList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
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

        private void NewReservationButton_Click(object sender, EventArgs e)
        {
            new NewReservation(_homeUserControl, _db, _codePerson).Show();
        }

        private void LocationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reservationsList.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = reservationsList.SelectedItems[0];
                if (listViewItem != null)
                {
                    int resId = int.Parse(listViewItem.SubItems[4].Text);
                    Reservation res =
                        _db.Reservation.FirstOrDefault(
                            a => a.Code_Reservation == resId);
                    ListBox listBox = sender as ListBox;
                    if (listBox?.SelectedItem != null)
                    {
                        string locationName = (string)listBox.SelectedItem;
                        Emplacement loc = _db.Emplacement.FirstOrDefault(a => a.Nom_Emplacement == locationName);
                        lodgerList.Items.Clear();
                        foreach (Personne lodger in _db.Loge.Where(a => a.Code_Reservation == res.Code_Reservation 
                        && a.Code_Emplacement == loc.Code_Emplacement).Select(a => a.Personne))
                        {
                            lodgerList.Items.Add(lodger.Nom_Personne + " " + lodger.Prenom_Personne);
                        }
                    }
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = reservationsList.SelectedItems[0];
            if (listViewItem != null)
            {
                int resId = int.Parse(listViewItem.SubItems[4].Text);
                new NewReservation(_homeUserControl, _db, _codePerson, NewReservation.Mode.Edit, resId).Show();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshReservations();
        }
    }
}
