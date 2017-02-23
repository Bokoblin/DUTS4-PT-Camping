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
            this.addStockButton = new System.Windows.Forms.Button();
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
            // 
            // addStockButton
            // 
            this.addStockButton.Location = new System.Drawing.Point(71, 262);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(134, 23);
            this.addStockButton.TabIndex = 12;
            this.addStockButton.Text = "Nouveau Stock";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addStockButton_MouseClick);
            // 
            // StocksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addStockButton);
            this.Controls.Add(this.ProductListView);
            this.Name = "StocksUserControl";
            this.Controls.SetChildIndex(this.ProductListView, 0);
            this.Controls.SetChildIndex(this.addStockButton, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProductListView;
        private System.Windows.Forms.Button addStockButton;
    }
}
