namespace PT_Camping.Views.UserControls
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
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.White;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(65, 217);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(110, 20);
            this.passLabel.TabIndex = 14;
            this.passLabel.Text = "Mot de passe";
            // 
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.White;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(65, 137);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(88, 24);
            this.userLabel.TabIndex = 13;
            this.userLabel.Text = "Identifiant";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(204, 213);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.MaxLength = 64;
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ShortcutsEnabled = false;
            this.passwordTextBox.Size = new System.Drawing.Size(172, 29);
            this.passwordTextBox.TabIndex = 12;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // userTextBox
            // 
            this.userTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(204, 134);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userTextBox.MaxLength = 40;
            this.userTextBox.MinimumSize = new System.Drawing.Size(5, 30);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ShortcutsEnabled = false;
            this.userTextBox.Size = new System.Drawing.Size(173, 29);
            this.userTextBox.TabIndex = 11;
            this.userTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserTextBox_KeyDown);
            // 
            // labelMenuStrip
            // 
            this.labelMenuStrip.AutoSize = true;
            this.labelMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
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
            this.connectionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectionButton.Location = new System.Drawing.Point(220, 345);
            this.connectionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(133, 37);
            this.connectionButton.TabIndex = 8;
            this.connectionButton.Text = "Connexion";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // appBar
            // 
            this.appBar.AutoSize = false;
            this.appBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
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
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.White;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(179, 257);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.errorLabel.Size = new System.Drawing.Size(237, 21);
            this.errorLabel.TabIndex = 16;
            this.errorLabel.Text = "Identifiant ou mot de passe incorrect";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.BackColor = System.Drawing.Color.White;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(407, 220);
            this.showPasswordCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(78, 21);
            this.showPasswordCheckBox.TabIndex = 42;
            this.showPasswordCheckBox.Text = "Afficher";
            this.showPasswordCheckBox.UseVisualStyleBackColor = false;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.showPasswordCheckBox);
            this.panel1.Controls.Add(this.connectionButton);
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.userTextBox);
            this.panel1.Location = new System.Drawing.Point(233, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 428);
            this.panel1.TabIndex = 43;
            // 
            // ConnectionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labelMenuStrip);
            this.Controls.Add(this.appBar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConnectionUserControl";
            this.Size = new System.Drawing.Size(1067, 738);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConnectionUserControl_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Panel panel1;
    }
}
