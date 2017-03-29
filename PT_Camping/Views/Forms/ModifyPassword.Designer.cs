namespace PT_Camping.Views.Forms
{
    partial class ModifyPassword
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
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.oldPasstextBox = new System.Windows.Forms.TextBox();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.oldPassLabel = new System.Windows.Forms.Label();
            this.confirmPassTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(216, 81);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(62, 17);
            this.showPasswordCheckBox.TabIndex = 9;
            this.showPasswordCheckBox.Text = "Afficher";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(166, 180);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(80, 25);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "Valider";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(27, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 25);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(76, 79);
            this.newPassTextBox.MaxLength = 64;
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.ShortcutsEnabled = false;
            this.newPassTextBox.Size = new System.Drawing.Size(134, 20);
            this.newPassTextBox.TabIndex = 7;
            this.newPassTextBox.UseSystemPasswordChar = true;
            // 
            // newPassLabel
            // 
            this.newPassLabel.Location = new System.Drawing.Point(6, 56);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(272, 20);
            this.newPassLabel.TabIndex = 45;
            this.newPassLabel.Text = "Nouveau mot de passe";
            this.newPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldPasstextBox
            // 
            this.oldPasstextBox.Location = new System.Drawing.Point(76, 33);
            this.oldPasstextBox.MaxLength = 64;
            this.oldPasstextBox.Name = "oldPasstextBox";
            this.oldPasstextBox.ShortcutsEnabled = false;
            this.oldPasstextBox.Size = new System.Drawing.Size(134, 20);
            this.oldPasstextBox.TabIndex = 6;
            this.oldPasstextBox.UseSystemPasswordChar = true;
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.Location = new System.Drawing.Point(6, 102);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(272, 20);
            this.confirmPassLabel.TabIndex = 48;
            this.confirmPassLabel.Text = "Confirmer le mot de passe";
            this.confirmPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.Location = new System.Drawing.Point(6, 10);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(272, 20);
            this.oldPassLabel.TabIndex = 49;
            this.oldPassLabel.Text = "Ancien mot de passe";
            this.oldPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.Location = new System.Drawing.Point(76, 125);
            this.confirmPassTextBox.MaxLength = 64;
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.ShortcutsEnabled = false;
            this.confirmPassTextBox.Size = new System.Drawing.Size(134, 20);
            this.confirmPassTextBox.TabIndex = 8;
            this.confirmPassTextBox.UseSystemPasswordChar = true;
            // 
            // ModifyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.confirmPassTextBox);
            this.Controls.Add(this.oldPassLabel);
            this.Controls.Add(this.confirmPassLabel);
            this.Controls.Add(this.oldPasstextBox);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.newPassLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifyPassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier le mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.Label newPassLabel;
        private System.Windows.Forms.TextBox oldPasstextBox;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.Label oldPassLabel;
        private System.Windows.Forms.TextBox confirmPassTextBox;
    }
}