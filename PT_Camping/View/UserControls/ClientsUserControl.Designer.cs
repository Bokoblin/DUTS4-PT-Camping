namespace PT_Camping
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsUserControl));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addClientButton = new System.Windows.Forms.Button();
            this.ClientlistView = new System.Windows.Forms.ListView();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.dateInscripLabel = new System.Windows.Forms.Label();
            this.dateInscripTextBox = new System.Windows.Forms.TextBox();
            this.LiberationButton = new System.Windows.Forms.Button();
            this.FacturationButton = new System.Windows.Forms.Button();
            this.ReductionButton = new System.Windows.Forms.Button();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.resaTextBox = new System.Windows.Forms.TextBox();
            this.reservationButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.NameReservLabel = new System.Windows.Forms.Label();
            this.TitleDetailsPanel = new System.Windows.Forms.Panel();
            this.TitleDetailsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.DetailsPanel.SuspendLayout();
            this.TitleDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.addClientButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ClientlistView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DetailsPanel, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.90707F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.89591F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 538);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // addClientButton
            // 
            this.addClientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addClientButton.AutoSize = true;
            this.addClientButton.Location = new System.Drawing.Point(186, 464);
            this.addClientButton.Margin = new System.Windows.Forms.Padding(4);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(160, 27);
            this.addClientButton.TabIndex = 13;
            this.addClientButton.Text = "Nouveau client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // ClientlistView
            // 
            this.ClientlistView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientlistView.FullRowSelect = true;
            this.ClientlistView.GridLines = true;
            this.ClientlistView.Location = new System.Drawing.Point(56, 46);
            this.ClientlistView.MultiSelect = false;
            this.ClientlistView.Name = "ClientlistView";
            this.ClientlistView.Scrollable = false;
            this.ClientlistView.Size = new System.Drawing.Size(420, 397);
            this.ClientlistView.TabIndex = 12;
            this.ClientlistView.UseCompatibleStateImageBehavior = false;
            this.ClientlistView.SelectedIndexChanged += new System.EventHandler(this.employeeListView_SelectedIndexChanged);
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.AutoSize = true;
            this.DetailsPanel.BackColor = System.Drawing.Color.White;
            this.DetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailsPanel.Controls.Add(this.dateInscripLabel);
            this.DetailsPanel.Controls.Add(this.dateInscripTextBox);
            this.DetailsPanel.Controls.Add(this.LiberationButton);
            this.DetailsPanel.Controls.Add(this.FacturationButton);
            this.DetailsPanel.Controls.Add(this.ReductionButton);
            this.DetailsPanel.Controls.Add(this.surnameTextBox);
            this.DetailsPanel.Controls.Add(this.resaTextBox);
            this.DetailsPanel.Controls.Add(this.reservationButton);
            this.DetailsPanel.Controls.Add(this.deleteButton);
            this.DetailsPanel.Controls.Add(this.surnameLabel);
            this.DetailsPanel.Controls.Add(this.EditButton);
            this.DetailsPanel.Controls.Add(this.NameReservLabel);
            this.DetailsPanel.Controls.Add(this.TitleDetailsPanel);
            this.DetailsPanel.Controls.Add(this.nameLabel);
            this.DetailsPanel.Controls.Add(this.addressTextBox);
            this.DetailsPanel.Controls.Add(this.birthDateLabel);
            this.DetailsPanel.Controls.Add(this.nameTextBox);
            this.DetailsPanel.Controls.Add(this.emailTextBox);
            this.DetailsPanel.Controls.Add(this.birthDateTextBox);
            this.DetailsPanel.Controls.Add(this.addressLabel);
            this.DetailsPanel.Controls.Add(this.emailLabel);
            this.DetailsPanel.Controls.Add(this.phoneTextBox);
            this.DetailsPanel.Controls.Add(this.phoneLabel);
            this.DetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsPanel.Location = new System.Drawing.Point(589, 47);
            this.DetailsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(418, 395);
            this.DetailsPanel.TabIndex = 14;
            // 
            // dateInscripLabel
            // 
            this.dateInscripLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateInscripLabel.AutoSize = true;
            this.dateInscripLabel.Location = new System.Drawing.Point(48, 337);
            this.dateInscripLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateInscripLabel.Name = "dateInscripLabel";
            this.dateInscripLabel.Size = new System.Drawing.Size(117, 17);
            this.dateInscripLabel.TabIndex = 38;
            this.dateInscripLabel.Text = "Date d\'inscription";
            // 
            // dateInscripTextBox
            // 
            this.dateInscripTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateInscripTextBox.Location = new System.Drawing.Point(205, 337);
            this.dateInscripTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateInscripTextBox.Name = "dateInscripTextBox";
            this.dateInscripTextBox.ReadOnly = true;
            this.dateInscripTextBox.Size = new System.Drawing.Size(159, 22);
            this.dateInscripTextBox.TabIndex = 39;
            // 
            // LiberationButton
            // 
            this.LiberationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LiberationButton.Location = new System.Drawing.Point(232, 282);
            this.LiberationButton.Margin = new System.Windows.Forms.Padding(4);
            this.LiberationButton.Name = "LiberationButton";
            this.LiberationButton.Size = new System.Drawing.Size(100, 35);
            this.LiberationButton.TabIndex = 37;
            this.LiberationButton.Text = "Libérer";
            this.LiberationButton.UseVisualStyleBackColor = true;
            // 
            // FacturationButton
            // 
            this.FacturationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FacturationButton.Location = new System.Drawing.Point(91, 344);
            this.FacturationButton.Margin = new System.Windows.Forms.Padding(4);
            this.FacturationButton.Name = "FacturationButton";
            this.FacturationButton.Size = new System.Drawing.Size(100, 35);
            this.FacturationButton.TabIndex = 36;
            this.FacturationButton.Text = "Facturer";
            this.FacturationButton.UseVisualStyleBackColor = true;
            // 
            // ReductionButton
            // 
            this.ReductionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ReductionButton.Location = new System.Drawing.Point(232, 344);
            this.ReductionButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReductionButton.Name = "ReductionButton";
            this.ReductionButton.Size = new System.Drawing.Size(100, 35);
            this.ReductionButton.TabIndex = 35;
            this.ReductionButton.Text = "Réduction(s)";
            this.ReductionButton.UseVisualStyleBackColor = true;
            this.ReductionButton.Click += new System.EventHandler(this.ReducClient_Click);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.surnameTextBox.Location = new System.Drawing.Point(205, 124);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(159, 22);
            this.surnameTextBox.TabIndex = 25;
            // 
            // resaTextBox
            // 
            this.resaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resaTextBox.Location = new System.Drawing.Point(205, 373);
            this.resaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resaTextBox.Name = "resaTextBox";
            this.resaTextBox.ReadOnly = true;
            this.resaTextBox.Size = new System.Drawing.Size(159, 22);
            this.resaTextBox.TabIndex = 33;
            // 
            // reservationButton
            // 
            this.reservationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.reservationButton.Location = new System.Drawing.Point(91, 282);
            this.reservationButton.Margin = new System.Windows.Forms.Padding(4);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(100, 35);
            this.reservationButton.TabIndex = 34;
            this.reservationButton.Text = "Réserver";
            this.reservationButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(324, 56);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(40, 37);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DismissClientButton_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(48, 124);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(37, 17);
            this.surnameLabel.TabIndex = 16;
            this.surnameLabel.Text = "Nom";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.Location = new System.Drawing.Point(372, 56);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(40, 37);
            this.EditButton.TabIndex = 15;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.editClient_Click);
            // 
            // NameReservLabel
            // 
            this.NameReservLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameReservLabel.AutoSize = true;
            this.NameReservLabel.Location = new System.Drawing.Point(48, 376);
            this.NameReservLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameReservLabel.Name = "NameReservLabel";
            this.NameReservLabel.Size = new System.Drawing.Size(143, 17);
            this.NameReservLabel.TabIndex = 32;
            this.NameReservLabel.Text = "Réservation en cours";
            // 
            // TitleDetailsPanel
            // 
            this.TitleDetailsPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TitleDetailsPanel.Controls.Add(this.TitleDetailsLabel);
            this.TitleDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleDetailsPanel.Name = "TitleDetailsPanel";
            this.TitleDetailsPanel.Size = new System.Drawing.Size(416, 49);
            this.TitleDetailsPanel.TabIndex = 0;
            // 
            // TitleDetailsLabel
            // 
            this.TitleDetailsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleDetailsLabel.AutoSize = true;
            this.TitleDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleDetailsLabel.ForeColor = System.Drawing.Color.White;
            this.TitleDetailsLabel.Location = new System.Drawing.Point(139, 12);
            this.TitleDetailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleDetailsLabel.Name = "TitleDetailsLabel";
            this.TitleDetailsLabel.Size = new System.Drawing.Size(111, 25);
            this.TitleDetailsLabel.TabIndex = 0;
            this.TitleDetailsLabel.Text = "Détail client";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(48, 153);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 17);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Prénom";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addressTextBox.Location = new System.Drawing.Point(205, 213);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(159, 48);
            this.addressTextBox.TabIndex = 28;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(48, 183);
            this.birthDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(128, 17);
            this.birthDateLabel.TabIndex = 21;
            this.birthDateLabel.Text = "Date de Naissance";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTextBox.Location = new System.Drawing.Point(205, 153);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(159, 22);
            this.nameTextBox.TabIndex = 26;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailTextBox.Location = new System.Drawing.Point(205, 304);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(159, 22);
            this.emailTextBox.TabIndex = 30;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.birthDateTextBox.Location = new System.Drawing.Point(205, 183);
            this.birthDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.ReadOnly = true;
            this.birthDateTextBox.Size = new System.Drawing.Size(159, 22);
            this.birthDateTextBox.TabIndex = 27;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(48, 213);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 22;
            this.addressLabel.Text = "Adresse";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(48, 300);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 24;
            this.emailLabel.Text = "Email";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phoneTextBox.Location = new System.Drawing.Point(205, 269);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(159, 22);
            this.phoneTextBox.TabIndex = 29;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(48, 269);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(76, 17);
            this.phoneLabel.TabIndex = 23;
            this.phoneLabel.Text = "Téléphone";
            // 
            // ClientsUserControl
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ClientsUserControl";
            this.Size = new System.Drawing.Size(1067, 600);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            this.TitleDetailsPanel.ResumeLayout(false);
            this.TitleDetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.ListView ClientlistView;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Panel TitleDetailsPanel;
        private System.Windows.Forms.Label TitleDetailsLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
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
        private System.Windows.Forms.Button reservationButton;
        private System.Windows.Forms.TextBox resaTextBox;
        private System.Windows.Forms.Label NameReservLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button LiberationButton;
        private System.Windows.Forms.Button FacturationButton;
        private System.Windows.Forms.Button ReductionButton;
        private System.Windows.Forms.Label dateInscripLabel;
        private System.Windows.Forms.TextBox dateInscripTextBox;
    }
}
