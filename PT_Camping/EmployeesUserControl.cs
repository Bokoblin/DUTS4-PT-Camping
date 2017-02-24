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
            db = new DataBase();

            employeeListView.View = View.Details;
            employeeListView.Columns.Add("Employé", -2);

            updateEmployeesListView();
            handleResize();
        }


        internal new void handleResize()
        {
            base.handleResize();

            employeeListView.Size = new Size(
                Convert.ToInt32(mHomeUC.Size.Width * 0.3),
                Convert.ToInt32(employeeListView.Size.Height)
                );
        }


        private void updateEmployeesListView()
        {
            employeeListView.Items.Clear();

            foreach (var employee in db.Employe)
            {
                if (!employee.EstLicencie)
                {
                    string surnameAndName = employee.Personne.Nom_Personne.ToUpper()
                        + " " + employee.Personne.Prenom_Personne;

                    var item = new ListViewItem(new[] { surnameAndName });
                    item.Name = employee.Code_Personne.ToString();
                    employeeListView.Items.Add(item);
                }
            }

            if (employeeListView.Items.Count > 0)
            {
                employeeListView.Items[0].Selected = true;
                employeeListView.Select();
            }
        }


        private void updateEmployeeDetails()
        {
            if (employeeListView.SelectedItems.Count != 0)
            {
                int code = int.Parse(employeeListView.SelectedItems[0].Name);
                var employee = db.Employe.Find(code);

                surnameTextBox.Text = employee.Personne.Nom_Personne;
                nameTextBox.Text = employee.Personne.Prenom_Personne;
                if (employee.Personne.Date_Naissance != null)
                    birthDateTextBox.Text = ((DateTime)employee.Personne.Date_Naissance).ToShortDateString();
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


        private void onAddEmployeeButtonClick(object sender, EventArgs e)
        {
            new AddEmployee(db).ShowDialog();
            updateEmployeesListView();
        }
   

        private void onEditButtonClick(object sender, EventArgs e)
        {
            if (addressTextBox.ReadOnly == true)
            {
                addressTextBox.ReadOnly = false;
                phoneTextBox.ReadOnly = false;
                emailTextBox.ReadOnly = false;
                loginTextBox.ReadOnly = false;
            }
            else
            {
                addressTextBox.ReadOnly = true;
                phoneTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                loginTextBox.ReadOnly = true;

                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(employeeListView.SelectedItems[0].Name);
                var employee = db.Employe.Find(code);

                if (addressTextBox.Text != employee.Personne.Adresse)
                {
                    employee.Personne.Adresse = addressTextBox.Text;
                    message += "adresse";
                    cptModifications++;
                }

                if (phoneTextBox.Text != employee.Personne.Telephone)
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

                db.SaveChanges();

                updateEmployeeDetails();

                if (cptModifications > 0)
                    MessageBox.Show(message);
            }
        }


        private void onPermissionButtonClick(object sender, EventArgs e)
        {
            int code = int.Parse(employeeListView.SelectedItems[0].Name);
            var employee = db.Employe.Find(code);
            new Permissions(employee, db).ShowDialog();
            db.SaveChanges();
        }


        private void onDismissEmployeeButtonClick(object sender, EventArgs e)
        {
            int code = int.Parse(employeeListView.SelectedItems[0].Name);
            var employee = db.Employe.Find(code);
            employee.EstLicencie = true;
            db.SaveChanges();
            updateEmployeesListView();
        }


        private void employeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateEmployeeDetails();
        }
    }
}
