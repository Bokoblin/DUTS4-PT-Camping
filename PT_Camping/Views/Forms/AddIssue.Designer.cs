namespace PT_Camping.Views.Forms
{
    partial class AddIssue
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.criticalityLabel = new System.Windows.Forms.Label();
            this.issueTypecomboBox = new System.Windows.Forms.ComboBox();
            this.criticalityComboBox = new System.Windows.Forms.ComboBox();
            this.linkedLocationLabel = new System.Windows.Forms.Label();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(12, 166);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(240, 20);
            this.nameLabel.TabIndex = 33;
            this.nameLabel.Text = "Description";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(56, 189);
            this.descriptionTextBox.MaxLength = 300;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ShortcutsEnabled = false;
            this.descriptionTextBox.Size = new System.Drawing.Size(156, 40);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // surnameLabel
            // 
            this.surnameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.surnameLabel.Location = new System.Drawing.Point(12, 25);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(240, 20);
            this.surnameLabel.TabIndex = 21;
            this.surnameLabel.Text = "Type d\'incident";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(27, 250);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 25);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(157, 250);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(80, 25);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "Valider";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // criticalityLabel
            // 
            this.criticalityLabel.Location = new System.Drawing.Point(12, 119);
            this.criticalityLabel.Name = "criticalityLabel";
            this.criticalityLabel.Size = new System.Drawing.Size(240, 20);
            this.criticalityLabel.TabIndex = 34;
            this.criticalityLabel.Text = "Criticité";
            this.criticalityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // issueTypecomboBox
            // 
            this.issueTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.issueTypecomboBox.FormattingEnabled = true;
            this.issueTypecomboBox.Location = new System.Drawing.Point(56, 48);
            this.issueTypecomboBox.Name = "issueTypecomboBox";
            this.issueTypecomboBox.Size = new System.Drawing.Size(156, 21);
            this.issueTypecomboBox.TabIndex = 36;
            // 
            // criticalityComboBox
            // 
            this.criticalityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criticalityComboBox.FormattingEnabled = true;
            this.criticalityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.criticalityComboBox.Location = new System.Drawing.Point(56, 142);
            this.criticalityComboBox.Name = "criticalityComboBox";
            this.criticalityComboBox.Size = new System.Drawing.Size(156, 21);
            this.criticalityComboBox.TabIndex = 37;
            // 
            // linkedLocationLabel
            // 
            this.linkedLocationLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkedLocationLabel.Location = new System.Drawing.Point(12, 72);
            this.linkedLocationLabel.Name = "linkedLocationLabel";
            this.linkedLocationLabel.Size = new System.Drawing.Size(240, 20);
            this.linkedLocationLabel.TabIndex = 38;
            this.linkedLocationLabel.Text = "Emplacement lié";
            this.linkedLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationComboBox
            // 
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(56, 95);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(156, 21);
            this.locationComboBox.TabIndex = 39;
            // 
            // AddIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 311);
            this.Controls.Add(this.locationComboBox);
            this.Controls.Add(this.linkedLocationLabel);
            this.Controls.Add(this.criticalityComboBox);
            this.Controls.Add(this.issueTypecomboBox);
            this.Controls.Add(this.criticalityLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddIssue";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvel incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label criticalityLabel;
        private System.Windows.Forms.ComboBox issueTypecomboBox;
        private System.Windows.Forms.ComboBox criticalityComboBox;
        private System.Windows.Forms.Label linkedLocationLabel;
        private System.Windows.Forms.ComboBox locationComboBox;
    }
}