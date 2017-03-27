using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using PT_Camping.Properties;
using PT_Camping.Views.Forms;

namespace PT_Camping.Views.UserControls
{
    /// <summary>
    /// The ProvidersUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's stocks providers.
    /// It allows seeing all the providers for the camping products,
    /// Adding a new provider, modifying, deleting or contacting them.
    /// 
    /// </summary>
    /// Author : Arthur (File creation + UI)
    /// Author : Claire (provider feature)
    /// Since : 08/02/17
    public partial class ProvidersUserControl : ManagementUserControl
    {
        public ProvidersUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = Resources.provider_management;

            providerListView.View = View.Details;
            providerListView.Columns.Add("Nom du fournisseur", -2);
            providerListView.Columns.Add("Adresse mail du fournisseur", -2);

            UpdateProvidersListView();
            HandleResize();
            InitPermissions();
        }

        public void InitPermissions()
        {
            addProviderButton.Enabled = UserRights.Any(d => d.Libelle_Droit == "writeProviders");
            deleteButton.Visible = UserRights.Any(d => d.Libelle_Droit == "writeProviders");
            editButton.Visible = UserRights.Any(d => d.Libelle_Droit == "writeProviders");
        }

        public void UpdateProvidersListView()
        {
            providerListView.Items.Clear();

            foreach (var provider in Db.Fournisseur)
            {
                string providerEmail = provider.Email_Fournisseur;
                string providerName = provider.Nom_Fournisseur;

                var item = new ListViewItem(new[] { providerName, providerEmail })
                {
                    Name = provider.Code_Fournisseur.ToString()
                };
                providerListView.Items.Add(item);
            }

            //=== Select the first of the list

            if (providerListView.Items.Count > 0)
            {
                providerListView.Items[0].Selected = true;
                providerListView.Select();
            }
        }


        public void UpdateProviderDetails()
        {
            if (providerListView.SelectedItems.Count != 0)
            {
                int code = int.Parse(providerListView.SelectedItems[0].Name);
                var provider = Db.Fournisseur.Find(code);

                if (provider != null)
                {
                    nameTextBox.Text = provider.Nom_Fournisseur;
                    addressTextBox.Text = provider.Adresse_Fournisseur;
                    emailTextBox.Text = provider.Email_Fournisseur;
                    websiteTextBox.Text = provider.Site_web_Fournisseur ?? Resources.unknown_site;
                }
            }
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(providerListView.SelectedItems[0].Name);
            var provider = Db.Fournisseur.Find(code);
            if (provider != null)
                Process.Start("mailto:" + provider.Email_Fournisseur);
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.ReadOnly)
            {
                resetButton.Visible = true;
                nameTextBox.ReadOnly = false;
                addressTextBox.ReadOnly = false;
                emailTextBox.ReadOnly = false;
                websiteTextBox.ReadOnly = false;
                editButton.BackgroundImage = Resources.ic_done;
            }
            else
            {
                resetButton.Visible = false;
                nameTextBox.ReadOnly = true;
                addressTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                websiteTextBox.ReadOnly = true;
                editButton.BackgroundImage = Resources.ic_edit;


                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(providerListView.SelectedItems[0].Name);
                var provider = Db.Fournisseur.Find(code);

                if (provider != null)
                {
                    if (nameTextBox.Text != provider.Nom_Fournisseur)
                    {
                        provider.Nom_Fournisseur = nameTextBox.Text;
                        message += "nom,\n";
                        cptModifications++;
                    }

                    if (addressTextBox.Text != provider.Adresse_Fournisseur)
                    {
                        provider.Adresse_Fournisseur = addressTextBox.Text;
                        message += "address,\n";
                        cptModifications++;
                    }

                    if (emailTextBox.Text != provider.Email_Fournisseur)
                    {
                        try
                        {
                            provider.Email_Fournisseur = new MailAddress(emailTextBox.Text).ToString();
                            message += "email,\n";
                            cptModifications++;
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show(Resources.unrecognized_email);
                        }
                    }

                    if (websiteTextBox.Text != provider.Site_web_Fournisseur)
                    {
                        if (websiteTextBox.Text != "")
                        {
                            Uri uriResult;
                            if (Uri.TryCreate(websiteTextBox.Text, UriKind.Absolute, out uriResult)
                                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                            {
                                provider.Site_web_Fournisseur = websiteTextBox.Text;
                                message += "site web";
                                cptModifications++;
                            }
                            else
                                MessageBox.Show(Resources.unrecognized_website);
                        }
                        else
                            provider.Site_web_Fournisseur = null;
                    }

                    Db.SaveChanges();

                    UpdateProviderDetails();
                    UpdateProvidersListView();

                    foreach (ListViewItem item in providerListView.Items)
                    {
                        item.Selected = item.Name == code.ToString();
                    }
                    providerListView.Select();

                    if (cptModifications > 0)
                        MessageBox.Show(message);
                }
            }
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            resetButton.Visible = false;
            nameTextBox.ReadOnly = true;
            addressTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            websiteTextBox.ReadOnly = true;
            editButton.BackgroundImage = Resources.ic_edit;
            UpdateProvidersListView();
        }


        private void AddProvider_Click(object sender, EventArgs e)
        {
            new AddProvider(Db).ShowDialog();
            Cursor.Current = Cursors.Default;
            UpdateProvidersListView();
        }


        private void ProviderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetButton.Visible = false;
            nameTextBox.ReadOnly = true;
            addressTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            websiteTextBox.ReadOnly = true;
            editButton.BackgroundImage = Resources.ic_edit;
            UpdateProviderDetails();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(Resources.delete_item_confirm_message,
                                     "", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int code = int.Parse(providerListView.SelectedItems[0].Name);
                var fournisseur = Db.Fournisseur.Find(code);

                if (fournisseur != null)
                {
                    Db.Fournisseur.Remove(fournisseur);
                    Db.SaveChanges();
                    UpdateProvidersListView();
                }
            }
        }

        private void ProviderListView_Resize(object sender, EventArgs e)
        {
            if (providerListView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in providerListView.Columns)
                    columnHeader.Width = providerListView.Width / providerListView.Columns.Count;
            }
        }
    }
}
