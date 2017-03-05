namespace PT_Camping
{
    partial class MapUserControl
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
            this.importMapPanel = new System.Windows.Forms.Panel();
            this.importLabel = new System.Windows.Forms.Label();
            this.importMapButton = new System.Windows.Forms.Button();
            this.mapTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.modeCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.validateChangesButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.categoriesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addLocationPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.detailsLocationPanel = new System.Windows.Forms.Panel();
            this.incidentsListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.catLocationListView = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.catLocationLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.locationNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resButton = new System.Windows.Forms.Button();
            this.resStateLabel = new System.Windows.Forms.Label();
            this.ResTitleLabel = new System.Windows.Forms.Label();
            this.editLocationPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.carCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typeLocationComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.locationNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.importMapPanel.SuspendLayout();
            this.mapTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.detailsLocationPanel.SuspendLayout();
            this.editLocationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // importMapPanel
            // 
            this.importMapPanel.Controls.Add(this.importLabel);
            this.importMapPanel.Controls.Add(this.importMapButton);
            this.importMapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importMapPanel.Location = new System.Drawing.Point(0, 0);
            this.importMapPanel.Margin = new System.Windows.Forms.Padding(2);
            this.importMapPanel.Name = "importMapPanel";
            this.importMapPanel.Size = new System.Drawing.Size(804, 523);
            this.importMapPanel.TabIndex = 0;
            this.importMapPanel.Visible = false;
            // 
            // importLabel
            // 
            this.importLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importLabel.AutoSize = true;
            this.importLabel.Location = new System.Drawing.Point(220, 193);
            this.importLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.importLabel.Name = "importLabel";
            this.importLabel.Size = new System.Drawing.Size(342, 13);
            this.importLabel.TabIndex = 1;
            this.importLabel.Text = "Aucune carte n\'a été trouvé pour ce camping. Veuillez en importer une.";
            // 
            // importMapButton
            // 
            this.importMapButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importMapButton.Location = new System.Drawing.Point(319, 283);
            this.importMapButton.Margin = new System.Windows.Forms.Padding(2);
            this.importMapButton.Name = "importMapButton";
            this.importMapButton.Size = new System.Drawing.Size(142, 43);
            this.importMapButton.TabIndex = 0;
            this.importMapButton.Text = "Importer une carte";
            this.importMapButton.UseVisualStyleBackColor = true;
            this.importMapButton.Click += new System.EventHandler(this.importMapButton_Click);
            // 
            // mapTablePanel
            // 
            this.mapTablePanel.ColumnCount = 3;
            this.mapTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mapTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.mapTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.mapTablePanel.Controls.Add(this.modeCheckBox, 0, 0);
            this.mapTablePanel.Controls.Add(this.dateTimePicker, 1, 0);
            this.mapTablePanel.Controls.Add(this.validateChangesButton, 2, 0);
            this.mapTablePanel.Controls.Add(this.pictureBox, 1, 1);
            this.mapTablePanel.Controls.Add(this.leftPanel, 0, 1);
            this.mapTablePanel.Controls.Add(this.panel1, 2, 1);
            this.mapTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapTablePanel.Location = new System.Drawing.Point(0, 0);
            this.mapTablePanel.Margin = new System.Windows.Forms.Padding(2);
            this.mapTablePanel.Name = "mapTablePanel";
            this.mapTablePanel.RowCount = 2;
            this.mapTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.590064F));
            this.mapTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.40993F));
            this.mapTablePanel.Size = new System.Drawing.Size(804, 523);
            this.mapTablePanel.TabIndex = 1;
            this.mapTablePanel.Visible = false;
            // 
            // modeCheckBox
            // 
            this.modeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modeCheckBox.AutoSize = true;
            this.modeCheckBox.Location = new System.Drawing.Point(31, 6);
            this.modeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.modeCheckBox.Name = "modeCheckBox";
            this.modeCheckBox.Size = new System.Drawing.Size(88, 17);
            this.modeCheckBox.TabIndex = 0;
            this.modeCheckBox.Text = "Mode Edition";
            this.modeCheckBox.UseVisualStyleBackColor = true;
            this.modeCheckBox.CheckedChanged += new System.EventHandler(this.modeCheckBox_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Location = new System.Drawing.Point(298, 4);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // validateChangesButton
            // 
            this.validateChangesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validateChangesButton.Location = new System.Drawing.Point(676, 5);
            this.validateChangesButton.Margin = new System.Windows.Forms.Padding(2);
            this.validateChangesButton.Name = "validateChangesButton";
            this.validateChangesButton.Size = new System.Drawing.Size(56, 19);
            this.validateChangesButton.TabIndex = 3;
            this.validateChangesButton.Text = "Valider";
            this.validateChangesButton.UseVisualStyleBackColor = true;
            this.validateChangesButton.Click += new System.EventHandler(this.validateChangesButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(153, 31);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(449, 490);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.categoriesCheckedListBox);
            this.leftPanel.Controls.Add(this.addLocationPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(2, 31);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(147, 490);
            this.leftPanel.TabIndex = 6;
            // 
            // categoriesCheckedListBox
            // 
            this.categoriesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesCheckedListBox.FormattingEnabled = true;
            this.categoriesCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.categoriesCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoriesCheckedListBox.Name = "categoriesCheckedListBox";
            this.categoriesCheckedListBox.Size = new System.Drawing.Size(147, 490);
            this.categoriesCheckedListBox.TabIndex = 1;
            this.categoriesCheckedListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.categoriesCheckedListBox_MouseUp);
            // 
            // addLocationPanel
            // 
            this.addLocationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addLocationPanel.Location = new System.Drawing.Point(0, 0);
            this.addLocationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addLocationPanel.Name = "addLocationPanel";
            this.addLocationPanel.Size = new System.Drawing.Size(147, 490);
            this.addLocationPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.detailsLocationPanel);
            this.panel1.Controls.Add(this.editLocationPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(606, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 490);
            this.panel1.TabIndex = 7;
            // 
            // detailsLocationPanel
            // 
            this.detailsLocationPanel.Controls.Add(this.incidentsListBox);
            this.detailsLocationPanel.Controls.Add(this.label7);
            this.detailsLocationPanel.Controls.Add(this.catLocationListView);
            this.detailsLocationPanel.Controls.Add(this.label6);
            this.detailsLocationPanel.Controls.Add(this.catLocationLabel);
            this.detailsLocationPanel.Controls.Add(this.label5);
            this.detailsLocationPanel.Controls.Add(this.locationNameLabel);
            this.detailsLocationPanel.Controls.Add(this.label4);
            this.detailsLocationPanel.Controls.Add(this.resButton);
            this.detailsLocationPanel.Controls.Add(this.resStateLabel);
            this.detailsLocationPanel.Controls.Add(this.ResTitleLabel);
            this.detailsLocationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsLocationPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsLocationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.detailsLocationPanel.Name = "detailsLocationPanel";
            this.detailsLocationPanel.Size = new System.Drawing.Size(196, 490);
            this.detailsLocationPanel.TabIndex = 5;
            this.detailsLocationPanel.Visible = false;
            // 
            // incidentsListBox
            // 
            this.incidentsListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.incidentsListBox.FormattingEnabled = true;
            this.incidentsListBox.Location = new System.Drawing.Point(11, 296);
            this.incidentsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.incidentsListBox.Name = "incidentsListBox";
            this.incidentsListBox.Size = new System.Drawing.Size(163, 69);
            this.incidentsListBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Incidents en cours :";
            // 
            // catLocationListView
            // 
            this.catLocationListView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.catLocationListView.Location = new System.Drawing.Point(11, 180);
            this.catLocationListView.Margin = new System.Windows.Forms.Padding(2);
            this.catLocationListView.Name = "catLocationListView";
            this.catLocationListView.Size = new System.Drawing.Size(165, 93);
            this.catLocationListView.TabIndex = 9;
            this.catLocationListView.UseCompatibleStateImageBehavior = false;
            this.catLocationListView.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Caractéristiques de l\'emplacement :";
            // 
            // catLocationLabel
            // 
            this.catLocationLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.catLocationLabel.AutoSize = true;
            this.catLocationLabel.Location = new System.Drawing.Point(9, 137);
            this.catLocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.catLocationLabel.Name = "catLocationLabel";
            this.catLocationLabel.Size = new System.Drawing.Size(63, 13);
            this.catLocationLabel.TabIndex = 7;
            this.catLocationLabel.Text = "catLocation";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Catégorie de l\'emplacement :";
            // 
            // locationNameLabel
            // 
            this.locationNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locationNameLabel.AutoSize = true;
            this.locationNameLabel.Location = new System.Drawing.Point(9, 90);
            this.locationNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationNameLabel.Name = "locationNameLabel";
            this.locationNameLabel.Size = new System.Drawing.Size(72, 13);
            this.locationNameLabel.TabIndex = 5;
            this.locationNameLabel.Text = "locationName";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom de l\'emplacement :";
            // 
            // resButton
            // 
            this.resButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resButton.Location = new System.Drawing.Point(70, 42);
            this.resButton.Margin = new System.Windows.Forms.Padding(2);
            this.resButton.Name = "resButton";
            this.resButton.Size = new System.Drawing.Size(56, 19);
            this.resButton.TabIndex = 2;
            this.resButton.Text = "Réserver";
            this.resButton.UseVisualStyleBackColor = true;
            // 
            // resStateLabel
            // 
            this.resStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resStateLabel.AutoSize = true;
            this.resStateLabel.Location = new System.Drawing.Point(9, 26);
            this.resStateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resStateLabel.Name = "resStateLabel";
            this.resStateLabel.Size = new System.Drawing.Size(46, 13);
            this.resStateLabel.TabIndex = 1;
            this.resStateLabel.Text = "resState";
            // 
            // ResTitleLabel
            // 
            this.ResTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResTitleLabel.AutoSize = true;
            this.ResTitleLabel.Location = new System.Drawing.Point(9, 11);
            this.ResTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResTitleLabel.Name = "ResTitleLabel";
            this.ResTitleLabel.Size = new System.Drawing.Size(110, 13);
            this.ResTitleLabel.TabIndex = 0;
            this.ResTitleLabel.Text = "Etat de la réservation:";
            // 
            // editLocationPanel
            // 
            this.editLocationPanel.Controls.Add(this.deleteButton);
            this.editLocationPanel.Controls.Add(this.carCheckedListBox);
            this.editLocationPanel.Controls.Add(this.label3);
            this.editLocationPanel.Controls.Add(this.typeLocationComboBox);
            this.editLocationPanel.Controls.Add(this.label2);
            this.editLocationPanel.Controls.Add(this.locationNameTextBox);
            this.editLocationPanel.Controls.Add(this.label1);
            this.editLocationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editLocationPanel.Location = new System.Drawing.Point(0, 0);
            this.editLocationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.editLocationPanel.Name = "editLocationPanel";
            this.editLocationPanel.Size = new System.Drawing.Size(196, 490);
            this.editLocationPanel.TabIndex = 3;
            this.editLocationPanel.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(69, 464);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // carCheckedListBox
            // 
            this.carCheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.carCheckedListBox.FormattingEnabled = true;
            this.carCheckedListBox.Location = new System.Drawing.Point(17, 138);
            this.carCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.carCheckedListBox.Name = "carCheckedListBox";
            this.carCheckedListBox.Size = new System.Drawing.Size(157, 124);
            this.carCheckedListBox.TabIndex = 5;
            this.carCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.carCheckedListBox_Check);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Caractéristiques emplacement :";
            // 
            // typeLocationComboBox
            // 
            this.typeLocationComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.typeLocationComboBox.FormattingEnabled = true;
            this.typeLocationComboBox.Location = new System.Drawing.Point(15, 76);
            this.typeLocationComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeLocationComboBox.Name = "typeLocationComboBox";
            this.typeLocationComboBox.Size = new System.Drawing.Size(118, 21);
            this.typeLocationComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type de l\'emplacement :";
            // 
            // locationNameTextBox
            // 
            this.locationNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locationNameTextBox.Location = new System.Drawing.Point(15, 31);
            this.locationNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.locationNameTextBox.Name = "locationNameTextBox";
            this.locationNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.locationNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de l\'emplacement :";
            // 
            // MapUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.mapTablePanel);
            this.Controls.Add(this.importMapPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MapUserControl";
            this.Size = new System.Drawing.Size(804, 523);
            this.importMapPanel.ResumeLayout(false);
            this.importMapPanel.PerformLayout();
            this.mapTablePanel.ResumeLayout(false);
            this.mapTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.detailsLocationPanel.ResumeLayout(false);
            this.detailsLocationPanel.PerformLayout();
            this.editLocationPanel.ResumeLayout(false);
            this.editLocationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel importMapPanel;
        private System.Windows.Forms.Button importMapButton;
        private System.Windows.Forms.Label importLabel;
        private System.Windows.Forms.TableLayoutPanel mapTablePanel;
        private System.Windows.Forms.CheckBox modeCheckBox;
        private System.Windows.Forms.CheckedListBox categoriesCheckedListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button validateChangesButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel detailsLocationPanel;
        private System.Windows.Forms.Label resStateLabel;
        private System.Windows.Forms.Label ResTitleLabel;
        private System.Windows.Forms.Button resButton;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel editLocationPanel;
        private System.Windows.Forms.TextBox locationNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeLocationComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox carCheckedListBox;
        private System.Windows.Forms.Label locationNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label catLocationLabel;
        private System.Windows.Forms.ListView catLocationListView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox incidentsListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel addLocationPanel;
        private System.Windows.Forms.Button deleteButton;
    }
}
