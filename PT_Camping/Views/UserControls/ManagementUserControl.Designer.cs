using System;

namespace PT_Camping.Views.UserControls
{
    partial class ManagementUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementUserControl));
            this.appBar = new System.Windows.Forms.MenuStrip();
            this.backArrow = new System.Windows.Forms.ToolStripMenuItem();
            this.appBarTitle = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userNameButton = new System.Windows.Forms.Button();
            this.appBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // appBar
            // 
            this.appBar.AutoSize = false;
            this.appBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.appBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.appBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backArrow});
            this.appBar.Location = new System.Drawing.Point(0, 0);
            this.appBar.MinimumSize = new System.Drawing.Size(0, 50);
            this.appBar.Name = "appBar";
            this.appBar.Size = new System.Drawing.Size(984, 50);
            this.appBar.TabIndex = 5;
            this.appBar.Text = "appBar";
            // 
            // backArrow
            // 
            this.backArrow.AutoSize = false;
            this.backArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backArrow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.backArrow.Image = ((System.Drawing.Image)(resources.GetObject("backArrow.Image")));
            this.backArrow.Name = "backArrow";
            this.backArrow.Padding = new System.Windows.Forms.Padding(0);
            this.backArrow.Size = new System.Drawing.Size(25, 25);
            this.backArrow.Text = "back";
            this.backArrow.Click += new System.EventHandler(this.BackArrow_Click);
            // 
            // appBarTitle
            // 
            this.appBarTitle.AutoSize = true;
            this.appBarTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.appBarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appBarTitle.ForeColor = System.Drawing.Color.White;
            this.appBarTitle.Location = new System.Drawing.Point(40, 15);
            this.appBarTitle.Name = "appBarTitle";
            this.appBarTitle.Size = new System.Drawing.Size(107, 20);
            this.appBarTitle.TabIndex = 6;
            this.appBarTitle.Text = "TITLE_NAME";
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(800, 6);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(120, 36);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Déconnexion";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // userNameButton
            // 
            this.userNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameButton.AutoSize = true;
            this.userNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.userNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userNameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.userNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameButton.ForeColor = System.Drawing.Color.White;
            this.userNameButton.Location = new System.Drawing.Point(699, 6);
            this.userNameButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameButton.Name = "userNameButton";
            this.userNameButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameButton.Size = new System.Drawing.Size(101, 36);
            this.userNameButton.TabIndex = 9;
            this.userNameButton.Text = "User Name";
            this.userNameButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userNameButton.UseVisualStyleBackColor = false;
            this.userNameButton.Click += new System.EventHandler(this.UserNameButton_Click);
            // 
            // ManagementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.userNameButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.appBarTitle);
            this.Controls.Add(this.appBar);
            this.Name = "ManagementUserControl";
            this.Size = new System.Drawing.Size(984, 600);
            this.appBar.ResumeLayout(false);
            this.appBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip appBar;
        private System.Windows.Forms.ToolStripMenuItem backArrow;
        private System.Windows.Forms.Button userNameButton;
        private System.Windows.Forms.Button logoutButton;
        protected System.Windows.Forms.Label appBarTitle;
    }
}
