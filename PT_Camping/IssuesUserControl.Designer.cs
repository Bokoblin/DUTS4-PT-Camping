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
            this.issuesListView = new System.Windows.Forms.ListView();
            this.addIssueButton = new System.Windows.Forms.Button();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.emplacementTextBox = new System.Windows.Forms.TextBox();
            this.emplacementLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.criticStateTextBox = new System.Windows.Forms.TextBox();
            this.resolutionDateTextBox = new System.Windows.Forms.TextBox();
            this.creationDateTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.detailsTitleBarPanel = new System.Windows.Forms.Panel();
            this.detailsTitle = new System.Windows.Forms.Label();
            this.resolveButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.criticStateLabel = new System.Windows.Forms.Label();
            this.ResolutionDateLabel = new System.Windows.Forms.Label();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.detailsPanel.SuspendLayout();
            this.detailsTitleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // issuesListView
            // 
            this.issuesListView.GridLines = true;
            this.issuesListView.HideSelection = false;
            this.issuesListView.Location = new System.Drawing.Point(25, 80);
            this.issuesListView.MultiSelect = false;
            this.issuesListView.Name = "issuesListView";
            this.issuesListView.Size = new System.Drawing.Size(320, 400);
            this.issuesListView.TabIndex = 10;
            this.issuesListView.UseCompatibleStateImageBehavior = false;
            this.issuesListView.View = System.Windows.Forms.View.List;
            this.issuesListView.SelectedIndexChanged += new System.EventHandler(this.issuesListView_SelectedIndexChanged);
            // 
            // addIssueButton
            // 
            this.addIssueButton.AutoSize = true;
            this.addIssueButton.Location = new System.Drawing.Point(100, 520);
            this.addIssueButton.Name = "addIssueButton";
            this.addIssueButton.Size = new System.Drawing.Size(166, 38);
            this.addIssueButton.TabIndex = 11;
            this.addIssueButton.Text = "Nouvel incident";
            this.addIssueButton.UseVisualStyleBackColor = true;
            this.addIssueButton.Click += new System.EventHandler(this.onAddIssueButtonClick);
            // 
            // detailsPanel
            // 
            this.detailsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailsPanel.AutoSize = true;
            this.detailsPanel.BackColor = System.Drawing.Color.White;
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.emplacementTextBox);
            this.detailsPanel.Controls.Add(this.emplacementLabel);
            this.detailsPanel.Controls.Add(this.descriptionTextBox);
            this.detailsPanel.Controls.Add(this.stateTextBox);
            this.detailsPanel.Controls.Add(this.criticStateTextBox);
            this.detailsPanel.Controls.Add(this.resolutionDateTextBox);
            this.detailsPanel.Controls.Add(this.creationDateTextBox);
            this.detailsPanel.Controls.Add(this.typeTextBox);
            this.detailsPanel.Controls.Add(this.idTextBox);
            this.detailsPanel.Controls.Add(this.deleteButton);
            this.detailsPanel.Controls.Add(this.editButton);
            this.detailsPanel.Controls.Add(this.detailsTitleBarPanel);
            this.detailsPanel.Controls.Add(this.resolveButton);
            this.detailsPanel.Controls.Add(this.descriptionLabel);
            this.detailsPanel.Controls.Add(this.stateLabel);
            this.detailsPanel.Controls.Add(this.criticStateLabel);
            this.detailsPanel.Controls.Add(this.ResolutionDateLabel);
            this.detailsPanel.Controls.Add(this.creationDateLabel);
            this.detailsPanel.Controls.Add(this.TypeLabel);
            this.detailsPanel.Controls.Add(this.idLabel);
            this.detailsPanel.Location = new System.Drawing.Point(420, 80);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(352, 400);
            this.detailsPanel.TabIndex = 12;
            // 
            // emplacementTextBox
            // 
            this.emplacementTextBox.Location = new System.Drawing.Point(161, 124);
            this.emplacementTextBox.Name = "emplacementTextBox";
            this.emplacementTextBox.ReadOnly = true;
            this.emplacementTextBox.Size = new System.Drawing.Size(120, 20);
            this.emplacementTextBox.TabIndex = 20;
            // 
            // emplacementLabel
            // 
            this.emplacementLabel.AutoSize = true;
            this.emplacementLabel.Location = new System.Drawing.Point(29, 127);
            this.emplacementLabel.Name = "emplacementLabel";
            this.emplacementLabel.Size = new System.Drawing.Size(71, 13);
            this.emplacementLabel.TabIndex = 19;
            this.emplacementLabel.Text = "Emplacement";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(161, 280);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(120, 40);
            this.descriptionTextBox.TabIndex = 18;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(161, 254);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(120, 20);
            this.stateTextBox.TabIndex = 17;
            // 
            // criticStateTextBox
            // 
            this.criticStateTextBox.Location = new System.Drawing.Point(161, 228);
            this.criticStateTextBox.Name = "criticStateTextBox";
            this.criticStateTextBox.ReadOnly = true;
            this.criticStateTextBox.Size = new System.Drawing.Size(120, 20);
            this.criticStateTextBox.TabIndex = 16;
            // 
            // resolutionDateTextBox
            // 
            this.resolutionDateTextBox.Location = new System.Drawing.Point(161, 202);
            this.resolutionDateTextBox.Name = "resolutionDateTextBox";
            this.resolutionDateTextBox.ReadOnly = true;
            this.resolutionDateTextBox.Size = new System.Drawing.Size(120, 20);
            this.resolutionDateTextBox.TabIndex = 15;
            // 
            // creationDateTextBox
            // 
            this.creationDateTextBox.Location = new System.Drawing.Point(161, 176);
            this.creationDateTextBox.Name = "creationDateTextBox";
            this.creationDateTextBox.ReadOnly = true;
            this.creationDateTextBox.Size = new System.Drawing.Size(120, 20);
            this.creationDateTextBox.TabIndex = 14;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(161, 150);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(120, 20);
            this.typeTextBox.TabIndex = 13;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(161, 98);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(120, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(281, 46);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(30, 30);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.onDeleteIssueButtonClick);
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Location = new System.Drawing.Point(317, 46);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(30, 30);
            this.editButton.TabIndex = 10;
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
            this.detailsTitleBarPanel.Size = new System.Drawing.Size(350, 40);
            this.detailsTitleBarPanel.TabIndex = 9;
            // 
            // detailsTitle
            // 
            this.detailsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.resolveButton.AutoSize = true;
            this.resolveButton.Location = new System.Drawing.Point(105, 345);
            this.resolveButton.Name = "resolveButton";
            this.resolveButton.Size = new System.Drawing.Size(130, 30);
            this.resolveButton.TabIndex = 8;
            this.resolveButton.Text = "Marqué comme résolu";
            this.resolveButton.UseVisualStyleBackColor = true;
            this.resolveButton.Click += new System.EventHandler(this.onResolveIssueButtonClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(29, 283);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(29, 257);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(67, 13);
            this.stateLabel.TabIndex = 6;
            this.stateLabel.Text = "Avancement";
            // 
            // criticStateLabel
            // 
            this.criticStateLabel.AutoSize = true;
            this.criticStateLabel.Location = new System.Drawing.Point(29, 231);
            this.criticStateLabel.Name = "criticStateLabel";
            this.criticStateLabel.Size = new System.Drawing.Size(41, 13);
            this.criticStateLabel.TabIndex = 5;
            this.criticStateLabel.Text = "Criticité";
            // 
            // ResolutionDateLabel
            // 
            this.ResolutionDateLabel.AutoSize = true;
            this.ResolutionDateLabel.Location = new System.Drawing.Point(29, 205);
            this.ResolutionDateLabel.Name = "ResolutionDateLabel";
            this.ResolutionDateLabel.Size = new System.Drawing.Size(93, 13);
            this.ResolutionDateLabel.TabIndex = 4;
            this.ResolutionDateLabel.Text = "Date de résolution";
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Location = new System.Drawing.Point(29, 179);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(86, 13);
            this.creationDateLabel.TabIndex = 3;
            this.creationDateLabel.Text = "Date de création";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(29, 153);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Type";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(29, 101);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(57, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Référence";
            // 
            // IssuesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.addIssueButton);
            this.Controls.Add(this.issuesListView);
            this.Name = "IssuesUserControl";
            this.Controls.SetChildIndex(this.issuesListView, 0);
            this.Controls.SetChildIndex(this.addIssueButton, 0);
            this.Controls.SetChildIndex(this.detailsPanel, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.detailsTitleBarPanel.ResumeLayout(false);
            this.detailsTitleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView issuesListView;
        private System.Windows.Forms.Button addIssueButton;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel detailsTitleBarPanel;
        private System.Windows.Forms.Label detailsTitle;
        private System.Windows.Forms.Button resolveButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label criticStateLabel;
        private System.Windows.Forms.Label ResolutionDateLabel;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox criticStateTextBox;
        private System.Windows.Forms.TextBox resolutionDateTextBox;
        private System.Windows.Forms.TextBox creationDateTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox emplacementTextBox;
        private System.Windows.Forms.Label emplacementLabel;
    }
}
