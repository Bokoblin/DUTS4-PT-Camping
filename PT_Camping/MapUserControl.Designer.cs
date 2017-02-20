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
            this.components = new System.ComponentModel.Container();
            this.importMapPanel = new System.Windows.Forms.Panel();
            this.importLabel = new System.Windows.Forms.Label();
            this.importMapButton = new System.Windows.Forms.Button();
            this.mapTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.modeCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.validateChangesButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.resButton = new System.Windows.Forms.Button();
            this.resStateLabel = new System.Windows.Forms.Label();
            this.ResTitleLabel = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.addItemList = new System.Windows.Forms.ListView();
            this.categoriesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.editLocationPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.locationNameTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.typeLocationComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.importMapPanel.SuspendLayout();
            this.mapTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.detailsPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.editLocationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // importMapPanel
            // 
            this.importMapPanel.Controls.Add(this.importLabel);
            this.importMapPanel.Controls.Add(this.importMapButton);
            this.importMapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importMapPanel.Location = new System.Drawing.Point(0, 0);
            this.importMapPanel.Name = "importMapPanel";
            this.importMapPanel.Size = new System.Drawing.Size(1072, 644);
            this.importMapPanel.TabIndex = 0;
            this.importMapPanel.Visible = false;
            // 
            // importLabel
            // 
            this.importLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importLabel.AutoSize = true;
            this.importLabel.Location = new System.Drawing.Point(293, 238);
            this.importLabel.Name = "importLabel";
            this.importLabel.Size = new System.Drawing.Size(457, 17);
            this.importLabel.TabIndex = 1;
            this.importLabel.Text = "Aucune carte n\'a été trouvé pour ce camping. Veuillez en importer une.";
            // 
            // importMapButton
            // 
            this.importMapButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importMapButton.Location = new System.Drawing.Point(425, 348);
            this.importMapButton.Name = "importMapButton";
            this.importMapButton.Size = new System.Drawing.Size(189, 53);
            this.importMapButton.TabIndex = 0;
            this.importMapButton.Text = "Importer une carte";
            this.importMapButton.UseVisualStyleBackColor = true;
            this.importMapButton.Click += new System.EventHandler(this.importMapButton_Click);
            // 
            // mapTablePanel
            // 
            this.mapTablePanel.ColumnCount = 3;
            this.mapTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.538F));
            this.mapTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.46201F));
            this.mapTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.mapTablePanel.Controls.Add(this.modeCheckBox, 0, 0);
            this.mapTablePanel.Controls.Add(this.dateTimePicker, 1, 0);
            this.mapTablePanel.Controls.Add(this.validateChangesButton, 2, 0);
            this.mapTablePanel.Controls.Add(this.pictureBox, 1, 1);
            this.mapTablePanel.Controls.Add(this.detailsPanel, 2, 1);
            this.mapTablePanel.Controls.Add(this.leftPanel, 0, 1);
            this.mapTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapTablePanel.Location = new System.Drawing.Point(0, 0);
            this.mapTablePanel.Name = "mapTablePanel";
            this.mapTablePanel.RowCount = 2;
            this.mapTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.18012F));
            this.mapTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.81988F));
            this.mapTablePanel.Size = new System.Drawing.Size(1072, 644);
            this.mapTablePanel.TabIndex = 1;
            this.mapTablePanel.Visible = false;
            // 
            // modeCheckBox
            // 
            this.modeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modeCheckBox.AutoSize = true;
            this.modeCheckBox.Location = new System.Drawing.Point(53, 25);
            this.modeCheckBox.Name = "modeCheckBox";
            this.modeCheckBox.Size = new System.Drawing.Size(112, 21);
            this.modeCheckBox.TabIndex = 0;
            this.modeCheckBox.Text = "Mode Edition";
            this.modeCheckBox.UseVisualStyleBackColor = true;
            this.modeCheckBox.CheckedChanged += new System.EventHandler(this.modeCheckBox_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Location = new System.Drawing.Point(420, 24);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 2;
            // 
            // validateChangesButton
            // 
            this.validateChangesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validateChangesButton.Location = new System.Drawing.Point(910, 24);
            this.validateChangesButton.Name = "validateChangesButton";
            this.validateChangesButton.Size = new System.Drawing.Size(75, 23);
            this.validateChangesButton.TabIndex = 3;
            this.validateChangesButton.Text = "Valider";
            this.validateChangesButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(221, 74);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(599, 567);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.label5);
            this.detailsPanel.Controls.Add(this.editLocationPanel);
            this.detailsPanel.Controls.Add(this.resButton);
            this.detailsPanel.Controls.Add(this.resStateLabel);
            this.detailsPanel.Controls.Add(this.ResTitleLabel);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(826, 74);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(243, 567);
            this.detailsPanel.TabIndex = 5;
            // 
            // resButton
            // 
            this.resButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resButton.Location = new System.Drawing.Point(84, 58);
            this.resButton.Name = "resButton";
            this.resButton.Size = new System.Drawing.Size(75, 23);
            this.resButton.TabIndex = 2;
            this.resButton.Text = "Réserver";
            this.resButton.UseVisualStyleBackColor = true;
            // 
            // resStateLabel
            // 
            this.resStateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resStateLabel.AutoSize = true;
            this.resStateLabel.Location = new System.Drawing.Point(100, 25);
            this.resStateLabel.Name = "resStateLabel";
            this.resStateLabel.Size = new System.Drawing.Size(0, 17);
            this.resStateLabel.TabIndex = 1;
            // 
            // ResTitleLabel
            // 
            this.ResTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResTitleLabel.AutoSize = true;
            this.ResTitleLabel.Location = new System.Drawing.Point(48, 11);
            this.ResTitleLabel.Name = "ResTitleLabel";
            this.ResTitleLabel.Size = new System.Drawing.Size(147, 17);
            this.ResTitleLabel.TabIndex = 0;
            this.ResTitleLabel.Text = "Etat de la réservation:";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.addItemList);
            this.leftPanel.Controls.Add(this.categoriesCheckedListBox);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 74);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(212, 567);
            this.leftPanel.TabIndex = 6;
            // 
            // addItemList
            // 
            this.addItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItemList.Location = new System.Drawing.Point(0, 0);
            this.addItemList.Name = "addItemList";
            this.addItemList.Size = new System.Drawing.Size(212, 567);
            this.addItemList.TabIndex = 2;
            this.addItemList.UseCompatibleStateImageBehavior = false;
            // 
            // categoriesCheckedListBox
            // 
            this.categoriesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesCheckedListBox.FormattingEnabled = true;
            this.categoriesCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.categoriesCheckedListBox.Name = "categoriesCheckedListBox";
            this.categoriesCheckedListBox.Size = new System.Drawing.Size(212, 567);
            this.categoriesCheckedListBox.TabIndex = 1;
            // 
            // editLocationPanel
            // 
            this.editLocationPanel.Controls.Add(this.label4);
            this.editLocationPanel.Controls.Add(this.checkedListBox1);
            this.editLocationPanel.Controls.Add(this.label3);
            this.editLocationPanel.Controls.Add(this.typeLocationComboBox);
            this.editLocationPanel.Controls.Add(this.label2);
            this.editLocationPanel.Controls.Add(this.locationNameTextBox);
            this.editLocationPanel.Controls.Add(this.label1);
            this.editLocationPanel.Location = new System.Drawing.Point(13, 515);
            this.editLocationPanel.Name = "editLocationPanel";
            this.editLocationPanel.Size = new System.Drawing.Size(200, 28);
            this.editLocationPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-17, -210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de l\'emplacement :";
            // 
            // locationNameTextBox
            // 
            this.locationNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationNameTextBox.Location = new System.Drawing.Point(-14, -189);
            this.locationNameTextBox.Name = "locationNameTextBox";
            this.locationNameTextBox.Size = new System.Drawing.Size(156, 22);
            this.locationNameTextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-17, -140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type de l\'emplacement :";
            // 
            // typeLocationComboBox
            // 
            this.typeLocationComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLocationComboBox.FormattingEnabled = true;
            this.typeLocationComboBox.Location = new System.Drawing.Point(-14, -119);
            this.typeLocationComboBox.Name = "typeLocationComboBox";
            this.typeLocationComboBox.Size = new System.Drawing.Size(156, 24);
            this.typeLocationComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-14, -62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Caractéristiques emplacement :";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(-11, -30);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(203, 123);
            this.checkedListBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nom de l\'emplacement :";
            // 
            // MapUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.mapTablePanel);
            this.Controls.Add(this.importMapPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MapUserControl";
            this.Size = new System.Drawing.Size(1072, 644);
            this.importMapPanel.ResumeLayout(false);
            this.importMapPanel.PerformLayout();
            this.mapTablePanel.ResumeLayout(false);
            this.mapTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label resStateLabel;
        private System.Windows.Forms.Label ResTitleLabel;
        private System.Windows.Forms.Button resButton;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ListView addItemList;
        private System.Windows.Forms.Panel editLocationPanel;
        private System.Windows.Forms.TextBox locationNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeLocationComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
