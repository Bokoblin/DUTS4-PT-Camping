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

            ClientlistView.View = View.Details;
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
    }
}
