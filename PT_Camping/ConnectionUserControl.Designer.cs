namespace PT_Camping
{
    partial class ConnectionUserControl
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
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.labelMenuStrip = new System.Windows.Forms.Label();
            this.connectionButton = new System.Windows.Forms.Button();
            this.appBar = new System.Windows.Forms.MenuStrip();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(247, 375);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(130, 25);
            this.passLabel.TabIndex = 14;
            this.passLabel.Text = "Mot de passe";
            // 
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(247, 289);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(95, 25);
            this.userLabel.TabIndex = 13;
            this.userLabel.Text = "Identifiant";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(420, 369);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(212, 24);
            this.passwordTextBox.TabIndex = 12;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userTextBox
            // 
            this.userTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(420, 283);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(212, 24);
            this.userTextBox.TabIndex = 11;
            // 
            // labelMenuStrip
            // 
            this.labelMenuStrip.AutoSize = true;
            this.labelMenuStrip.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuStrip.ForeColor = System.Drawing.Color.White;
            this.labelMenuStrip.Location = new System.Drawing.Point(53, 18);
            this.labelMenuStrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenuStrip.Name = "labelMenuStrip";
            this.labelMenuStrip.Size = new System.Drawing.Size(107, 25);
            this.labelMenuStrip.TabIndex = 10;
            this.labelMenuStrip.Text = "Connexion";
            // 
            // connectionButton
            // 
            this.connectionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectionButton.Location = new System.Drawing.Point(467, 615);
            this.connectionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(120, 37);
            this.connectionButton.TabIndex = 8;
            this.connectionButton.Text = "Entrer";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // appBar
            // 
            this.appBar.AutoSize = false;
            this.appBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.appBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.appBar.Location = new System.Drawing.Point(0, 0);
            this.appBar.Name = "appBar";
            this.appBar.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.appBar.Size = new System.Drawing.Size(1067, 62);
            this.appBar.TabIndex = 9;
            this.appBar.Text = "appBar";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(420, 401);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(281, 17);
            this.errorLabel.TabIndex = 16;
            this.errorLabel.Text = "Nom d\'utilisateur ou mot de passe incorrect";
            // 
            // ConnectionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.labelMenuStrip);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.appBar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConnectionUserControl";
            this.Size = new System.Drawing.Size(1067, 738);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label labelMenuStrip;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.MenuStrip appBar;
        private System.Windows.Forms.Label errorLabel;
    }
}
