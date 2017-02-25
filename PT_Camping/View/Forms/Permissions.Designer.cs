namespace PT_Camping
{
    partial class Permissions
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
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clientLabel = new System.Windows.Forms.Label();
            this.issuesLabel = new System.Windows.Forms.Label();
            this.employeesLabel = new System.Windows.Forms.Label();
            this.providersLabel = new System.Windows.Forms.Label();
            this.stocksLabel = new System.Windows.Forms.Label();
            this.mapLabel = new System.Windows.Forms.Label();
            this.readClients = new System.Windows.Forms.CheckBox();
            this.readIssues = new System.Windows.Forms.CheckBox();
            this.readEmployees = new System.Windows.Forms.CheckBox();
            this.readProviders = new System.Windows.Forms.CheckBox();
            this.readStocks = new System.Windows.Forms.CheckBox();
            this.readMap = new System.Windows.Forms.CheckBox();
            this.writeIssues = new System.Windows.Forms.CheckBox();
            this.writeClients = new System.Windows.Forms.CheckBox();
            this.writeEmployees = new System.Windows.Forms.CheckBox();
            this.writeProviders = new System.Windows.Forms.CheckBox();
            this.writeStocks = new System.Windows.Forms.CheckBox();
            this.writeMap = new System.Windows.Forms.CheckBox();
            this.readPermissionLabel = new System.Windows.Forms.Label();
            this.editPermissionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(190, 260);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "Valider";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.onOkButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(60, 260);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.onCancelButtonClick);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(29, 46);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(38, 13);
            this.clientLabel.TabIndex = 2;
            this.clientLabel.Text = "Clients";
            // 
            // issuesLabel
            // 
            this.issuesLabel.AutoSize = true;
            this.issuesLabel.Location = new System.Drawing.Point(29, 74);
            this.issuesLabel.Name = "issuesLabel";
            this.issuesLabel.Size = new System.Drawing.Size(50, 13);
            this.issuesLabel.TabIndex = 3;
            this.issuesLabel.Text = "Incidents";
            // 
            // employeesLabel
            // 
            this.employeesLabel.AutoSize = true;
            this.employeesLabel.Location = new System.Drawing.Point(29, 101);
            this.employeesLabel.Name = "employeesLabel";
            this.employeesLabel.Size = new System.Drawing.Size(52, 13);
            this.employeesLabel.TabIndex = 4;
            this.employeesLabel.Text = "Employés";
            // 
            // providersLabel
            // 
            this.providersLabel.AutoSize = true;
            this.providersLabel.Location = new System.Drawing.Point(29, 129);
            this.providersLabel.Name = "providersLabel";
            this.providersLabel.Size = new System.Drawing.Size(66, 13);
            this.providersLabel.TabIndex = 5;
            this.providersLabel.Text = "Fournisseurs";
            // 
            // stocksLabel
            // 
            this.stocksLabel.AutoSize = true;
            this.stocksLabel.Location = new System.Drawing.Point(29, 157);
            this.stocksLabel.Name = "stocksLabel";
            this.stocksLabel.Size = new System.Drawing.Size(40, 13);
            this.stocksLabel.TabIndex = 6;
            this.stocksLabel.Text = "Stocks";
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Location = new System.Drawing.Point(29, 186);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(32, 13);
            this.mapLabel.TabIndex = 7;
            this.mapLabel.Text = "Carte";
            // 
            // readClients
            // 
            this.readClients.AutoSize = true;
            this.readClients.Location = new System.Drawing.Point(155, 45);
            this.readClients.Name = "readClients";
            this.readClients.Size = new System.Drawing.Size(15, 14);
            this.readClients.TabIndex = 8;
            this.readClients.UseVisualStyleBackColor = true;
            this.readClients.CheckedChanged += new System.EventHandler(this.readClients_CheckedChanged);
            // 
            // readIssues
            // 
            this.readIssues.AutoSize = true;
            this.readIssues.Location = new System.Drawing.Point(155, 73);
            this.readIssues.Name = "readIssues";
            this.readIssues.Size = new System.Drawing.Size(15, 14);
            this.readIssues.TabIndex = 9;
            this.readIssues.UseVisualStyleBackColor = true;
            this.readIssues.CheckedChanged += new System.EventHandler(this.readIssues_CheckedChanged);
            // 
            // readEmployees
            // 
            this.readEmployees.AutoSize = true;
            this.readEmployees.Location = new System.Drawing.Point(155, 101);
            this.readEmployees.Name = "readEmployees";
            this.readEmployees.Size = new System.Drawing.Size(15, 14);
            this.readEmployees.TabIndex = 10;
            this.readEmployees.UseVisualStyleBackColor = true;
            this.readEmployees.CheckedChanged += new System.EventHandler(this.readEmployees_CheckedChanged);
            // 
            // readProviders
            // 
            this.readProviders.AutoSize = true;
            this.readProviders.Location = new System.Drawing.Point(155, 129);
            this.readProviders.Name = "readProviders";
            this.readProviders.Size = new System.Drawing.Size(15, 14);
            this.readProviders.TabIndex = 11;
            this.readProviders.UseVisualStyleBackColor = true;
            this.readProviders.CheckedChanged += new System.EventHandler(this.readProviders_CheckedChanged);
            // 
            // readStocks
            // 
            this.readStocks.AutoSize = true;
            this.readStocks.Location = new System.Drawing.Point(155, 157);
            this.readStocks.Name = "readStocks";
            this.readStocks.Size = new System.Drawing.Size(15, 14);
            this.readStocks.TabIndex = 12;
            this.readStocks.UseVisualStyleBackColor = true;
            this.readStocks.CheckedChanged += new System.EventHandler(this.readStocks_CheckedChanged);
            // 
            // readMap
            // 
            this.readMap.AutoSize = true;
            this.readMap.Location = new System.Drawing.Point(155, 186);
            this.readMap.Name = "readMap";
            this.readMap.Size = new System.Drawing.Size(15, 14);
            this.readMap.TabIndex = 13;
            this.readMap.UseVisualStyleBackColor = true;
            this.readMap.CheckedChanged += new System.EventHandler(this.readMap_CheckedChanged);
            // 
            // writeIssues
            // 
            this.writeIssues.AutoSize = true;
            this.writeIssues.Location = new System.Drawing.Point(246, 73);
            this.writeIssues.Name = "writeIssues";
            this.writeIssues.Size = new System.Drawing.Size(15, 14);
            this.writeIssues.TabIndex = 15;
            this.writeIssues.UseVisualStyleBackColor = true;
            this.writeIssues.CheckedChanged += new System.EventHandler(this.writeIssues_CheckedChanged);
            // 
            // writeClients
            // 
            this.writeClients.AutoSize = true;
            this.writeClients.Location = new System.Drawing.Point(246, 46);
            this.writeClients.Name = "writeClients";
            this.writeClients.Size = new System.Drawing.Size(15, 14);
            this.writeClients.TabIndex = 16;
            this.writeClients.UseVisualStyleBackColor = true;
            this.writeClients.CheckedChanged += new System.EventHandler(this.writeClients_CheckedChanged);
            // 
            // writeEmployees
            // 
            this.writeEmployees.AutoSize = true;
            this.writeEmployees.Location = new System.Drawing.Point(246, 101);
            this.writeEmployees.Name = "writeEmployees";
            this.writeEmployees.Size = new System.Drawing.Size(15, 14);
            this.writeEmployees.TabIndex = 17;
            this.writeEmployees.UseVisualStyleBackColor = true;
            this.writeEmployees.CheckedChanged += new System.EventHandler(this.writeEmployees_CheckedChanged);
            // 
            // writeProviders
            // 
            this.writeProviders.AutoSize = true;
            this.writeProviders.Location = new System.Drawing.Point(246, 129);
            this.writeProviders.Name = "writeProviders";
            this.writeProviders.Size = new System.Drawing.Size(15, 14);
            this.writeProviders.TabIndex = 18;
            this.writeProviders.UseVisualStyleBackColor = true;
            this.writeProviders.CheckedChanged += new System.EventHandler(this.writeProviders_CheckedChanged);
            // 
            // writeStocks
            // 
            this.writeStocks.AutoSize = true;
            this.writeStocks.Location = new System.Drawing.Point(246, 157);
            this.writeStocks.Name = "writeStocks";
            this.writeStocks.Size = new System.Drawing.Size(15, 14);
            this.writeStocks.TabIndex = 19;
            this.writeStocks.UseVisualStyleBackColor = true;
            this.writeStocks.CheckedChanged += new System.EventHandler(this.writeStocks_CheckedChanged);
            // 
            // writeMap
            // 
            this.writeMap.AutoSize = true;
            this.writeMap.Location = new System.Drawing.Point(246, 186);
            this.writeMap.Name = "writeMap";
            this.writeMap.Size = new System.Drawing.Size(15, 14);
            this.writeMap.TabIndex = 20;
            this.writeMap.UseVisualStyleBackColor = true;
            this.writeMap.CheckedChanged += new System.EventHandler(this.writeMap_CheckedChanged);
            // 
            // readPermissionLabel
            // 
            this.readPermissionLabel.AutoSize = true;
            this.readPermissionLabel.Location = new System.Drawing.Point(140, 22);
            this.readPermissionLabel.Name = "readPermissionLabel";
            this.readPermissionLabel.Size = new System.Drawing.Size(43, 13);
            this.readPermissionLabel.TabIndex = 21;
            this.readPermissionLabel.Text = "Lecture";
            // 
            // editPermissionLabel
            // 
            this.editPermissionLabel.AutoSize = true;
            this.editPermissionLabel.Location = new System.Drawing.Point(220, 22);
            this.editPermissionLabel.Name = "editPermissionLabel";
            this.editPermissionLabel.Size = new System.Drawing.Size(64, 13);
            this.editPermissionLabel.TabIndex = 22;
            this.editPermissionLabel.Text = "Modification";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Les permissions  MODIFICATION nécessitent LECTURE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Permissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editPermissionLabel);
            this.Controls.Add(this.readPermissionLabel);
            this.Controls.Add(this.writeMap);
            this.Controls.Add(this.writeStocks);
            this.Controls.Add(this.writeProviders);
            this.Controls.Add(this.writeEmployees);
            this.Controls.Add(this.writeClients);
            this.Controls.Add(this.writeIssues);
            this.Controls.Add(this.readMap);
            this.Controls.Add(this.readStocks);
            this.Controls.Add(this.readProviders);
            this.Controls.Add(this.readEmployees);
            this.Controls.Add(this.readIssues);
            this.Controls.Add(this.readClients);
            this.Controls.Add(this.mapLabel);
            this.Controls.Add(this.stocksLabel);
            this.Controls.Add(this.providersLabel);
            this.Controls.Add(this.employeesLabel);
            this.Controls.Add(this.issuesLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Permissions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permissions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label issuesLabel;
        private System.Windows.Forms.Label employeesLabel;
        private System.Windows.Forms.Label providersLabel;
        private System.Windows.Forms.Label stocksLabel;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.CheckBox readClients;
        private System.Windows.Forms.CheckBox readIssues;
        private System.Windows.Forms.CheckBox readEmployees;
        private System.Windows.Forms.CheckBox readProviders;
        private System.Windows.Forms.CheckBox readStocks;
        private System.Windows.Forms.CheckBox readMap;
        private System.Windows.Forms.CheckBox writeIssues;
        private System.Windows.Forms.CheckBox writeClients;
        private System.Windows.Forms.CheckBox writeEmployees;
        private System.Windows.Forms.CheckBox writeProviders;
        private System.Windows.Forms.CheckBox writeStocks;
        private System.Windows.Forms.CheckBox writeMap;
        private System.Windows.Forms.Label readPermissionLabel;
        private System.Windows.Forms.Label editPermissionLabel;
        private System.Windows.Forms.Label label1;
    }
}