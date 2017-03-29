using PT_Camping.Model;
using PT_Camping.Properties;
using System;
using System.Windows.Forms;

namespace PT_Camping.Views.Forms
{
    /// <summary>
    /// This dialog allows a user to change his/her password 
    /// by typing his/her current password and twice the new password.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 27/03/17
    public partial class ModifyPassword : Form
    {
        private readonly Employe _concernedEmployee;

        public ModifyPassword(Employe concernedEmployee)
        {
            InitializeComponent();
            _concernedEmployee = concernedEmployee;
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            if (oldPasstextBox.Text == "" || newPassTextBox.Text == "" || confirmPassTextBox.Text == "")
                MessageBox.Show(Resources.some_not_filled);
            else if (LoginTools.Sha256_hash(oldPasstextBox.Text) != _concernedEmployee.Password)
                MessageBox.Show(Resources.old_pass_incorrect);
            else if (newPassTextBox.Text != confirmPassTextBox.Text)
                MessageBox.Show(Resources.not_corresponding_messages);
            else
            {
                _concernedEmployee.Password = LoginTools.Sha256_hash(newPassTextBox.Text);
                Close();  
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newPassTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
            showPasswordCheckBox.Text = showPasswordCheckBox.Checked ? "Masquer" : "Afficher";
        }
    }
}
