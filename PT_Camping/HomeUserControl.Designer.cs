﻿namespace PT_Camping
{
    partial class HomeUserControl
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
            this.appBar = new System.Windows.Forms.MenuStrip();
            this.homeTitle = new System.Windows.Forms.Label();
            this.homeTabControl = new System.Windows.Forms.TabControl();
            this.managementTab = new System.Windows.Forms.TabPage();
            this.providerButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.stocksButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.issuesButton = new System.Windows.Forms.Button();
            this.clientButton = new System.Windows.Forms.Button();
            this.mapTab = new System.Windows.Forms.TabPage();
            this.logoutButton = new System.Windows.Forms.Button();
            this.homeTabControl.SuspendLayout();
            this.managementTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // appBar
            // 
            this.appBar.AutoSize = false;
            this.appBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.appBar.Location = new System.Drawing.Point(0, 0);
            this.appBar.Name = "appBar";
            this.appBar.Size = new System.Drawing.Size(803, 50);
            this.appBar.TabIndex = 3;
            // 
            // homeTitle
            // 
            this.homeTitle.AutoSize = true;
            this.homeTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.homeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTitle.ForeColor = System.Drawing.Color.White;
            this.homeTitle.Location = new System.Drawing.Point(40, 15);
            this.homeTitle.Name = "homeTitle";
            this.homeTitle.Size = new System.Drawing.Size(60, 20);
            this.homeTitle.TabIndex = 4;
            this.homeTitle.Text = "Accueil";
            // 
            // homeTabControl
            // 
            this.homeTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeTabControl.Controls.Add(this.managementTab);
            this.homeTabControl.Controls.Add(this.mapTab);
            this.homeTabControl.ItemSize = new System.Drawing.Size(360, 30);
            this.homeTabControl.Location = new System.Drawing.Point(0, 52);
            this.homeTabControl.Name = "homeTabControl";
            this.homeTabControl.Padding = new System.Drawing.Point(50, 3);
            this.homeTabControl.SelectedIndex = 0;
            this.homeTabControl.Size = new System.Drawing.Size(800, 540);
            this.homeTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.homeTabControl.TabIndex = 7;
            this.homeTabControl.SelectedIndexChanged += new System.EventHandler(this.homeTabControl_SelectedIndexChanged);
            // 
            // managementTab
            // 
            this.managementTab.Controls.Add(this.providerButton);
            this.managementTab.Controls.Add(this.statsButton);
            this.managementTab.Controls.Add(this.stocksButton);
            this.managementTab.Controls.Add(this.employeeButton);
            this.managementTab.Controls.Add(this.issuesButton);
            this.managementTab.Controls.Add(this.clientButton);
            this.managementTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementTab.Location = new System.Drawing.Point(4, 34);
            this.managementTab.Name = "managementTab";
            this.managementTab.Size = new System.Drawing.Size(792, 502);
            this.managementTab.TabIndex = 0;
            this.managementTab.Text = "GESTION";
            this.managementTab.UseVisualStyleBackColor = true;
            // 
            // providerButton
            // 
            this.providerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.providerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerButton.Location = new System.Drawing.Point(113, 362);
            this.providerButton.Name = "providerButton";
            this.providerButton.Size = new System.Drawing.Size(169, 64);
            this.providerButton.TabIndex = 11;
            this.providerButton.Text = "FOURNISSEURS";
            this.providerButton.UseVisualStyleBackColor = true;
            this.providerButton.Click += new System.EventHandler(this.providersButton_Click);
            // 
            // statsButton
            // 
            this.statsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsButton.Location = new System.Drawing.Point(468, 362);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(169, 64);
            this.statsButton.TabIndex = 10;
            this.statsButton.Text = "STATS";
            this.statsButton.UseVisualStyleBackColor = true;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // stocksButton
            // 
            this.stocksButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stocksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksButton.Location = new System.Drawing.Point(468, 225);
            this.stocksButton.Name = "stocksButton";
            this.stocksButton.Size = new System.Drawing.Size(169, 64);
            this.stocksButton.TabIndex = 9;
            this.stocksButton.Text = "STOCKS";
            this.stocksButton.UseVisualStyleBackColor = true;
            this.stocksButton.Click += new System.EventHandler(this.stocksButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeButton.Location = new System.Drawing.Point(113, 225);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(169, 64);
            this.employeeButton.TabIndex = 8;
            this.employeeButton.Text = "EMPLOYÉS";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // issuesButton
            // 
            this.issuesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.issuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuesButton.Location = new System.Drawing.Point(468, 83);
            this.issuesButton.Name = "issuesButton";
            this.issuesButton.Size = new System.Drawing.Size(169, 64);
            this.issuesButton.TabIndex = 7;
            this.issuesButton.Text = "INCIDENTS";
            this.issuesButton.UseVisualStyleBackColor = true;
            this.issuesButton.Click += new System.EventHandler(this.issuesButton_Click);
            // 
            // clientButton
            // 
            this.clientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.Location = new System.Drawing.Point(113, 83);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(169, 64);
            this.clientButton.TabIndex = 6;
            this.clientButton.Text = "CLIENTS";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // mapTab
            // 
            this.mapTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapTab.Location = new System.Drawing.Point(4, 34);
            this.mapTab.Name = "mapTab";
            this.mapTab.Size = new System.Drawing.Size(792, 512);
            this.mapTab.TabIndex = 1;
            this.mapTab.Text = "CARTE";
            this.mapTab.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(633, 7);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(120, 36);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Déconnexion";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.homeTabControl);
            this.Controls.Add(this.homeTitle);
            this.Controls.Add(this.appBar);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(803, 600);
            this.homeTabControl.ResumeLayout(false);
            this.managementTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip appBar;
        private System.Windows.Forms.Label homeTitle;
        private System.Windows.Forms.TabControl homeTabControl;
        private System.Windows.Forms.TabPage managementTab;
        private System.Windows.Forms.Button providerButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Button stocksButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button issuesButton;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.TabPage mapTab;
        protected System.Windows.Forms.Button logoutButton;
    }
}