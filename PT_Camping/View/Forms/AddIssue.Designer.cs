namespace PT_Camping
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.criticalityLabel = new System.Windows.Forms.Label();
            this.criticalityTextBox = new System.Windows.Forms.TextBox();
            this.issueTypecomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(12, 116);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(240, 20);
            this.nameLabel.TabIndex = 33;
            this.nameLabel.Text = "Description";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(56, 139);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(156, 40);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // surnameLabel
            // 
            this.surnameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.surnameLabel.Location = new System.Drawing.Point(12, 24);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(240, 20);
            this.surnameLabel.TabIndex = 21;
            this.surnameLabel.Text = "Type d\'incident";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(27, 210);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 25);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(157, 210);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(80, 25);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "Valider";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // criticalityLabel
            // 
            this.criticalityLabel.Location = new System.Drawing.Point(12, 70);
            this.criticalityLabel.Name = "criticalityLabel";
            this.criticalityLabel.Size = new System.Drawing.Size(240, 20);
            this.criticalityLabel.TabIndex = 34;
            this.criticalityLabel.Text = "Criticité";
            this.criticalityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // criticalityTextBox
            // 
            this.criticalityTextBox.Location = new System.Drawing.Point(56, 93);
            this.criticalityTextBox.Name = "criticalityTextBox";
            this.criticalityTextBox.Size = new System.Drawing.Size(156, 20);
            this.criticalityTextBox.TabIndex = 35;
            // 
            // issueTypecomboBox
            // 
            this.issueTypecomboBox.FormattingEnabled = true;
            this.issueTypecomboBox.Location = new System.Drawing.Point(56, 47);
            this.issueTypecomboBox.Name = "issueTypecomboBox";
            this.issueTypecomboBox.Size = new System.Drawing.Size(156, 21);
            this.issueTypecomboBox.TabIndex = 36;
            // 
            // AddIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.issueTypecomboBox);
            this.Controls.Add(this.criticalityTextBox);
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label criticalityLabel;
        private System.Windows.Forms.TextBox criticalityTextBox;
        private System.Windows.Forms.ComboBox issueTypecomboBox;
    }
}