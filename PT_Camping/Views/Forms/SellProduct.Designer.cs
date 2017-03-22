namespace PT_Camping.Views.Forms
{
    partial class SellProduct
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
            this.textLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.validButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(52, 53);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(132, 13);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Entrer la quantité à vendre";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(65, 85);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 1;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTextBox_KeyPress);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(29, 163);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // validButton
            // 
            this.validButton.Location = new System.Drawing.Point(134, 163);
            this.validButton.Name = "validButton";
            this.validButton.Size = new System.Drawing.Size(75, 23);
            this.validButton.TabIndex = 3;
            this.validButton.Text = "Valider";
            this.validButton.UseVisualStyleBackColor = true;
            this.validButton.Click += new System.EventHandler(this.ValidButton_Click);
            // 
            // SellStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.validButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.textLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 250);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "SellStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button validButton;
    }
}