namespace PT_Camping.Views.UserControls
{
    partial class ClientsUserControl
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addClientButton = new System.Windows.Forms.Button();
            this.clientListView = new System.Windows.Forms.ListView();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.reservationButton = new System.Windows.Forms.Button();
            this.currentReservationsComboBox = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.dateInscripLabel = new System.Windows.Forms.Label();
            this.dateInscripTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.currentReservationsLabel = new System.Windows.Forms.Label();
            this.detailsTitlePanel = new System.Windows.Forms.Panel();
            this.detailsTitleLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.reductionButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.detailsTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Controls.Add(this.addClientButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.clientListView, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.detailsPanel, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.reductionButton, 3, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1200, 676);
            this.tableLayoutPanel.TabIndex = 11;
            // 
            // addClientButton
            // 
            this.addClientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addClientButton.AutoSize = true;
            this.addClientButton.Location = new System.Drawing.Point(220, 569);
            this.addClientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(160, 43);
            this.addClientButton.TabIndex = 13;
            this.addClientButton.Text = "Nouveau client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // clientListView
            // 
            this.clientListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientListView.FullRowSelect = true;
            this.clientListView.GridLines = true;
            this.clientListView.HideSelection = false;
            this.clientListView.Location = new System.Drawing.Point(63, 56);
            this.clientListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientListView.MultiSelect = false;
            this.clientListView.Name = "clientListView";
            this.clientListView.Scrollable = false;
            this.clientListView.Size = new System.Drawing.Size(474, 482);
            this.clientListView.TabIndex = 12;
            this.clientListView.UseCompatibleStateImageBehavior = false;
            this.clientListView.SelectedIndexChanged += new System.EventHandler(this.EmployeeListView_SelectedIndexChanged);
            this.clientListView.Resize += new System.EventHandler(this.ClientlistView_Resize);
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoSize = true;
            this.detailsPanel.BackColor = System.Drawing.Color.White;
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.button1);
            this.detailsPanel.Controls.Add(this.reservationButton);
            this.detailsPanel.Controls.Add(this.currentReservationsComboBox);
            this.detailsPanel.Controls.Add(this.resetButton);
            this.detailsPanel.Controls.Add(this.dateInscripLabel);
            this.detailsPanel.Controls.Add(this.dateInscripTextBox);
            this.detailsPanel.Controls.Add(this.surnameTextBox);
            this.detailsPanel.Controls.Add(this.deleteButton);
            this.detailsPanel.Controls.Add(this.surnameLabel);
            this.detailsPanel.Controls.Add(this.editButton);
            this.detailsPanel.Controls.Add(this.currentReservationsLabel);
            this.detailsPanel.Controls.Add(this.detailsTitlePanel);
            this.detailsPanel.Controls.Add(this.firstNameLabel);
            this.detailsPanel.Controls.Add(this.addressTextBox);
            this.detailsPanel.Controls.Add(this.birthDateLabel);
            this.detailsPanel.Controls.Add(this.nameTextBox);
            this.detailsPanel.Controls.Add(this.emailTextBox);
            this.detailsPanel.Controls.Add(this.birthDateTextBox);
            this.detailsPanel.Controls.Add(this.addressLabel);
            this.detailsPanel.Controls.Add(this.emailLabel);
            this.detailsPanel.Controls.Add(this.phoneTextBox);
            this.detailsPanel.Controls.Add(this.phoneLabel);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(664, 58);
            this.detailsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(472, 478);
            this.detailsPanel.TabIndex = 14;
            // 
            // reservationButton
            // 
            this.reservationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reservationButton.Location = new System.Drawing.Point(165, 422);
            this.reservationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(160, 37);
            this.reservationButton.TabIndex = 42;
            this.reservationButton.Text = "Réservations";
            this.reservationButton.UseVisualStyleBackColor = true;
            this.reservationButton.Click += new System.EventHandler(this.ReservationsButton_Click);
            // 
            // currentReservationsComboBox
            // 
            this.currentReservationsComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentReservationsComboBox.FormattingEnabled = true;
            this.currentReservationsComboBox.Location = new System.Drawing.Point(233, 368);
            this.currentReservationsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentReservationsComboBox.Name = "currentReservationsComboBox";
            this.currentReservationsComboBox.Size = new System.Drawing.Size(159, 24);
            this.currentReservationsComboBox.TabIndex = 41;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_undo;
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.Location = new System.Drawing.Point(330, 55);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(40, 37);
            this.resetButton.TabIndex = 40;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // dateInscripLabel
            // 
            this.dateInscripLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateInscripLabel.AutoSize = true;
            this.dateInscripLabel.Location = new System.Drawing.Point(76, 340);
            this.dateInscripLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateInscripLabel.Name = "dateInscripLabel";
            this.dateInscripLabel.Size = new System.Drawing.Size(117, 17);
            this.dateInscripLabel.TabIndex = 38;
            this.dateInscripLabel.Text = "Date d\'inscription";
            // 
            // dateInscripTextBox
            // 
            this.dateInscripTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateInscripTextBox.Location = new System.Drawing.Point(233, 336);
            this.dateInscripTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateInscripTextBox.Name = "dateInscripTextBox";
            this.dateInscripTextBox.ReadOnly = true;
            this.dateInscripTextBox.Size = new System.Drawing.Size(159, 22);
            this.dateInscripTextBox.TabIndex = 39;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surnameTextBox.Location = new System.Drawing.Point(233, 123);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(159, 22);
            this.surnameTextBox.TabIndex = 25;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_delete;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(378, 55);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(40, 37);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteClientButton_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(76, 123);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(37, 17);
            this.surnameLabel.TabIndex = 16;
            this.surnameLabel.Text = "Nom";
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_edit;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Location = new System.Drawing.Point(426, 55);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 37);
            this.editButton.TabIndex = 15;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // currentReservationsLabel
            // 
            this.currentReservationsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentReservationsLabel.AutoSize = true;
            this.currentReservationsLabel.Location = new System.Drawing.Point(76, 372);
            this.currentReservationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentReservationsLabel.Name = "currentReservationsLabel";
            this.currentReservationsLabel.Size = new System.Drawing.Size(150, 17);
            this.currentReservationsLabel.TabIndex = 32;
            this.currentReservationsLabel.Text = "Réservations en cours";
            // 
            // detailsTitlePanel
            // 
            this.detailsTitlePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.detailsTitlePanel.Controls.Add(this.detailsTitleLabel);
            this.detailsTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.detailsTitlePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailsTitlePanel.Name = "detailsTitlePanel";
            this.detailsTitlePanel.Size = new System.Drawing.Size(470, 49);
            this.detailsTitlePanel.TabIndex = 0;
            // 
            // detailsTitleLabel
            // 
            this.detailsTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailsTitleLabel.AutoSize = true;
            this.detailsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTitleLabel.ForeColor = System.Drawing.Color.White;
            this.detailsTitleLabel.Location = new System.Drawing.Point(173, 12);
            this.detailsTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailsTitleLabel.Name = "detailsTitleLabel";
            this.detailsTitleLabel.Size = new System.Drawing.Size(111, 25);
            this.detailsTitleLabel.TabIndex = 0;
            this.detailsTitleLabel.Text = "Détail client";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(76, 152);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 17);
            this.firstNameLabel.TabIndex = 20;
            this.firstNameLabel.Text = "Prénom";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.Location = new System.Drawing.Point(233, 212);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(159, 48);
            this.addressTextBox.TabIndex = 28;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(76, 186);
            this.birthDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(128, 17);
            this.birthDateLabel.TabIndex = 21;
            this.birthDateLabel.Text = "Date de Naissance";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(233, 152);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(159, 22);
            this.nameTextBox.TabIndex = 26;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Location = new System.Drawing.Point(233, 303);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(159, 22);
            this.emailTextBox.TabIndex = 30;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDateTextBox.Location = new System.Drawing.Point(233, 182);
            this.birthDateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.ReadOnly = true;
            this.birthDateTextBox.Size = new System.Drawing.Size(159, 22);
            this.birthDateTextBox.TabIndex = 27;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(76, 216);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 22;
            this.addressLabel.Text = "Adresse";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(76, 307);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 24;
            this.emailLabel.Text = "Email";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextBox.Location = new System.Drawing.Point(233, 269);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(159, 22);
            this.phoneTextBox.TabIndex = 29;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextBox_KeyPress);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(76, 272);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(76, 17);
            this.phoneLabel.TabIndex = 23;
            this.phoneLabel.Text = "Téléphone";
            // 
            // reductionButton
            // 
            this.reductionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reductionButton.Location = new System.Drawing.Point(779, 573);
            this.reductionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reductionButton.Name = "reductionButton";
            this.reductionButton.Size = new System.Drawing.Size(241, 34);
            this.reductionButton.TabIndex = 35;
            this.reductionButton.Text = "TEMP reduction button";
            this.reductionButton.UseVisualStyleBackColor = true;
            this.reductionButton.Click += new System.EventHandler(this.ReducClient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Facture_generate);
            // 
            // ClientsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ClientsUserControl";
            this.Controls.SetChildIndex(this.tableLayoutPanel, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.detailsTitlePanel.ResumeLayout(false);
            this.detailsTitlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.ListView clientListView;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Panel detailsTitlePanel;
        private System.Windows.Forms.Label detailsTitleLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label currentReservationsLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button reductionButton;
        private System.Windows.Forms.Label dateInscripLabel;
        private System.Windows.Forms.TextBox dateInscripTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox currentReservationsComboBox;
        private System.Windows.Forms.Button reservationButton;
        private System.Windows.Forms.Button button1;
    }
}
