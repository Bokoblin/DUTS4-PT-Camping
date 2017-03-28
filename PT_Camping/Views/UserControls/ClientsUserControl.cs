using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using PT_Camping.Properties;
using PT_Camping.Views.Forms;

namespace PT_Camping.Views.UserControls
{
    /// <summary>
    /// The ClientUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's clients.
    /// 
    /// </summary>
    /// Author : Arthur (File creation + UI)
    /// Author : Valentine (Client feature)
    /// Since : 08/02/17
    public partial class ClientsUserControl : ManagementUserControl
    {
        public ClientsUserControl(HomeUserControl home) : base(home)
        {
            InitializeComponent();
            appBarTitle.Text = Resources.clients_management;

            clientListView.View = View.Details;
            clientListView.Columns.Add("Nom");
            clientListView.Columns.Add("Prénom");
            clientListView.Columns.Add("Email");

            UpdateClientListView();
            HandleResize();
            InitPermissions();
        }

        public void InitPermissions()
        {
            addClientButton.Enabled = UserRights.Any(d => d.Libelle_Droit == "writeClients");
            deleteButton.Visible = UserRights.Any(d => d.Libelle_Droit == "writeClients");
            editButton.Visible = UserRights.Any(d => d.Libelle_Droit == "writeClients");
        }


        public ClientsUserControl(HomeUserControl home, int clientCode) : this(home)
        {
            foreach (ListViewItem item in clientListView.Items)
            {
                item.Selected = item.Name == clientCode.ToString();
            }
        }


        private void UpdateClientListView()
        {
            clientListView.Items.Clear();

            foreach (var client in Db.Client)
            {

                string surname = client.Personne.Nom_Personne.ToUpper();
                string name = client.Personne.Prenom_Personne;
                string email = client.Personne.Email;

                var item = new ListViewItem(new[] { surname, name, email })
                {
                    Name = client.Code_Personne.ToString()
                };
                clientListView.Items.Add(item);
            }

            //=== Select the first of the list

            if (clientListView.Items.Count > 0)
            {
                clientListView.Items[0].Selected = true;
                clientListView.Select();
            }
        }


        private void UpdateClientDetails()
        {
            if (clientListView.SelectedItems.Count != 0)
            {
                int code = int.Parse(clientListView.SelectedItems[0].Name);
                var client = Db.Client.Find(code);

                if (client == null) return;

                dateInscripTextBox.Text = client.Date_Inscription.ToShortDateString();
                surnameTextBox.Text = client.Personne.Nom_Personne;
                nameTextBox.Text = client.Personne.Prenom_Personne;
                birthDateTextBox.Text = client.Personne.Date_Naissance.ToShortDateString();
                addressTextBox.Text = client.Personne.Adresse;
                phoneTextBox.Text = client.Personne.Telephone;
                emailTextBox.Text = client.Personne.Email;

                var currentReservations = Db.Reservation.Where(r => r.Date_Fin <= DateTime.Now).Select(r => r.Code_Reservation).ToList();
                currentReservationsComboBox.DataSource = currentReservations;
            }
        }


        private void AddClientButton_Click(object sender, EventArgs e)
        {
            new AddClient(Db).ShowDialog();
            Cursor.Current = Cursors.Default;
            UpdateClientListView();
        }


        private void EditClient_Click(object sender, EventArgs e)
        {
            if (addressTextBox.ReadOnly)
            {
                resetButton.Visible = true;
                surnameTextBox.ReadOnly = false;
                addressTextBox.ReadOnly = false;
                phoneTextBox.ReadOnly = false;
                emailTextBox.ReadOnly = false;
                editButton.BackgroundImage = Resources.ic_done;
            }
            else
            {
                resetButton.Visible = false;
                surnameTextBox.ReadOnly = true;
                addressTextBox.ReadOnly = true;
                phoneTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                editButton.BackgroundImage = Resources.ic_edit;

                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(clientListView.SelectedItems[0].Name);
                var client = Db.Client.Find(code);

                if (client != null)
                {
                    if (surnameTextBox.Text != "" && surnameTextBox.Text != client.Personne.Nom_Personne)
                    {
                        client.Personne.Nom_Personne = surnameTextBox.Text;
                        message += "nom, \n";
                        cptModifications++;
                    }

                    if (addressTextBox.Text != client.Personne.Adresse)
                    {
                        client.Personne.Adresse = addressTextBox.Text;
                        message += "adresse, ";
                        cptModifications++;
                    }

                    if (phoneTextBox.Text != client.Personne.Telephone)
                    {
                        if (phoneTextBox.Text.Length == 10)
                        {
                            client.Personne.Telephone = phoneTextBox.Text;
                            message += "téléphone, \n";
                            cptModifications++;
                        }
                        else
                            MessageBox.Show(Resources.phone_char_exception);
                    }

                    if (emailTextBox.Text != client.Personne.Email)
                    {
                        try
                        {
                            client.Personne.Email = new MailAddress(emailTextBox.Text).ToString();
                            message += "email.\n";
                            cptModifications++;
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show(Resources.unrecognized_email);
                        }
                    }

                    Db.SaveChanges();

                    UpdateClientDetails();
                    UpdateClientListView();

                    foreach (ListViewItem item in clientListView.Items)
                    {
                        item.Selected = item.Name == code.ToString();
                    }
                    clientListView.Select();

                    if (cptModifications > 0)
                        MessageBox.Show(message);
                }
            }
        }

        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(Resources.delete_item_confirm_message,
                                     "", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int code = int.Parse(clientListView.SelectedItems[0].Name);
                var client = Db.Client.Find(code);

                if (client != null)
                {
                    Db.Client.Remove(client);
                    Db.SaveChanges();
                    UpdateClientListView();
                }
            }
        }

        private void EmployeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetButton.Visible = false;
            editButton.BackgroundImage = Resources.ic_edit;
            surnameTextBox.ReadOnly = true;
            addressTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            UpdateClientDetails();
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            UpdateClientDetails();
            resetButton.Visible = false;
            surnameTextBox.ReadOnly = true;
            addressTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            editButton.BackgroundImage = Resources.ic_edit;
        }


        /**
         * Prevent typing non digit values in the phone textbox
         */
        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void ClientlistView_Resize(object sender, EventArgs e)
        {
            if (clientListView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in clientListView.Columns)
                    columnHeader.Width = clientListView.Width / clientListView.Columns.Count;
            }
        }


        private void ReservationsButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(clientListView.SelectedItems[0].Name);
            new Reservations(HomeUserControl, code).Show();
        }
    }
}
