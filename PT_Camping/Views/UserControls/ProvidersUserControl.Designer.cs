namespace PT_Camping.Views.UserControls
{
    partial class ProvidersUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.providerListView = new System.Windows.Forms.ListView();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.websiteLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.detailTitlePanel = new System.Windows.Forms.Panel();
            this.detailTitleLabel = new System.Windows.Forms.Label();
            this.addProviderButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.detailTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.providerListView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.detailPanel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.addProviderButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 550);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // providerListView
            // 
            this.providerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.providerListView.FullRowSelect = true;
            this.providerListView.GridLines = true;
            this.providerListView.Location = new System.Drawing.Point(52, 47);
            this.providerListView.Name = "providerListView";
            this.providerListView.Scrollable = false;
            this.providerListView.Size = new System.Drawing.Size(387, 390);
            this.providerListView.TabIndex = 0;
            this.providerListView.UseCompatibleStateImageBehavior = false;
            this.providerListView.SelectedIndexChanged += new System.EventHandler(this.ProviderListView_SelectedIndexChanged);
            this.providerListView.Resize += new System.EventHandler(this.ProviderListView_Resize);
            // 
            // detailPanel
            // 
            this.detailPanel.BackColor = System.Drawing.Color.White;
            this.detailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailPanel.Controls.Add(this.resetButton);
            this.detailPanel.Controls.Add(this.addressTextBox);
            this.detailPanel.Controls.Add(this.contactButton);
            this.detailPanel.Controls.Add(this.emailTextBox);
            this.detailPanel.Controls.Add(this.websiteTextBox);
            this.detailPanel.Controls.Add(this.nameTextBox);
            this.detailPanel.Controls.Add(this.websiteLabel);
            this.detailPanel.Controls.Add(this.emailLabel);
            this.detailPanel.Controls.Add(this.addressLabel);
            this.detailPanel.Controls.Add(this.nameLabel);
            this.detailPanel.Controls.Add(this.editButton);
            this.detailPanel.Controls.Add(this.deleteButton);
            this.detailPanel.Controls.Add(this.detailTitlePanel);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailPanel.Location = new System.Drawing.Point(543, 47);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(387, 390);
            this.detailPanel.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_undo;
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Location = new System.Drawing.Point(279, 46);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(30, 30);
            this.resetButton.TabIndex = 25;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.Location = new System.Drawing.Point(196, 157);
            this.addressTextBox.MaxLength = 50;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.ShortcutsEnabled = false;
            this.addressTextBox.Size = new System.Drawing.Size(120, 40);
            this.addressTextBox.TabIndex = 22;
            // 
            // contactButton
            // 
            this.contactButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactButton.AutoSize = true;
            this.contactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactButton.Location = new System.Drawing.Point(130, 342);
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(130, 30);
            this.contactButton.TabIndex = 21;
            this.contactButton.Text = "Contacter";
            this.contactButton.UseVisualStyleBackColor = true;
            this.contactButton.Click += new System.EventHandler(this.ContactButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Location = new System.Drawing.Point(196, 203);
            this.emailTextBox.MaxLength = 30;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.ShortcutsEnabled = false;
            this.emailTextBox.Size = new System.Drawing.Size(120, 20);
            this.emailTextBox.TabIndex = 20;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.websiteTextBox.Location = new System.Drawing.Point(196, 229);
            this.websiteTextBox.MaxLength = 50;
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.ReadOnly = true;
            this.websiteTextBox.ShortcutsEnabled = false;
            this.websiteTextBox.Size = new System.Drawing.Size(120, 20);
            this.websiteTextBox.TabIndex = 19;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(196, 128);
            this.nameTextBox.MaxLength = 25;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.ShortcutsEnabled = false;
            this.nameTextBox.Size = new System.Drawing.Size(120, 20);
            this.nameTextBox.TabIndex = 17;
            // 
            // websiteLabel
            // 
            this.websiteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.Location = new System.Drawing.Point(64, 232);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(120, 13);
            this.websiteLabel.TabIndex = 16;
            this.websiteLabel.Text = "Site Web du fournisseur";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(64, 206);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(104, 13);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "E-mail du fournisseur";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(64, 160);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(114, 13);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Adresse du fournisseur";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(64, 131);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 13);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Nom du fournisseur";
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_edit;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Location = new System.Drawing.Point(351, 46);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(30, 30);
            this.editButton.TabIndex = 12;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_delete;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Location = new System.Drawing.Point(315, 46);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(30, 30);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // detailTitlePanel
            // 
            this.detailTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.detailTitlePanel.Controls.Add(this.detailTitleLabel);
            this.detailTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.detailTitlePanel.Name = "detailTitlePanel";
            this.detailTitlePanel.Size = new System.Drawing.Size(385, 40);
            this.detailTitlePanel.TabIndex = 0;
            // 
            // detailTitleLabel
            // 
            this.detailTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailTitleLabel.AutoSize = true;
            this.detailTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.detailTitleLabel.ForeColor = System.Drawing.Color.White;
            this.detailTitleLabel.Location = new System.Drawing.Point(115, 10);
            this.detailTitleLabel.Name = "detailTitleLabel";
            this.detailTitleLabel.Size = new System.Drawing.Size(149, 20);
            this.detailTitleLabel.TabIndex = 0;
            this.detailTitleLabel.Text = "Détails fournisseurs";
            // 
            // addProviderButton
            // 
            this.addProviderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProviderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProviderButton.Location = new System.Drawing.Point(185, 461);
            this.addProviderButton.Name = "addProviderButton";
            this.addProviderButton.Size = new System.Drawing.Size(120, 40);
            this.addProviderButton.TabIndex = 2;
            this.addProviderButton.Text = "Nouveau founisseur";
            this.addProviderButton.UseVisualStyleBackColor = true;
            this.addProviderButton.Click += new System.EventHandler(this.AddProvider_Click);
            // 
            // ProvidersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProvidersUserControl";
            this.Size = new System.Drawing.Size(984, 600);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.detailTitlePanel.ResumeLayout(false);
            this.detailTitlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView providerListView;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Panel detailTitlePanel;
        private System.Windows.Forms.Label detailTitleLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label websiteLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox websiteTextBox;
        private System.Windows.Forms.Button contactButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button addProviderButton;
        private System.Windows.Forms.Button resetButton;
    }
}
