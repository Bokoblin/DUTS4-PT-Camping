using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.View.Forms;
using System.Text.RegularExpressions;

namespace PT_Camping
{
    /// <summary>
    /// The ClientUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's clients.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
    public partial class ClientsUserControl : ManagementUserControl
    {
        private Client client;
        public ClientsUserControl(HomeUserControl home) : base(home)
        {
            InitializeComponent();
            appBarTitle.Text = "Gestion des clients";
            db = new DataBase();

            ClientlistView.View = System.Windows.Forms.View.Details;
            ClientlistView.Columns.Add("Nom", -2);
            ClientlistView.Columns.Add("Prénom", -2);

           updateClientlistView();
            handleResize();
        }

        private void updateClientlistView()
        {
            ClientlistView.Items.Clear();

            foreach (var cl in db.Client)
            {
                
                    string surname = cl.Personne.Nom_Personne.ToUpper();
                    string name = cl.Personne.Prenom_Personne;

                    var item = new ListViewItem(new[] { surname, name });
                    item.Name = cl.Code_Personne.ToString();
                    ClientlistView.Items.Add(item);    
            }

            if (ClientlistView.Items.Count > 0)
            {
                ClientlistView.Items[0].Selected = true;
                ClientlistView.Select();
            }
        }

        private void updateClientDetails()
        {
            if (ClientlistView.SelectedItems.Count != 0)
            {
                int code = int.Parse(ClientlistView.SelectedItems[0].Name);
                client = db.Client.Find(code);
                dateInscripTextBox.Text = client.Date_Inscription.ToShortDateString();
                surnameTextBox.Text =client.Personne.Nom_Personne;
                FirstNameTextBox.Text = client.Personne.Prenom_Personne;
                if (client.Personne.Date_Naissance != null)
                    birthDateTextBox.Text = ((DateTime)client.Personne.Date_Naissance).ToShortDateString();
                addressTextBox.Text = client.Personne.Adresse;
                phoneTextBox.Text = client.Personne.Telephone;
                emailTextBox.Text = client.Personne.Email;

                //resaTextBox.Text = ;
            }
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            new AddClient(db).ShowDialog();
            updateClientlistView();
        }

        private void editClient_Click(object sender, EventArgs e)
        {
            if (addressTextBox.ReadOnly == true)
            {
                surnameTextBox.ReadOnly = false;
                addressTextBox.ReadOnly = false;
                phoneTextBox.ReadOnly = false;
                emailTextBox.ReadOnly = false;
               
               
            }
            else
            {
                surnameTextBox.ReadOnly = true;
                addressTextBox.ReadOnly = true;
                phoneTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
            

                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(ClientlistView.SelectedItems[0].Name);
                var client = db.Client.Find(code);

                if (addressTextBox.Text != client.Personne.Adresse)
                {
                    //verifier si le nom ne contient pas de nombre
                    client.Personne.Adresse = addressTextBox.Text;
                    message += "adresse";
                    cptModifications++;
                }

                if (phoneTextBox.Text != "" && phoneTextBox.Text != client.Personne.Telephone)
                {
                    int phone;
                    if (int.TryParse(phoneTextBox.Text, out phone) && phoneTextBox.Text.Length == 10)
                    {
                        client.Personne.Telephone = phoneTextBox.Text;
                        message += "téléphone\n";
                        cptModifications++;
                    }
                    else
                        MessageBox.Show("Téléphone doit être un entier de 10 chiffres");
                }

                if (surnameTextBox.Text != "" && surnameTextBox.Text != client.Personne.Nom_Personne)
                {
                
                        client.Personne.Nom_Personne = surnameTextBox.Text;
                        message += "Nom\n";
                        cptModifications++;
                
                }

                if (emailTextBox.Text != client.Personne.Email)
                {
                    if ((emailTextBox.Text.EndsWith(".com") || emailTextBox.Text.EndsWith(".fr"))
                        && emailTextBox.Text.Contains("@"))
                    {
                        client.Personne.Email = emailTextBox.Text;
                        message += "email";
                        cptModifications++;
                    }
                    else
                        MessageBox.Show("Email doit contenir un @ et se terminer par .com/.fr");
                }

                db.SaveChanges();

                updateClientDetails();

                if (cptModifications > 0)
                    MessageBox.Show(message);
            }
        }

        private void DismissClientButton_Click(object sender, EventArgs e)
        {
            db.Client.Remove(client);
            db.SaveChanges();
            updateClientlistView();
        }

        private void employeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            addressTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
           
            updateClientDetails();
        }

        private void ClientlistView_Resize(object sender, EventArgs e)
        {
            if (ClientlistView.Columns.Count == 3)
            {
                ClientlistView.Columns[0].Width = ClientlistView.Width / 3;
                ClientlistView.Columns[1].Width = ClientlistView.Width / 3;
                ClientlistView.Columns[2].Width = ClientlistView.Width / 3;
            }
        }

        private void ReducClient_Click(object sender, EventArgs e)
        {
            new Reductions(client).ShowDialog();
            updateClientlistView();
        }
    }
}
