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
            this.DataGridViewProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // DataGridViewProduct
            // 
            this.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProduct.Location = new System.Drawing.Point(26, 78);
            this.DataGridViewProduct.Name = "DataGridViewProduct";
            this.DataGridViewProduct.Size = new System.Drawing.Size(320, 466);
            this.DataGridViewProduct.TabIndex = 10;
            // 
            // StocksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridViewProduct);
            this.Name = "StocksUserControl";
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.Controls.SetChildIndex(this.DataGridViewProduct, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewProduct;
    }
}
