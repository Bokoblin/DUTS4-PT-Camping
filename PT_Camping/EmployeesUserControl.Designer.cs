namespace PT_Camping
{
    partial class EmployeesUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesUserControl));
            this.employeeListView = new System.Windows.Forms.ListView();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.dismissButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.detailsTitleBarPanel = new System.Windows.Forms.Panel();
            this.detailsTitle = new System.Windows.Forms.Label();
            this.permissionButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.detailsPanel.SuspendLayout();
            this.detailsTitleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // employeeListView
            // 
            this.employeeListView.GridLines = true;
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(25, 80);
            this.employeeListView.MultiSelect = false;
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(320, 400);
            this.employeeListView.TabIndex = 11;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.View = System.Windows.Forms.View.List;
            this.employeeListView.SelectedIndexChanged += new System.EventHandler(this.employeeListView_SelectedIndexChanged);
            // 
            // detailsPanel
            // 
            this.detailsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailsPanel.AutoSize = true;
            this.detailsPanel.BackColor = System.Drawing.Color.White;
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.dismissButton);
            this.detailsPanel.Controls.Add(this.nameTextBox);
            this.detailsPanel.Controls.Add(this.nameLabel);
            this.detailsPanel.Controls.Add(this.loginTextBox);
            this.detailsPanel.Controls.Add(this.emailTextBox);
            this.detailsPanel.Controls.Add(this.phoneTextBox);
            this.detailsPanel.Controls.Add(this.addressTextBox);
            this.detailsPanel.Controls.Add(this.birthDateTextBox);
            this.detailsPanel.Controls.Add(this.surnameTextBox);
            this.detailsPanel.Controls.Add(this.editButton);
            this.detailsPanel.Controls.Add(this.detailsTitleBarPanel);
            this.detailsPanel.Controls.Add(this.permissionButton);
            this.detailsPanel.Controls.Add(this.loginLabel);
            this.detailsPanel.Controls.Add(this.emailLabel);
            this.detailsPanel.Controls.Add(this.phoneLabel);
            this.detailsPanel.Controls.Add(this.addressLabel);
            this.detailsPanel.Controls.Add(this.birthDateLabel);
            this.detailsPanel.Controls.Add(this.surnameLabel);
            this.detailsPanel.Location = new System.Drawing.Point(420, 80);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(352, 400);
            this.detailsPanel.TabIndex = 13;
            // 
            // dismissButton
            // 
            this.dismissButton.AutoSize = true;
            this.dismissButton.Location = new System.Drawing.Point(190, 340);
            this.dismissButton.Name = "dismissButton";
            this.dismissButton.Size = new System.Drawing.Size(120, 30);
            this.dismissButton.TabIndex = 21;
            this.dismissButton.Text = "Licencier";
            this.dismissButton.UseVisualStyleBackColor = true;
            this.dismissButton.Click += new System.EventHandler(this.onDismissEmployeeButtonClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(160, 124);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(120, 20);
            this.nameTextBox.TabIndex = 20;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(29, 127);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 13);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Prénom";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(160, 274);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.ReadOnly = true;
            this.loginTextBox.Size = new System.Drawing.Size(120, 20);
            this.loginTextBox.TabIndex = 17;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(160, 248);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(120, 20);
            this.emailTextBox.TabIndex = 16;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(160, 222);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(120, 20);
            this.phoneTextBox.TabIndex = 15;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(160, 176);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(120, 40);
            this.addressTextBox.TabIndex = 14;
            // 
            // dateOfBirthTextBox
            // 
            this.birthDateTextBox.Location = new System.Drawing.Point(160, 150);
            this.birthDateTextBox.Name = "dateOfBirthTextBox";
            this.birthDateTextBox.ReadOnly = true;
            this.birthDateTextBox.Size = new System.Drawing.Size(120, 20);
            this.birthDateTextBox.TabIndex = 13;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(160, 98);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(120, 20);
            this.surnameTextBox.TabIndex = 12;
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Location = new System.Drawing.Point(317, 46);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(30, 30);
            this.editButton.TabIndex = 10;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.onEditButtonClick);
            // 
            // detailsTitleBarPanel
            // 
            this.detailsTitleBarPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.detailsTitleBarPanel.Controls.Add(this.detailsTitle);
            this.detailsTitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsTitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsTitleBarPanel.Name = "detailsTitleBarPanel";
            this.detailsTitleBarPanel.Size = new System.Drawing.Size(350, 40);
            this.detailsTitleBarPanel.TabIndex = 9;
            // 
            // detailsTitle
            // 
            this.detailsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsTitle.AutoSize = true;
            this.detailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTitle.ForeColor = System.Drawing.Color.White;
            this.detailsTitle.Location = new System.Drawing.Point(104, 10);
            this.detailsTitle.Name = "detailsTitle";
            this.detailsTitle.Size = new System.Drawing.Size(121, 20);
            this.detailsTitle.TabIndex = 0;
            this.detailsTitle.Text = "Détail employés";
            // 
            // permissionButton
            // 
            this.permissionButton.AutoSize = true;
            this.permissionButton.Location = new System.Drawing.Point(40, 340);
            this.permissionButton.Name = "permissionButton";
            this.permissionButton.Size = new System.Drawing.Size(120, 30);
            this.permissionButton.TabIndex = 8;
            this.permissionButton.Text = "Permissions";
            this.permissionButton.UseVisualStyleBackColor = true;
            this.permissionButton.Click += new System.EventHandler(this.onPermissionButtonClick);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(29, 277);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Login";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(29, 251);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(29, 225);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(58, 13);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Téléphone";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(29, 179);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Adresse";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(29, 153);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(98, 13);
            this.birthDateLabel.TabIndex = 2;
            this.birthDateLabel.Text = "Date de Naissance";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(29, 101);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(29, 13);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Nom";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.AutoSize = true;
            this.addEmployeeButton.Location = new System.Drawing.Point(100, 520);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(166, 38);
            this.addEmployeeButton.TabIndex = 14;
            this.addEmployeeButton.Text = "Nouvel employé";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.onAddEmployeeButtonClick);
            // 
            // EmployeesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.employeeListView);
            this.Name = "EmployeesUserControl";
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.Controls.SetChildIndex(this.employeeListView, 0);
            this.Controls.SetChildIndex(this.detailsPanel, 0);
            this.Controls.SetChildIndex(this.addEmployeeButton, 0);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.detailsTitleBarPanel.ResumeLayout(false);
            this.detailsTitleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel detailsTitleBarPanel;
        private System.Windows.Forms.Label detailsTitle;
        private System.Windows.Forms.Button permissionButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Button dismissButton;
        private System.Windows.Forms.Button addEmployeeButton;
    }
}
