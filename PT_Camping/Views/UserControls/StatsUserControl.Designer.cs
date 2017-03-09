namespace PT_Camping.Views.UserControls
{
    partial class StatsUserControl
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mostAskedlocationsListView = new System.Windows.Forms.ListView();
            this.mostAskedProductsListView = new System.Windows.Forms.ListView();
            this.mostCommonIssueslistView = new System.Windows.Forms.ListView();
            this.bestClientsListView = new System.Windows.Forms.ListView();
            this.productsStatsTitle = new System.Windows.Forms.Label();
            this.clientsStatsTitle = new System.Windows.Forms.Label();
            this.locationsStatsTitle = new System.Windows.Forms.Label();
            this.issuesStatsTitle = new System.Windows.Forms.Label();
            this.yearPicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel.Controls.Add(this.mostAskedlocationsListView, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.mostAskedProductsListView, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.mostCommonIssueslistView, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.bestClientsListView, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.productsStatsTitle, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.clientsStatsTitle, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.locationsStatsTitle, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.issuesStatsTitle, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.yearPicker, 2, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 550);
            this.tableLayoutPanel.TabIndex = 11;
            // 
            // mostAskedlocationsListView
            // 
            this.mostAskedlocationsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostAskedlocationsListView.FullRowSelect = true;
            this.mostAskedlocationsListView.GridLines = true;
            this.mostAskedlocationsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mostAskedlocationsListView.Location = new System.Drawing.Point(43, 80);
            this.mostAskedlocationsListView.MultiSelect = false;
            this.mostAskedlocationsListView.Name = "mostAskedlocationsListView";
            this.mostAskedlocationsListView.Scrollable = false;
            this.mostAskedlocationsListView.Size = new System.Drawing.Size(322, 186);
            this.mostAskedlocationsListView.TabIndex = 0;
            this.mostAskedlocationsListView.UseCompatibleStateImageBehavior = false;
            this.mostAskedlocationsListView.View = System.Windows.Forms.View.List;
            this.mostAskedlocationsListView.DoubleClick += new System.EventHandler(this.MostAskedLocationsListView_DoubleClick);
            this.mostAskedlocationsListView.Resize += new System.EventHandler(this.MostAskedlocationsListView_Resize);
            // 
            // mostAskedProductsListView
            // 
            this.mostAskedProductsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostAskedProductsListView.FullRowSelect = true;
            this.mostAskedProductsListView.GridLines = true;
            this.mostAskedProductsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mostAskedProductsListView.Location = new System.Drawing.Point(427, 80);
            this.mostAskedProductsListView.MultiSelect = false;
            this.mostAskedProductsListView.Name = "mostAskedProductsListView";
            this.mostAskedProductsListView.Scrollable = false;
            this.mostAskedProductsListView.Size = new System.Drawing.Size(322, 186);
            this.mostAskedProductsListView.TabIndex = 1;
            this.mostAskedProductsListView.UseCompatibleStateImageBehavior = false;
            this.mostAskedProductsListView.View = System.Windows.Forms.View.List;
            this.mostAskedProductsListView.DoubleClick += new System.EventHandler(this.MostAskedProductsListView_DoubleClick);
            this.mostAskedProductsListView.Resize += new System.EventHandler(this.MostAskedProductsListView_Resize);
            // 
            // mostCommonIssueslistView
            // 
            this.mostCommonIssueslistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostCommonIssueslistView.FullRowSelect = true;
            this.mostCommonIssueslistView.GridLines = true;
            this.mostCommonIssueslistView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mostCommonIssueslistView.Location = new System.Drawing.Point(43, 305);
            this.mostCommonIssueslistView.MultiSelect = false;
            this.mostCommonIssueslistView.Name = "mostCommonIssueslistView";
            this.mostCommonIssueslistView.Scrollable = false;
            this.mostCommonIssueslistView.Size = new System.Drawing.Size(322, 186);
            this.mostCommonIssueslistView.TabIndex = 2;
            this.mostCommonIssueslistView.UseCompatibleStateImageBehavior = false;
            this.mostCommonIssueslistView.View = System.Windows.Forms.View.List;
            this.mostCommonIssueslistView.DoubleClick += new System.EventHandler(this.MostCommonIssuesListView_DoubleClick);
            this.mostCommonIssueslistView.Resize += new System.EventHandler(this.MostCommonIssueslistView_Resize);
            // 
            // bestClientsListView
            // 
            this.bestClientsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bestClientsListView.FullRowSelect = true;
            this.bestClientsListView.GridLines = true;
            this.bestClientsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.bestClientsListView.Location = new System.Drawing.Point(427, 305);
            this.bestClientsListView.MultiSelect = false;
            this.bestClientsListView.Name = "bestClientsListView";
            this.bestClientsListView.Scrollable = false;
            this.bestClientsListView.Size = new System.Drawing.Size(322, 186);
            this.bestClientsListView.TabIndex = 3;
            this.bestClientsListView.UseCompatibleStateImageBehavior = false;
            this.bestClientsListView.View = System.Windows.Forms.View.List;
            this.bestClientsListView.DoubleClick += new System.EventHandler(this.BestClientsListView_DoubleClick);
            this.bestClientsListView.Resize += new System.EventHandler(this.BestClientsListView_Resize);
            // 
            // productsStatsTitle
            // 
            this.productsStatsTitle.AutoSize = true;
            this.productsStatsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productsStatsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsStatsTitle.Location = new System.Drawing.Point(427, 61);
            this.productsStatsTitle.Name = "productsStatsTitle";
            this.productsStatsTitle.Size = new System.Drawing.Size(322, 16);
            this.productsStatsTitle.TabIndex = 4;
            this.productsStatsTitle.Text = "Produits les plus demandés";
            // 
            // clientsStatsTitle
            // 
            this.clientsStatsTitle.AutoSize = true;
            this.clientsStatsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clientsStatsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsStatsTitle.Location = new System.Drawing.Point(427, 286);
            this.clientsStatsTitle.Name = "clientsStatsTitle";
            this.clientsStatsTitle.Size = new System.Drawing.Size(322, 16);
            this.clientsStatsTitle.TabIndex = 7;
            this.clientsStatsTitle.Text = "Meilleurs clients";
            // 
            // locationsStatsTitle
            // 
            this.locationsStatsTitle.AutoSize = true;
            this.locationsStatsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.locationsStatsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationsStatsTitle.Location = new System.Drawing.Point(43, 61);
            this.locationsStatsTitle.Name = "locationsStatsTitle";
            this.locationsStatsTitle.Size = new System.Drawing.Size(322, 16);
            this.locationsStatsTitle.TabIndex = 8;
            this.locationsStatsTitle.Text = "Emplacements les plus demandés";
            // 
            // issuesStatsTitle
            // 
            this.issuesStatsTitle.AutoSize = true;
            this.issuesStatsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.issuesStatsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuesStatsTitle.Location = new System.Drawing.Point(43, 286);
            this.issuesStatsTitle.Name = "issuesStatsTitle";
            this.issuesStatsTitle.Size = new System.Drawing.Size(322, 16);
            this.issuesStatsTitle.TabIndex = 9;
            this.issuesStatsTitle.Text = "Incidents les plus courants";
            // 
            // yearPicker
            // 
            this.yearPicker.CustomFormat = "yyyy";
            this.yearPicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.yearPicker.Enabled = false;
            this.yearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearPicker.Location = new System.Drawing.Point(371, 21);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.ShowUpDown = true;
            this.yearPicker.Size = new System.Drawing.Size(50, 20);
            this.yearPicker.TabIndex = 10;
            this.yearPicker.ValueChanged += new System.EventHandler(this.YearPicker_ValueChanged);
            // 
            // StatsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "StatsUserControl";
            this.Controls.SetChildIndex(this.tableLayoutPanel, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ListView mostAskedlocationsListView;
        private System.Windows.Forms.ListView mostAskedProductsListView;
        private System.Windows.Forms.ListView mostCommonIssueslistView;
        private System.Windows.Forms.ListView bestClientsListView;
        private System.Windows.Forms.Label productsStatsTitle;
        private System.Windows.Forms.Label clientsStatsTitle;
        private System.Windows.Forms.Label locationsStatsTitle;
        private System.Windows.Forms.Label issuesStatsTitle;
        private System.Windows.Forms.DateTimePicker yearPicker;
    }
}
