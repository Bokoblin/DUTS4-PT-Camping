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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(184, 320);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(105, 20);
            this.passLabel.TabIndex = 14;
            this.passLabel.Text = "Mot de passe";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(184, 250);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(80, 20);
            this.userLabel.TabIndex = 13;
            this.userLabel.Text = "Identifiant";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(315, 320);
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(160, 30);
            this.passwordTextBox.TabIndex = 12;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(315, 250);
            this.userTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(160, 30);
            this.userTextBox.TabIndex = 11;
            // 
            // labelMenuStrip
            // 
            this.labelMenuStrip.AutoSize = true;
            this.labelMenuStrip.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuStrip.ForeColor = System.Drawing.Color.White;
            this.labelMenuStrip.Location = new System.Drawing.Point(40, 15);
            this.labelMenuStrip.Name = "labelMenuStrip";
            this.labelMenuStrip.Size = new System.Drawing.Size(84, 20);
            this.labelMenuStrip.TabIndex = 10;
            this.labelMenuStrip.Text = "Connexion";
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(346, 485);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(91, 30);
            this.connectionButton.TabIndex = 8;
            this.connectionButton.Text = "Entrer";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 50);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ConnectionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.labelMenuStrip);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ConnectionUserControl";
            this.Size = new System.Drawing.Size(784, 600);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
