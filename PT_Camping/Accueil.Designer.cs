namespace PT_Camping
{
    partial class Accueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelMenuStrip = new System.Windows.Forms.Label();
            this.AccueilTabControl = new System.Windows.Forms.TabControl();
            this.GestionTab = new System.Windows.Forms.TabPage();
            this.CarteTab = new System.Windows.Forms.TabPage();
            this.stagiaireBouton = new System.Windows.Forms.Button();
            this.incidentsBouton = new System.Windows.Forms.Button();
            this.clientBouton = new System.Windows.Forms.Button();
            this.stocksBouton = new System.Windows.Forms.Button();
            this.statsBouton = new System.Windows.Forms.Button();
            this.fournisseursBouton = new System.Windows.Forms.Button();
            this.AccueilTabControl.SuspendLayout();
            this.GestionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 50);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelMenuStrip
            // 
            this.labelMenuStrip.AutoSize = true;
            this.labelMenuStrip.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuStrip.ForeColor = System.Drawing.Color.White;
            this.labelMenuStrip.Location = new System.Drawing.Point(40, 15);
            this.labelMenuStrip.Name = "labelMenuStrip";
            this.labelMenuStrip.Size = new System.Drawing.Size(60, 20);
            this.labelMenuStrip.TabIndex = 3;
            this.labelMenuStrip.Text = "Accueil";
            // 
            // tabControl1
            // 
            this.AccueilTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccueilTabControl.Controls.Add(this.GestionTab);
            this.AccueilTabControl.Controls.Add(this.CarteTab);
            this.AccueilTabControl.ItemSize = new System.Drawing.Size(100, 20);
            this.AccueilTabControl.Location = new System.Drawing.Point(0, 53);
            this.AccueilTabControl.Name = "tabControl1";
            this.AccueilTabControl.Padding = new System.Drawing.Point(50, 3);
            this.AccueilTabControl.SelectedIndex = 0;
            this.AccueilTabControl.Size = new System.Drawing.Size(784, 496);
            this.AccueilTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AccueilTabControl.TabIndex = 6;
            // 
            // GestionTab
            // 
            this.GestionTab.Controls.Add(this.fournisseursBouton);
            this.GestionTab.Controls.Add(this.statsBouton);
            this.GestionTab.Controls.Add(this.stocksBouton);
            this.GestionTab.Controls.Add(this.stagiaireBouton);
            this.GestionTab.Controls.Add(this.incidentsBouton);
            this.GestionTab.Controls.Add(this.clientBouton);
            this.GestionTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionTab.Location = new System.Drawing.Point(4, 24);
            this.GestionTab.Name = "GestionTab";
            this.GestionTab.Size = new System.Drawing.Size(776, 468);
            this.GestionTab.TabIndex = 0;
            this.GestionTab.Text = "GESTION";
            this.GestionTab.UseVisualStyleBackColor = true;
            // 
            // CarteTab
            // 
            this.CarteTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarteTab.Location = new System.Drawing.Point(4, 24);
            this.CarteTab.Name = "CarteTab";
            this.CarteTab.Size = new System.Drawing.Size(776, 468);
            this.CarteTab.TabIndex = 1;
            this.CarteTab.Text = "CARTE";
            this.CarteTab.UseVisualStyleBackColor = true;
            // 
            // stagiaireBouton
            // 
            this.stagiaireBouton.Location = new System.Drawing.Point(113, 225);
            this.stagiaireBouton.Name = "stagiaireBouton";
            this.stagiaireBouton.Size = new System.Drawing.Size(169, 64);
            this.stagiaireBouton.TabIndex = 8;
            this.stagiaireBouton.Text = "STAGIAIRES";
            this.stagiaireBouton.UseVisualStyleBackColor = true;
            // 
            // incidentsBouton
            // 
            this.incidentsBouton.Location = new System.Drawing.Point(468, 83);
            this.incidentsBouton.Name = "incidentsBouton";
            this.incidentsBouton.Size = new System.Drawing.Size(169, 64);
            this.incidentsBouton.TabIndex = 7;
            this.incidentsBouton.Text = "INCIDENTS";
            this.incidentsBouton.UseVisualStyleBackColor = true;
            // 
            // clientBouton
            // 
            this.clientBouton.Location = new System.Drawing.Point(113, 83);
            this.clientBouton.Name = "clientBouton";
            this.clientBouton.Size = new System.Drawing.Size(169, 64);
            this.clientBouton.TabIndex = 6;
            this.clientBouton.Text = "CLIENTS";
            this.clientBouton.UseVisualStyleBackColor = true;
            // 
            // stocksBouton
            // 
            this.stocksBouton.Location = new System.Drawing.Point(468, 225);
            this.stocksBouton.Name = "stocksBouton";
            this.stocksBouton.Size = new System.Drawing.Size(169, 64);
            this.stocksBouton.TabIndex = 9;
            this.stocksBouton.Text = "STOCKS";
            this.stocksBouton.UseVisualStyleBackColor = true;
            // 
            // statsBouton
            // 
            this.statsBouton.Location = new System.Drawing.Point(468, 362);
            this.statsBouton.Name = "statsBouton";
            this.statsBouton.Size = new System.Drawing.Size(169, 64);
            this.statsBouton.TabIndex = 10;
            this.statsBouton.Text = "STATS";
            this.statsBouton.UseVisualStyleBackColor = true;
            // 
            // fournisseursBouton
            // 
            this.fournisseursBouton.Location = new System.Drawing.Point(113, 362);
            this.fournisseursBouton.Name = "fournisseursBouton";
            this.fournisseursBouton.Size = new System.Drawing.Size(169, 64);
            this.fournisseursBouton.TabIndex = 11;
            this.fournisseursBouton.Text = "FOURNISSEURS";
            this.fournisseursBouton.UseVisualStyleBackColor = true;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.AccueilTabControl);
            this.Controls.Add(this.labelMenuStrip);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.AccueilTabControl.ResumeLayout(false);
            this.GestionTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelMenuStrip;
        private System.Windows.Forms.TabControl AccueilTabControl;
        private System.Windows.Forms.TabPage GestionTab;
        private System.Windows.Forms.TabPage CarteTab;
        private System.Windows.Forms.Button stagiaireBouton;
        private System.Windows.Forms.Button incidentsBouton;
        private System.Windows.Forms.Button clientBouton;
        private System.Windows.Forms.Button fournisseursBouton;
        private System.Windows.Forms.Button statsBouton;
        private System.Windows.Forms.Button stocksBouton;
    }
}