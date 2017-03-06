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
            this.nameF = new System.Windows.Forms.TextBox();
            this.mailF = new System.Windows.Forms.TextBox();
            this.adresseF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.webF = new System.Windows.Forms.TextBox();
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
            // nameF
            // 
            this.nameF.Location = new System.Drawing.Point(57, 32);
            this.nameF.Name = "nameF";
            this.nameF.Size = new System.Drawing.Size(156, 20);
            this.nameF.TabIndex = 39;
            // 
            // mailF
            // 
            this.mailF.Location = new System.Drawing.Point(57, 124);
            this.mailF.Name = "mailF";
            this.mailF.Size = new System.Drawing.Size(156, 20);
            this.mailF.TabIndex = 40;
            // 
            // adresseF
            // 
            this.adresseF.Location = new System.Drawing.Point(57, 78);
            this.adresseF.Name = "adresseF";
            this.adresseF.Size = new System.Drawing.Size(156, 20);
            this.adresseF.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "E-mail du fournisseur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 55);
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
            // webF
            // 
            this.webF.Location = new System.Drawing.Point(57, 170);
            this.webF.Name = "webF";
            this.webF.Size = new System.Drawing.Size(156, 20);
            this.webF.TabIndex = 45;
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
            this.Controls.Add(this.webF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adresseF);
            this.Controls.Add(this.mailF);
            this.Controls.Add(this.nameF);
            this.Controls.Add(this.criticalityLabel);
            this.Name = "AddProvider";
            this.Text = "AddProvider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label criticalityLabel;
        private System.Windows.Forms.TextBox nameF;
        private System.Windows.Forms.TextBox mailF;
        private System.Windows.Forms.TextBox adresseF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox webF;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}