namespace PT_Camping.Views.Forms
{
    partial class AddProduct
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
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productStockTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productCriticStockLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonValid = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.productCriticStockTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(92, 41);
            this.productNameTextBox.MaxLength = 30;
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ShortcutsEnabled = false;
            this.productNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.productNameTextBox.TabIndex = 0;
            // 
            // productStockTextBox
            // 
            this.productStockTextBox.Location = new System.Drawing.Point(92, 87);
            this.productStockTextBox.MaxLength = 4;
            this.productStockTextBox.Name = "productStockTextBox";
            this.productStockTextBox.ShortcutsEnabled = false;
            this.productStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.productStockTextBox.TabIndex = 1;
            this.productStockTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductStockTextBox_KeyPress);
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(92, 167);
            this.productPriceTextBox.MaxLength = 7;
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.ShortcutsEnabled = false;
            this.productPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.productPriceTextBox.TabIndex = 3;
            this.productPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductPriceTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productCriticStockLabel
            // 
            this.productCriticStockLabel.AutoSize = true;
            this.productCriticStockLabel.Location = new System.Drawing.Point(124, 151);
            this.productCriticStockLabel.Name = "productCriticStockLabel";
            this.productCriticStockLabel.Size = new System.Drawing.Size(28, 13);
            this.productCriticStockLabel.TabIndex = 5;
            this.productCriticStockLabel.Text = "Prix*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantité*";
            // 
            // buttonValid
            // 
            this.buttonValid.Location = new System.Drawing.Point(168, 204);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(75, 23);
            this.buttonValid.TabIndex = 5;
            this.buttonValid.Text = "Valider";
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonValid_MouseClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(43, 204);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantité critique*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productCriticStockTextBox
            // 
            this.productCriticStockTextBox.Location = new System.Drawing.Point(92, 126);
            this.productCriticStockTextBox.MaxLength = 4;
            this.productCriticStockTextBox.Name = "productCriticStockTextBox";
            this.productCriticStockTextBox.ShortcutsEnabled = false;
            this.productCriticStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.productCriticStockTextBox.TabIndex = 2;
            this.productCriticStockTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductCriticStockTextBox_KeyPress);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.productCriticStockTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productCriticStockLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.productStockTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "AddProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productStockTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productCriticStockLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonValid;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productCriticStockTextBox;
    }
}