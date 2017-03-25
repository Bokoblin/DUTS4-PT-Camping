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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.appBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // appBar
            // 
            this.appBar.AutoSize = false;
            this.appBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.appBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.appBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backArrow});
            this.appBar.Location = new System.Drawing.Point(0, 0);
            this.appBar.Name = "appBar";
            this.appBar.Size = new System.Drawing.Size(900, 50);
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
            this.appBarTitle.BackColor = System.Drawing.Color.RoyalBlue;
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
            this.logoutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(750, 6);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(120, 36);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Déconnexion";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(500, -1);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(229, 50);
            this.userNameLabel.TabIndex = 10;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManagementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.appBarTitle);
            this.Controls.Add(this.appBar);
            this.Name = "ManagementUserControl";
            this.Size = new System.Drawing.Size(900, 600);
            this.appBar.ResumeLayout(false);
            this.appBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip appBar;
        private System.Windows.Forms.ToolStripMenuItem backArrow;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button logoutButton;
        protected System.Windows.Forms.Label appBarTitle;
    }
}
