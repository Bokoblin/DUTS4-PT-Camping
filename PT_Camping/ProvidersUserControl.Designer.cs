namespace PT_Camping
{
    partial class ProvidersUserControl
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
            this.listF = new System.Windows.Forms.DataGridView();
            this.detailsF = new System.Windows.Forms.ListView();
            this.modif = new System.Windows.Forms.Button();
            this.contact = new System.Windows.Forms.Button();
            this.newF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listF)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // listF
            // 
            this.listF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listF.Location = new System.Drawing.Point(68, 75);
            this.listF.Name = "listF";
            this.listF.Size = new System.Drawing.Size(255, 446);
            this.listF.TabIndex = 11;
            this.listF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listF_CellClick);
            // 
            // detailsF
            // 
            this.detailsF.Location = new System.Drawing.Point(443, 120);
            this.detailsF.Name = "detailsF";
            this.detailsF.Size = new System.Drawing.Size(307, 262);
            this.detailsF.TabIndex = 12;
            this.detailsF.UseCompatibleStateImageBehavior = false;
            // 
            // modif
            // 
            this.modif.Location = new System.Drawing.Point(615, 420);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(135, 54);
            this.modif.TabIndex = 13;
            this.modif.Text = "Modifier";
            this.modif.UseVisualStyleBackColor = true;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(443, 420);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(135, 54);
            this.contact.TabIndex = 14;
            this.contact.Text = "Contacter";
            this.contact.UseVisualStyleBackColor = true;
            // 
            // newF
            // 
            this.newF.Location = new System.Drawing.Point(92, 542);
            this.newF.Name = "newF";
            this.newF.Size = new System.Drawing.Size(200, 30);
            this.newF.TabIndex = 15;
            this.newF.Text = "Nouveau fournisseur";
            this.newF.UseVisualStyleBackColor = true;
            // 
            // ProvidersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newF);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.modif);
            this.Controls.Add(this.detailsF);
            this.Controls.Add(this.listF);
            this.Name = "ProvidersUserControl";
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.Controls.SetChildIndex(this.listF, 0);
            this.Controls.SetChildIndex(this.detailsF, 0);
            this.Controls.SetChildIndex(this.modif, 0);
            this.Controls.SetChildIndex(this.contact, 0);
            this.Controls.SetChildIndex(this.newF, 0);
            ((System.ComponentModel.ISupportInitialize)(this.listF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listF;
        private System.Windows.Forms.ListView detailsF;
        private System.Windows.Forms.Button modif;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Button newF;
    }
}
