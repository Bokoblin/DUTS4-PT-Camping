namespace PT_Camping
{
    partial class StocksUserControl
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
            this.ProductListView = new System.Windows.Forms.ListView();
            this.ProductInformationPanel = new System.Windows.Forms.Panel();
            this.ProductInformationListView = new System.Windows.Forms.ListView();
            this.ProductInformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // ProductListView
            // 
            this.ProductListView.FullRowSelect = true;
            this.ProductListView.GridLines = true;
            this.ProductListView.Location = new System.Drawing.Point(44, 76);
            this.ProductListView.Name = "ProductListView";
            this.ProductListView.Size = new System.Drawing.Size(190, 148);
            this.ProductListView.TabIndex = 11;
            this.ProductListView.UseCompatibleStateImageBehavior = false;
            this.ProductListView.View = System.Windows.Forms.View.List;
            this.ProductListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductListView_MouseClick);
            // 
            // ProductInformationPanel
            // 
            this.ProductInformationPanel.BackColor = System.Drawing.Color.Aqua;
            this.ProductInformationPanel.Controls.Add(this.ProductInformationListView);
            this.ProductInformationPanel.Location = new System.Drawing.Point(384, 93);
            this.ProductInformationPanel.Name = "ProductInformationPanel";
            this.ProductInformationPanel.Size = new System.Drawing.Size(277, 169);
            this.ProductInformationPanel.TabIndex = 12;
            // 
            // ProductInformationListView
            // 
            this.ProductInformationListView.GridLines = true;
            this.ProductInformationListView.Location = new System.Drawing.Point(38, 22);
            this.ProductInformationListView.Name = "ProductInformationListView";
            this.ProductInformationListView.Size = new System.Drawing.Size(206, 97);
            this.ProductInformationListView.TabIndex = 0;
            this.ProductInformationListView.UseCompatibleStateImageBehavior = false;
            this.ProductInformationListView.View = System.Windows.Forms.View.List;
            // 
            // StocksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductInformationPanel);
            this.Controls.Add(this.ProductListView);
            this.Name = "StocksUserControl";
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.Controls.SetChildIndex(this.ProductListView, 0);
            this.Controls.SetChildIndex(this.ProductInformationPanel, 0);
            this.ProductInformationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProductListView;
        private System.Windows.Forms.Panel ProductInformationPanel;
        private System.Windows.Forms.ListView ProductInformationListView;
    }
}
