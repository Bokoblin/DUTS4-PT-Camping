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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.employeesListView = new System.Windows.Forms.ListView();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
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
            this.tableLayoutPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.detailsTitleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Controls.Add(this.employeesListView, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.addEmployeeButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.detailsPanel, 3, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 550);
            this.tableLayoutPanel.TabIndex = 11;
            // 
            // employeeListView
            // 
            this.employeesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesListView.FullRowSelect = true;
            this.employeesListView.GridLines = true;
            this.employeesListView.HideSelection = false;
            this.employeesListView.Location = new System.Drawing.Point(43, 47);
            this.employeesListView.MultiSelect = false;
            this.employeesListView.Name = "employeeListView";
            this.employeesListView.Scrollable = false;
            this.employeesListView.Size = new System.Drawing.Size(314, 390);
            this.employeesListView.TabIndex = 14;
            this.employeesListView.UseCompatibleStateImageBehavior = false;
            this.employeesListView.View = System.Windows.Forms.View.List;
            this.employeesListView.SelectedIndexChanged += new System.EventHandler(this.employeeListView_SelectedIndexChanged);
            this.employeesListView.Resize += new System.EventHandler(this.employeeListView_Resize);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmployeeButton.AutoSize = true;
            this.addEmployeeButton.Location = new System.Drawing.Point(140, 463);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(120, 35);
            this.addEmployeeButton.TabIndex = 15;
            this.addEmployeeButton.Text = "Nouvel employé";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.onAddEmployeeButtonClick);
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoSize = true;
            this.detailsPanel.BackColor = System.Drawing.Color.White;
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.pictureBox);
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
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(443, 47);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(314, 390);
            this.detailsPanel.TabIndex = 16;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ErrorImage = global::PT_Camping.Properties.Resources.contact_default;
            this.pictureBox.Image = global::PT_Camping.Properties.Resources.contact_default;
            this.pictureBox.Location = new System.Drawing.Point(124, 43);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(60, 70);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            // 
            // dismissButton
            // 
            this.dismissButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dismissButton.AutoSize = true;
            this.dismissButton.Location = new System.Drawing.Point(171, 357);
            this.dismissButton.Name = "dismissButton";
            this.dismissButton.Size = new System.Drawing.Size(120, 30);
            this.dismissButton.TabIndex = 23;
            this.dismissButton.Text = "Licencier";
            this.dismissButton.UseVisualStyleBackColor = true;
            this.dismissButton.Click += new System.EventHandler(this.onDismissEmployeeButtonClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(159, 159);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(120, 20);
            this.nameTextBox.TabIndex = 16;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(36, 162);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 13);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Prénom";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTextBox.Location = new System.Drawing.Point(159, 309);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.ReadOnly = true;
            this.loginTextBox.Size = new System.Drawing.Size(120, 20);
            this.loginTextBox.TabIndex = 21;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Location = new System.Drawing.Point(159, 283);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(120, 20);
            this.emailTextBox.TabIndex = 20;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextBox.Location = new System.Drawing.Point(159, 257);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(120, 20);
            this.phoneTextBox.TabIndex = 19;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.Location = new System.Drawing.Point(159, 211);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(120, 40);
            this.addressTextBox.TabIndex = 18;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDateTextBox.Location = new System.Drawing.Point(159, 185);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.ReadOnly = true;
            this.birthDateTextBox.Size = new System.Drawing.Size(120, 20);
            this.birthDateTextBox.TabIndex = 17;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surnameTextBox.Location = new System.Drawing.Point(159, 133);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(120, 20);
            this.surnameTextBox.TabIndex = 15;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Location = new System.Drawing.Point(279, 46);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(30, 30);
            this.editButton.TabIndex = 14;
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
            this.detailsTitleBarPanel.Size = new System.Drawing.Size(312, 40);
            this.detailsTitleBarPanel.TabIndex = 9;
            // 
            // detailsTitle
            // 
            this.detailsTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailsTitle.AutoSize = true;
            this.detailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTitle.ForeColor = System.Drawing.Color.White;
            this.detailsTitle.Location = new System.Drawing.Point(104, 10);
            this.detailsTitle.Name = "detailsTitle";
            this.detailsTitle.Size = new System.Drawing.Size(113, 20);
            this.detailsTitle.TabIndex = 0;
            this.detailsTitle.Text = "Détail employé";
            // 
            // permissionButton
            // 
            this.permissionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.permissionButton.AutoSize = true;
            this.permissionButton.Location = new System.Drawing.Point(21, 357);
            this.permissionButton.Name = "permissionButton";
            this.permissionButton.Size = new System.Drawing.Size(120, 30);
            this.permissionButton.TabIndex = 22;
            this.permissionButton.Text = "Permissions";
            this.permissionButton.UseVisualStyleBackColor = true;
            this.permissionButton.Click += new System.EventHandler(this.onPermissionButtonClick);
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(36, 312);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Login";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(36, 286);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(36, 260);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(58, 13);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Téléphone";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(36, 214);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Adresse";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(36, 188);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(98, 13);
            this.birthDateLabel.TabIndex = 2;
            this.birthDateLabel.Text = "Date de Naissance";
            // 
            // surnameLabel
            // 
            this.surnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(36, 136);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(29, 13);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Nom";
            // 
            // EmployeesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "EmployeesUserControl";
            this.Controls.SetChildIndex(this.tableLayoutPanel, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.detailsTitleBarPanel.ResumeLayout(false);
            this.detailsTitleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ListView employeesListView;
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
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
