namespace PT_Camping
{
    partial class Window
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.windowPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // windowPanel
            // 
            this.windowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPanel.Location = new System.Drawing.Point(0, 0);
            this.windowPanel.MinimumSize = new System.Drawing.Size(784, 600);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Size = new System.Drawing.Size(784, 600);
            this.windowPanel.TabIndex = 0;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.windowPanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PT4-BJJMR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel windowPanel;
    }
}

