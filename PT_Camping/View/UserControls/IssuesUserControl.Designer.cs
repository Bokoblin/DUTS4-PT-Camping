namespace PT_Camping
{
    partial class IssuesUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuesUserControl));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.issuesListView = new System.Windows.Forms.ListView();
            this.addIssueButton = new System.Windows.Forms.Button();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.emplacementLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.criticalityTextBox = new System.Windows.Forms.TextBox();
            this.resolutionDateTextBox = new System.Windows.Forms.TextBox();
            this.creationDateTextBox = new System.Windows.Forms.TextBox();
            this.issueTypeTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.detailsTitleBarPanel = new System.Windows.Forms.Panel();
            this.detailsTitle = new System.Windows.Forms.Label();
            this.resolveButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.criticalityLabel = new System.Windows.Forms.Label();
            this.ResolutionDateLabel = new System.Windows.Forms.Label();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.detailsTitleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appBarTitle
            // 
            this.appBarTitle.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.TabIndex = 7;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Controls.Add(this.detailsPanel, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.issuesListView, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.addIssueButton, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(803, 553);
            this.tableLayoutPanel.TabIndex = 12;
            // 
            // issuesListView
            // 
            this.issuesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issuesListView.FullRowSelect = true;
            this.issuesListView.GridLines = true;
            this.issuesListView.HideSelection = false;
            this.issuesListView.Location = new System.Drawing.Point(43, 47);
            this.issuesListView.MultiSelect = false;
            this.issuesListView.Name = "issuesListView";
            this.issuesListView.Scrollable = false;
            this.issuesListView.Size = new System.Drawing.Size(315, 392);
            this.issuesListView.TabIndex = 10;
            this.issuesListView.UseCompatibleStateImageBehavior = false;
            this.issuesListView.View = System.Windows.Forms.View.List;
            this.issuesListView.SelectedIndexChanged += new System.EventHandler(this.issuesListView_SelectedIndexChanged);
            this.issuesListView.Resize += new System.EventHandler(this.issuesListView_Resize);
            // 
            // addIssueButton
            // 
            this.addIssueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIssueButton.AutoSize = true;
            this.addIssueButton.Location = new System.Drawing.Point(140, 465);
            this.addIssueButton.Name = "addIssueButton";
            this.addIssueButton.Size = new System.Drawing.Size(120, 35);
            this.addIssueButton.TabIndex = 11;
            this.addIssueButton.Text = "Nouvel incident";
            this.addIssueButton.UseVisualStyleBackColor = true;
            this.addIssueButton.Click += new System.EventHandler(this.onAddIssueButtonClick);
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoSize = true;
            this.detailsPanel.BackColor = System.Drawing.Color.White;
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.locationTextBox);
            this.detailsPanel.Controls.Add(this.emplacementLabel);
            this.detailsPanel.Controls.Add(this.descriptionTextBox);
            this.detailsPanel.Controls.Add(this.statusTextBox);
            this.detailsPanel.Controls.Add(this.criticalityTextBox);
            this.detailsPanel.Controls.Add(this.resolutionDateTextBox);
            this.detailsPanel.Controls.Add(this.creationDateTextBox);
            this.detailsPanel.Controls.Add(this.issueTypeTextBox);
            this.detailsPanel.Controls.Add(this.idTextBox);
            this.detailsPanel.Controls.Add(this.deleteButton);
            this.detailsPanel.Controls.Add(this.editButton);
            this.detailsPanel.Controls.Add(this.detailsTitleBarPanel);
            this.detailsPanel.Controls.Add(this.resolveButton);
            this.detailsPanel.Controls.Add(this.descriptionLabel);
            this.detailsPanel.Controls.Add(this.statusLabel);
            this.detailsPanel.Controls.Add(this.criticalityLabel);
            this.detailsPanel.Controls.Add(this.ResolutionDateLabel);
            this.detailsPanel.Controls.Add(this.creationDateLabel);
            this.detailsPanel.Controls.Add(this.TypeLabel);
            this.detailsPanel.Controls.Add(this.idLabel);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(444, 47);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(315, 392);
            this.detailsPanel.TabIndex = 11;
            // 
            // emplacementTextBox
            // 
            this.locationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationTextBox.Location = new System.Drawing.Point(161, 125);
            this.locationTextBox.Name = "emplacementTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(120, 20);
            this.locationTextBox.TabIndex = 13;
            // 
            // emplacementLabel
            // 
            this.emplacementLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emplacementLabel.AutoSize = true;
            this.emplacementLabel.Location = new System.Drawing.Point(29, 128);
            this.emplacementLabel.Name = "emplacementLabel";
            this.emplacementLabel.Size = new System.Drawing.Size(71, 13);
            this.emplacementLabel.TabIndex = 19;
            this.emplacementLabel.Text = "Emplacement";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(161, 281);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(120, 40);
            this.descriptionTextBox.TabIndex = 19;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusTextBox.Location = new System.Drawing.Point(161, 255);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(120, 20);
            this.statusTextBox.TabIndex = 18;
            // 
            // criticalityTextBox
            // 
            this.criticalityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criticalityTextBox.Location = new System.Drawing.Point(161, 229);
            this.criticalityTextBox.Name = "criticalityTextBox";
            this.criticalityTextBox.ReadOnly = true;
            this.criticalityTextBox.Size = new System.Drawing.Size(120, 20);
            this.criticalityTextBox.TabIndex = 17;
            // 
            // resolutionDateTextBox
            // 
            this.resolutionDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resolutionDateTextBox.Location = new System.Drawing.Point(161, 203);
            this.resolutionDateTextBox.Name = "resolutionDateTextBox";
            this.resolutionDateTextBox.ReadOnly = true;
            this.resolutionDateTextBox.Size = new System.Drawing.Size(120, 20);
            this.resolutionDateTextBox.TabIndex = 16;
            // 
            // creationDateTextBox
            // 
            this.creationDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creationDateTextBox.Location = new System.Drawing.Point(161, 177);
            this.creationDateTextBox.Name = "creationDateTextBox";
            this.creationDateTextBox.ReadOnly = true;
            this.creationDateTextBox.Size = new System.Drawing.Size(120, 20);
            this.creationDateTextBox.TabIndex = 15;
            // 
            // typeTextBox
            // 
            this.issueTypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.issueTypeTextBox.Location = new System.Drawing.Point(161, 151);
            this.issueTypeTextBox.Name = "typeTextBox";
            this.issueTypeTextBox.ReadOnly = true;
            this.issueTypeTextBox.Size = new System.Drawing.Size(120, 20);
            this.issueTypeTextBox.TabIndex = 14;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.Location = new System.Drawing.Point(161, 99);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(120, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(244, 46);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(30, 30);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.onDeleteIssueButtonClick);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Location = new System.Drawing.Point(280, 46);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(30, 30);
            this.editButton.TabIndex = 11;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.onEditButtonClick);
            // 
            // detailsTitleBarPanel
            // 
            this.detailsTitleBarPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.detailsTitleBarPanel.Controls.Add(this.detailsTitle);
            this.detailsTitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsTitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsTitleBarPanel.Name = "detailsTitleBarPanel";
            this.detailsTitleBarPanel.Size = new System.Drawing.Size(313, 40);
            this.detailsTitleBarPanel.TabIndex = 9;
            // 
            // detailsTitle
            // 
            this.detailsTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailsTitle.AutoSize = true;
            this.detailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTitle.ForeColor = System.Drawing.Color.White;
            this.detailsTitle.Location = new System.Drawing.Point(104, 10);
            this.detailsTitle.Name = "detailsTitle";
            this.detailsTitle.Size = new System.Drawing.Size(109, 20);
            this.detailsTitle.TabIndex = 0;
            this.detailsTitle.Text = "Détail incident";
            // 
            // resolveButton
            // 
            this.resolveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resolveButton.AutoSize = true;
            this.resolveButton.Location = new System.Drawing.Point(95, 343);
            this.resolveButton.Name = "resolveButton";
            this.resolveButton.Size = new System.Drawing.Size(130, 30);
            this.resolveButton.TabIndex = 20;
            this.resolveButton.Text = "Marqué comme résolu";
            this.resolveButton.UseVisualStyleBackColor = true;
            this.resolveButton.Click += new System.EventHandler(this.onResolveIssueButtonClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(29, 284);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description";
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(29, 258);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(67, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Avancement";
            // 
            // criticalityLabel
            // 
            this.criticalityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criticalityLabel.AutoSize = true;
            this.criticalityLabel.Location = new System.Drawing.Point(29, 232);
            this.criticalityLabel.Name = "criticalityLabel";
            this.criticalityLabel.Size = new System.Drawing.Size(41, 13);
            this.criticalityLabel.TabIndex = 5;
            this.criticalityLabel.Text = "Criticité";
            // 
            // ResolutionDateLabel
            // 
            this.ResolutionDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResolutionDateLabel.AutoSize = true;
            this.ResolutionDateLabel.Location = new System.Drawing.Point(29, 206);
            this.ResolutionDateLabel.Name = "ResolutionDateLabel";
            this.ResolutionDateLabel.Size = new System.Drawing.Size(93, 13);
            this.ResolutionDateLabel.TabIndex = 4;
            this.ResolutionDateLabel.Text = "Date de résolution";
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Location = new System.Drawing.Point(29, 180);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(86, 13);
            this.creationDateLabel.TabIndex = 3;
            this.creationDateLabel.Text = "Date de création";
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(29, 154);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Type";
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(29, 102);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(57, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Référence";
            // 
            // IssuesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "IssuesUserControl";
            this.Size = new System.Drawing.Size(803, 603);
            this.Controls.SetChildIndex(this.tableLayoutPanel, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.detailsTitleBarPanel.ResumeLayout(false);
            this.detailsTitleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ListView issuesListView;
        private System.Windows.Forms.Button addIssueButton;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button resolveButton;
        private System.Windows.Forms.Panel detailsTitleBarPanel;
        private System.Windows.Forms.Label detailsTitle;
        private System.Windows.Forms.Label emplacementLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label criticalityLabel;
        private System.Windows.Forms.Label ResolutionDateLabel;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox criticalityTextBox;
        private System.Windows.Forms.TextBox resolutionDateTextBox;
        private System.Windows.Forms.TextBox creationDateTextBox;
        private System.Windows.Forms.TextBox issueTypeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
    }
}
