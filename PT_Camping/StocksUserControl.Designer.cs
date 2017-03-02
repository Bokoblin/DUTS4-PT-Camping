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
            this.components = new System.ComponentModel.Container();
            this.ProductListView = new System.Windows.Forms.ListView();
            this.addStockButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.informationsLabel = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.amountProductLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.productProviderButton = new System.Windows.Forms.Button();
            this.commandButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.ProductListView.SelectedIndexChanged += new System.EventHandler(this.ProductListView_SelectedIndexChanged);
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
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(404, 139);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 13;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(404, 246);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 14;
            // 
            // informationsLabel
            // 
            this.informationsLabel.AutoSize = true;
            this.informationsLabel.Location = new System.Drawing.Point(437, 108);
            this.informationsLabel.Name = "informationsLabel";
            this.informationsLabel.Size = new System.Drawing.Size(150, 13);
            this.informationsLabel.TabIndex = 16;
            this.informationsLabel.Text = "Informations Complémentaires ";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(363, 139);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(32, 13);
            this.productCodeLabel.TabIndex = 17;
            this.productCodeLabel.Text = "Code";
            // 
            // amountProductLabel
            // 
            this.amountProductLabel.AutoSize = true;
            this.amountProductLabel.Location = new System.Drawing.Point(348, 211);
            this.amountProductLabel.Name = "amountProductLabel";
            this.amountProductLabel.Size = new System.Drawing.Size(47, 13);
            this.amountProductLabel.TabIndex = 18;
            this.amountProductLabel.Text = "Quantité";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(363, 253);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(24, 13);
            this.priceLabel.TabIndex = 19;
            this.priceLabel.Text = "Prix";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(363, 180);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(29, 13);
            this.ProductNameLabel.TabIndex = 20;
            this.ProductNameLabel.Text = "Nom";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(404, 177);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.productNameTextBox.TabIndex = 21;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(628, 76);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(124, 23);
            this.deleteProductButton.TabIndex = 22;
            this.deleteProductButton.Text = "Supprimer le produit";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // editProductButton
            // 
            this.editProductButton.Location = new System.Drawing.Point(351, 297);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(75, 23);
            this.editProductButton.TabIndex = 23;
            this.editProductButton.Text = "Modifier";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(458, 297);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 24;
            this.resetButton.Text = "Annuler";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // productProviderButton
            // 
            this.productProviderButton.Location = new System.Drawing.Point(551, 169);
            this.productProviderButton.Name = "productProviderButton";
            this.productProviderButton.Size = new System.Drawing.Size(75, 23);
            this.productProviderButton.TabIndex = 25;
            this.productProviderButton.Text = "Fournisseur";
            this.productProviderButton.UseVisualStyleBackColor = true;
            this.productProviderButton.Click += new System.EventHandler(this.productProviderButton_Click);
            // 
            // commandButton
            // 
            this.commandButton.Location = new System.Drawing.Point(641, 246);
            this.commandButton.Name = "commandButton";
            this.commandButton.Size = new System.Drawing.Size(75, 23);
            this.commandButton.TabIndex = 26;
            this.commandButton.Text = "Commander";
            this.commandButton.UseVisualStyleBackColor = true;
            this.commandButton.Click += new System.EventHandler(this.commandButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(404, 211);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // StocksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.commandButton);
            this.Controls.Add(this.productProviderButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.amountProductLabel);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.informationsLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.addStockButton);
            this.Controls.Add(this.ProductListView);
            this.Name = "StocksUserControl";
            this.Controls.SetChildIndex(this.ProductListView, 0);
            this.Controls.SetChildIndex(this.addStockButton, 0);
            this.Controls.SetChildIndex(this.idTextBox, 0);
            this.Controls.SetChildIndex(this.priceTextBox, 0);
            this.Controls.SetChildIndex(this.informationsLabel, 0);
            this.Controls.SetChildIndex(this.productCodeLabel, 0);
            this.Controls.SetChildIndex(this.amountProductLabel, 0);
            this.Controls.SetChildIndex(this.priceLabel, 0);
            this.Controls.SetChildIndex(this.ProductNameLabel, 0);
            this.Controls.SetChildIndex(this.productNameTextBox, 0);
            this.Controls.SetChildIndex(this.deleteProductButton, 0);
            this.Controls.SetChildIndex(this.editProductButton, 0);
            this.Controls.SetChildIndex(this.resetButton, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.Controls.SetChildIndex(this.productProviderButton, 0);
            this.Controls.SetChildIndex(this.commandButton, 0);
            this.Controls.SetChildIndex(this.amountTextBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProductListView;
        private System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label informationsLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label amountProductLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button productProviderButton;
        private System.Windows.Forms.Button commandButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
