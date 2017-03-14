using PT_Camping.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PT_Camping
{
    /// <summary>
    /// The EmployeesUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's employees.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
    public partial class EmployeesUserControl : ManagementUserControl
    {
        public EmployeesUserControl(HomeUserControl home) : base(home)
        {
            InitializeComponent();
            appBarTitle.Text = "Gestion des employés";
            Db = new DataBase();
            
            employeeListView.View = System.Windows.Forms.View.Details;
            employeeListView.Columns.Add("Nom", -2);
            employeeListView.Columns.Add("Prénom", -2);
            employeeListView.Columns.Add("Email", -2);

            UpdateEmployeesListView();
            HandleResize();
        }


        private void UpdateEmployeesListView()
        {
            employeeListView.Items.Clear();

            foreach (var employee in Db.Employe)
            {
                if (!employee.EstLicencie)
                {
                    string surname = employee.Personne.Nom_Personne.ToUpper();
                    string name = employee.Personne.Prenom_Personne;
                    string email = employee.Personne.Email;

                    var item = new ListViewItem(new[] {surname, name, email})
                    {
                        Name = employee.Code_Personne.ToString()
                    };
                    employeeListView.Items.Add(item);
                }
            }

            if (employeeListView.Items.Count > 0)
            {
                employeeListView.Items[0].Selected = true;
                employeeListView.Select();
            }
        }


        private void UpdateEmployeeDetails()
        {
            if (employeeListView.SelectedItems.Count != 0)
            {
                int code = int.Parse(employeeListView.SelectedItems[0].Name);
                var employee = Db.Employe.Find(code);

                surnameTextBox.Text = employee.Personne.Nom_Personne;
                nameTextBox.Text = employee.Personne.Prenom_Personne;
                if (employee.Personne.Date_Naissance != null)
                    birthDateTextBox.Text = employee.Personne.Date_Naissance.ToShortDateString();
                addressTextBox.Text = employee.Personne.Adresse;
                phoneTextBox.Text = employee.Personne.Telephone;
                emailTextBox.Text = employee.Personne.Email;
                loginTextBox.Text = employee.Login;

                if (employee.Photo != null)
                {
                    MemoryStream ms = new MemoryStream(employee.Photo);
                    Bitmap bitmap = new Bitmap(ms);
                    pictureBox.Image = bitmap;
                    ms.Close();
                }
                else
                    pictureBox.Image = new Bitmap(Properties.Resources.contact_default);

                dismissButton.Enabled = (employee.Personne.Code_Personne != 1); //You can't dismiss Mr Campo
            }
        }


        private void OnAddEmployeeButtonClick(object sender, EventArgs e)
        {
            new AddEmployee(Db).ShowDialog();
            UpdateEmployeesListView();
        }
   

        private void OnEditButtonClick(object sender, EventArgs e)
        {
            if (addressTextBox.ReadOnly)
            {
                resetButton.Visible = true;
                addressTextBox.ReadOnly = false;
                phoneTextBox.ReadOnly = false;
                emailTextBox.ReadOnly = false;
                loginTextBox.ReadOnly = false;
                editButton.BackgroundImage = Properties.Resources.ic_done;
            }
            else
            {
                resetButton.Visible = false;
                addressTextBox.ReadOnly = true;
                phoneTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                loginTextBox.ReadOnly = true;
                editButton.BackgroundImage = Properties.Resources.ic_edit;

                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(employeeListView.SelectedItems[0].Name);
                var employee = Db.Employe.Find(code);

                if (addressTextBox.Text != employee.Personne.Adresse)
                {
                    employee.Personne.Adresse = addressTextBox.Text;
                    message += "adresse";
                    cptModifications++;
                }

                if (phoneTextBox.Text != "" && phoneTextBox.Text != employee.Personne.Telephone)
                {
                    int phone;
                    if (int.TryParse(phoneTextBox.Text, out phone) && phoneTextBox.Text.Length == 10)
                    {
                        employee.Personne.Telephone = phoneTextBox.Text;
                        message += "téléphone\n";
                        cptModifications++;
                    }
                    else
                        MessageBox.Show("Téléphone doit être un entier de 10 chiffres");
                }

                if (emailTextBox.Text != employee.Personne.Email)
                {
                    if ( (emailTextBox.Text.EndsWith(".com") || emailTextBox.Text.EndsWith(".fr")) 
                        && emailTextBox.Text.Contains("@") )
                    {
                        employee.Personne.Email = emailTextBox.Text;
                        message += "email";
                        cptModifications++;
                    }
                    else
                        MessageBox.Show("Email doit contenir un @ et se terminer par .com/.fr");
                }

                if (loginTextBox.Text != employee.Login)
                {
                    employee.Login = loginTextBox.Text;
                    message += "login";
                    cptModifications++;
                }

                Db.SaveChanges();

                UpdateEmployeeDetails();
                UpdateEmployeesListView();

                foreach (ListViewItem item in employeeListView.Items)
                {
                    item.Selected = item.Name == code.ToString();
                }
                employeeListView.Select();

                if (cptModifications > 0)
                    MessageBox.Show(message);
            }
        }


        private void OnPermissionButtonClick(object sender, EventArgs e)
        {
            int code = int.Parse(employeeListView.SelectedItems[0].Name);
            var employee = Db.Employe.Find(code);
            new Permissions(employee, Db).ShowDialog();
            Db.SaveChanges();
        }


        private void OnDismissEmployeeButtonClick(object sender, EventArgs e)
        {
            int code = int.Parse(employeeListView.SelectedItems[0].Name);
            var employee = Db.Employe.Find(code);
            employee.EstLicencie = true;
            Db.SaveChanges();
            UpdateEmployeesListView();
        }


        private void EmployeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            addressTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            loginTextBox.ReadOnly = true;
            UpdateEmployeeDetails();
        }

        private void EmployeeListView_Resize(object sender, EventArgs e)
        {
            if (employeeListView.Columns.Count == 3)
            {
                employeeListView.Columns[0].Width = employeeListView.Width / 3;
                employeeListView.Columns[1].Width = employeeListView.Width / 3;
                employeeListView.Columns[2].Width = employeeListView.Width / 3;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UpdateEmployeeDetails();
            resetButton.Visible = false;
            addressTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            loginTextBox.ReadOnly = true;
            editButton.BackgroundImage = Properties.Resources.ic_edit;
        }
    }
}
