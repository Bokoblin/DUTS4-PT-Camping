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
            this.categoriesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.validateChangesButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.importMapPanel.SuspendLayout();
            this.mapTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.mapTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.mapTablePanel.Controls.Add(this.modeCheckBox, 0, 0);
            this.mapTablePanel.Controls.Add(this.categoriesCheckedListBox, 0, 1);
            this.mapTablePanel.Controls.Add(this.dateTimePicker, 1, 0);
            this.mapTablePanel.Controls.Add(this.validateChangesButton, 2, 0);
            this.mapTablePanel.Controls.Add(this.pictureBox, 1, 1);
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
            this.modeCheckBox.Location = new System.Drawing.Point(54, 25);
            this.modeCheckBox.Name = "modeCheckBox";
            this.modeCheckBox.Size = new System.Drawing.Size(112, 21);
            this.modeCheckBox.TabIndex = 0;
            this.modeCheckBox.Text = "Mode Edition";
            this.modeCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoriesCheckedListBox
            // 
            this.categoriesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesCheckedListBox.FormattingEnabled = true;
            this.categoriesCheckedListBox.Location = new System.Drawing.Point(3, 74);
            this.categoriesCheckedListBox.Name = "categoriesCheckedListBox";
            this.categoriesCheckedListBox.Size = new System.Drawing.Size(214, 567);
            this.categoriesCheckedListBox.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Location = new System.Drawing.Point(424, 24);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 2;
            // 
            // validateChangesButton
            // 
            this.validateChangesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validateChangesButton.Location = new System.Drawing.Point(913, 24);
            this.validateChangesButton.Name = "validateChangesButton";
            this.validateChangesButton.Size = new System.Drawing.Size(75, 23);
            this.validateChangesButton.TabIndex = 3;
            this.validateChangesButton.Text = "Valider";
            this.validateChangesButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(223, 74);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(603, 567);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
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
    }
}
