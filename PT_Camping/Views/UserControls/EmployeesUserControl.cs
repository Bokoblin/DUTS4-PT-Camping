using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Properties;
using PT_Camping.Views.Forms;

namespace PT_Camping.Views.UserControls
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
            appBarTitle.Text = Resources.employee_management;

            employeesListView.View = View.Details;
            employeesListView.Columns.Add("Nom");
            employeesListView.Columns.Add("Prénom");
            employeesListView.Columns.Add("Email");

            UpdateEmployeesListView();
            HandleResize();
            InitPermissions();
        }

        public EmployeesUserControl(HomeUserControl home, int employeeCode) : this(home)
        {
            foreach (ListViewItem item in employeesListView.Items)
            {
                item.Selected = item.Name == employeeCode.ToString();
            }
        }

        private void InitPermissions()
        {
            addEmployeeButton.Enabled = UserRights.Any(d => d.Libelle_Droit == "writeEmployees");
            dismissButton.Enabled = UserRights.Any(d => d.Libelle_Droit == "writeEmployees");
            editButton.Visible = UserRights.Any(d => d.Libelle_Droit == "writeEmployees");
            permissionButton.Enabled = UserRights.Any(d => d.Libelle_Droit == "writeEmployees");
            addEmployeePhotoPictureBox.Visible = UserRights.Any(d => d.Libelle_Droit == "writeEmployees");
        }
        
        private void UpdateEmployeesListView()
        {
            employeesListView.Items.Clear();

            foreach (var employee in Db.Employe)
            {
                if (!employee.EstLicencie)
                {
                    string surname = employee.Personne.Nom_Personne.ToUpper();
                    string name = employee.Personne.Prenom_Personne;
                    string email = employee.Personne.Email;

                    var item = new ListViewItem(new[] { surname, name, email })
                    {
                        Name = employee.Code_Personne.ToString()
                    };
                    employeesListView.Items.Add(item);
                }
            }

            //=== Select the first of the list

            if (employeesListView.Items.Count > 0)
            {
                employeesListView.Items[0].Selected = true;
                employeesListView.Select();
            }
        }

        private void UpdateEmployeeDetails()
        {
            if (employeesListView.SelectedItems.Count != 0)
            {
                int code = int.Parse(employeesListView.SelectedItems[0].Name);
                var employee = Db.Employe.Find(code);

                if (employee == null) return;

                surnameTextBox.Text = employee.Personne.Nom_Personne;
                nameTextBox.Text = employee.Personne.Prenom_Personne;
                birthDateTextBox.Text = employee.Personne.Date_Naissance.ToShortDateString();
                addressTextBox.Text = employee.Personne.Adresse;
                phoneTextBox.Text = employee.Personne.Telephone;
                emailTextBox.Text = employee.Personne.Email;
                loginTextBox.Text = employee.Login;

                if (employee.Photo != null)
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream(employee.Photo);
                        Bitmap bitmap = new Bitmap(ms);
                        pictureBox.Image = bitmap;
                        ms.Close();
                    }
                    catch (ArgumentException)
                    {
                        //Crashes may occur if file is corrupted or convertion to bitmap fails
                        pictureBox.Image = new Bitmap(Resources.ic_contact_default);
                    }    
                }
                else
                    pictureBox.Image = new Bitmap(Resources.ic_contact_default);
                
                dismissButton.Enabled = (employee.Personne.Code_Personne != 1) 
                    && UserRights.Any(d => d.Libelle_Droit == "writeEmployees"); //Mr Campo can't be dismissed
                editButton.Visible = (employee.Personne.Code_Personne == LoginTools.Employee.Code_Personne) 
                    || UserRights.Any(d => d.Libelle_Droit == "writeEmployees");
                passButton.Enabled = (employee.Personne.Code_Personne == LoginTools.Employee.Code_Personne);
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            new AddEmployee(Db).ShowDialog();
            Cursor.Current = Cursors.WaitCursor;
            UpdateEmployeesListView();
        }
   
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (addressTextBox.ReadOnly)
            {
                resetButton.Visible = true;
                addressTextBox.ReadOnly = false;
                phoneTextBox.ReadOnly = false;
                emailTextBox.ReadOnly = false;
                loginTextBox.ReadOnly = false;
                editButton.BackgroundImage = Resources.ic_done;
            }
            else
            {
                resetButton.Visible = false;
                addressTextBox.ReadOnly = true;
                phoneTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                loginTextBox.ReadOnly = true;
                editButton.BackgroundImage = Resources.ic_edit;

                string message = "Les données suivantes ont été mises à jour : \n";
                int cptModifications = 0;

                int code = int.Parse(employeesListView.SelectedItems[0].Name);
                var employee = Db.Employe.Find(code);

                if (employee != null)
                {
                    if (addressTextBox.Text != employee.Personne.Adresse)
                    {
                        employee.Personne.Adresse = addressTextBox.Text;
                        message += "adresse";
                        cptModifications++;
                    }

                    if (phoneTextBox.Text != "" && phoneTextBox.Text != employee.Personne.Telephone)
                    {
                        if (phoneTextBox.Text.Length == 10)
                        {
                            employee.Personne.Telephone = phoneTextBox.Text;
                        message += "téléphone\n";
                        cptModifications++;
                        }
                        else
                            MessageBox.Show(Resources.phone_char_exception);
                    }

                    if (emailTextBox.Text != employee.Personne.Email)
                    {
                        try
                        {
                            employee.Personne.Email = new MailAddress(emailTextBox.Text).ToString();
                            message += "email";
                            cptModifications++;
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show(Resources.unrecognized_email);
                        }
                    }

                    if (loginTextBox.Text != employee.Login)
                    {
                        employee.Login = loginTextBox.Text;
                        message += "login";
                        cptModifications++;
                    }
                }

                Db.SaveChanges();

                UpdateEmployeeDetails();

                if (cptModifications > 0)
                    MessageBox.Show(message);
            }
        }
        
        private void PermissionButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(employeesListView.SelectedItems[0].Name);
            var employee = Db.Employe.Find(code);
            new Permissions(employee, Db).ShowDialog();
            Db.SaveChanges();
        }
        
        private void PassButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(employeesListView.SelectedItems[0].Name);
            var employee = Db.Employe.Find(code);
            new ModifyPassword(employee).ShowDialog();
            Db.SaveChanges();
        }
        
        private void DismissEmployeeButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(employeesListView.SelectedItems[0].Name);
            var employee = Db.Employe.Find(code);
            if (employee != null)
                employee.EstLicencie = true;
            Db.SaveChanges();
            UpdateEmployeesListView();
        }
        
        private void EmployeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetButton.Visible = false;
            editButton.BackgroundImage = Resources.ic_edit;
            addressTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            loginTextBox.ReadOnly = true;
            UpdateEmployeeDetails();
        }
        
        private void EmployeeListView_Resize(object sender, EventArgs e)
        {
            if (employeesListView.Columns.Count != 0)
            {
                foreach (ColumnHeader columnHeader in employeesListView.Columns)
                    columnHeader.Width = employeesListView.Width / employeesListView.Columns.Count;
            }
        }
        
        /**
         * Prevent typing non digit values in the phone textbox
         */
        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
            editButton.BackgroundImage = Resources.ic_edit;
        }
        
        private void AddEmployeePhotoPictureBox_Click(object sender, EventArgs e)
        {
            using (FileDialog fd = new OpenFileDialog())
            {
                fd.Title = Resources.select_background_image;
                fd.Filter = Resources.images_files_formats;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        Bitmap image = new Bitmap(fd.FileName);
                        image.SetResolution(50, 70);
                        LoginTools.CheckConnection();

                        int code = int.Parse(employeesListView.SelectedItems[0].Name);
                        var employee = Db.Employe.Find(code);

                        if (employee != null)
                        {
                            MemoryStream jpegStream = new MemoryStream();
                            image.Save(jpegStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            employee.Photo = jpegStream.ToArray();
                            Db.SaveChanges();
                            pictureBox.Image = image;
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show(Resources.file_not_found_please_retry);
                    }
                    catch (FileLoadException)
                    {
                        MessageBox.Show(Resources.error_when_opening_the_file_please_retry);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }
    }      
}
