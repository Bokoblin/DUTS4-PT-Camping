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
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.ProductListView = new System.Windows.Forms.ListView();
            this.Nom_Produit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.Location = new System.Drawing.Point(143, 482);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(109, 23);
            this.buttonAddStock.TabIndex = 11;
            this.buttonAddStock.Text = "Nouveau Stock";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAddStock_MouseClick);
            // 
            // ProductListView
            // 
            this.ProductListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom_Produit});
            this.ProductListView.GridLines = true;
            this.ProductListView.Location = new System.Drawing.Point(93, 109);
            this.ProductListView.Name = "ProductListView";
            this.ProductListView.Size = new System.Drawing.Size(178, 318);
            this.ProductListView.TabIndex = 12;
            this.ProductListView.UseCompatibleStateImageBehavior = false;
            this.ProductListView.View = System.Windows.Forms.View.List;
            // 
            // StocksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductListView);
            this.Controls.Add(this.buttonAddStock);
            this.Name = "StocksUserControl";
            this.Controls.SetChildIndex(this.buttonAddStock, 0);
            this.Controls.SetChildIndex(this.ProductListView, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.ListView ProductListView;
        private System.Windows.Forms.ColumnHeader Nom_Produit;
    }
}
