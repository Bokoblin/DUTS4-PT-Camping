namespace PT_Camping.View.Forms
{
    partial class AddProvider
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
            this.criticalityLabel = new System.Windows.Forms.Label();
            this.nameP = new System.Windows.Forms.TextBox();
            this.mailP = new System.Windows.Forms.TextBox();
            this.adresseP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.webP = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // criticalityLabel
            // 
            this.criticalityLabel.Location = new System.Drawing.Point(12, 9);
            this.criticalityLabel.Name = "criticalityLabel";
            this.criticalityLabel.Size = new System.Drawing.Size(240, 20);
            this.criticalityLabel.TabIndex = 38;
            this.criticalityLabel.Text = "Nom du fournisseur";
            this.criticalityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameP
            // 
            this.nameP.Location = new System.Drawing.Point(57, 32);
            this.nameP.Name = "nameP";
            this.nameP.Size = new System.Drawing.Size(156, 20);
            this.nameP.TabIndex = 39;
            // 
            // mailP
            // 
            this.mailP.Location = new System.Drawing.Point(57, 78);
            this.mailP.Name = "mailP";
            this.mailP.Size = new System.Drawing.Size(156, 20);
            this.mailP.TabIndex = 40;
            // 
            // adresseP
            // 
            this.adresseP.Location = new System.Drawing.Point(57, 124);
            this.adresseP.Name = "adresseP";
            this.adresseP.Size = new System.Drawing.Size(156, 20);
            this.adresseP.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "E-mail du fournisseur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Adresse du fournisseur";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Site web du fournisseur";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webP
            // 
            this.webP.Location = new System.Drawing.Point(57, 170);
            this.webP.Name = "webP";
            this.webP.Size = new System.Drawing.Size(156, 20);
            this.webP.TabIndex = 45;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(15, 215);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 25);
            this.cancelButton.TabIndex = 46;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(172, 215);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(80, 25);
            this.OKButton.TabIndex = 47;
            this.OKButton.Text = "Valider";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AddProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.webP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adresseP);
            this.Controls.Add(this.mailP);
            this.Controls.Add(this.nameP);
            this.Controls.Add(this.criticalityLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddProvider";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProvider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label criticalityLabel;
        private System.Windows.Forms.TextBox nameP;
        private System.Windows.Forms.TextBox mailP;
        private System.Windows.Forms.TextBox adresseP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox webP;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}