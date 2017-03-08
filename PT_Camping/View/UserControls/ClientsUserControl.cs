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
        private DataBase db;
        public ClientsUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
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
                var client = db.Client.Find(code);

                surnameTextBox.Text =client.Personne.Nom_Personne;
                nameTextBox.Text = client.Personne.Prenom_Personne;
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

        private void ClientsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void DetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void surnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void birthDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
