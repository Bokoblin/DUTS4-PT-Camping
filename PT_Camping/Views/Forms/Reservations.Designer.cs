namespace PT_Camping.Views.Forms
{
    partial class Reservations
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
            this.newReservationButton = new System.Windows.Forms.Button();
            this.deleteReservationButton = new System.Windows.Forms.Button();
            this.factureButton = new System.Windows.Forms.Button();
            this.reservationsList = new System.Windows.Forms.ListView();
            this.beginDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ispayedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nbPersColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // newReservationButton
            // 
            this.newReservationButton.Location = new System.Drawing.Point(185, 365);
            this.newReservationButton.Name = "newReservationButton";
            this.newReservationButton.Size = new System.Drawing.Size(162, 23);
            this.newReservationButton.TabIndex = 1;
            this.newReservationButton.Text = "Nouvelle Réservation";
            this.newReservationButton.UseVisualStyleBackColor = true;
            this.newReservationButton.Click += new System.EventHandler(this.newReservationButton_Click);
            // 
            // deleteReservationButton
            // 
            this.deleteReservationButton.Location = new System.Drawing.Point(42, 365);
            this.deleteReservationButton.Name = "deleteReservationButton";
            this.deleteReservationButton.Size = new System.Drawing.Size(88, 23);
            this.deleteReservationButton.TabIndex = 2;
            this.deleteReservationButton.Text = "Supprimer";
            this.deleteReservationButton.UseVisualStyleBackColor = true;
            this.deleteReservationButton.Click += new System.EventHandler(this.deleteReservationButton_Click);
            // 
            // factureButton
            // 
            this.factureButton.Location = new System.Drawing.Point(409, 365);
            this.factureButton.Name = "factureButton";
            this.factureButton.Size = new System.Drawing.Size(171, 23);
            this.factureButton.TabIndex = 3;
            this.factureButton.Text = "Télécharger la facture";
            this.factureButton.UseVisualStyleBackColor = true;
            this.factureButton.Click += new System.EventHandler(this.factureButton_Click);
            // 
            // reservationsList
            // 
            this.reservationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.beginDateColumnHeader,
            this.endDateColumnHeader,
            this.locationNameColumnHeader,
            this.nbPersColumnHeader,
            this.ispayedColumnHeader});
            this.reservationsList.Location = new System.Drawing.Point(13, 13);
            this.reservationsList.Name = "reservationsList";
            this.reservationsList.Size = new System.Drawing.Size(615, 346);
            this.reservationsList.TabIndex = 4;
            this.reservationsList.UseCompatibleStateImageBehavior = false;
            // 
            // beginDateColumnHeader
            // 
            this.beginDateColumnHeader.Text = "Date Début";
            // 
            // endDateColumnHeader
            // 
            this.endDateColumnHeader.Text = "Date Fin";
            // 
            // locationNameColumnHeader
            // 
            this.locationNameColumnHeader.Text = "Nom Emplacement";
            // 
            // ispayedColumnHeader
            // 
            this.ispayedColumnHeader.DisplayIndex = 3;
            this.ispayedColumnHeader.Text = "Est payée";
            // 
            // nbPersColumnHeader
            // 
            this.nbPersColumnHeader.DisplayIndex = 4;
            this.nbPersColumnHeader.Text = "Nombre personnes";
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 400);
            this.Controls.Add(this.reservationsList);
            this.Controls.Add(this.factureButton);
            this.Controls.Add(this.deleteReservationButton);
            this.Controls.Add(this.newReservationButton);
            this.Name = "Reservations";
            this.Text = "Reservations";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newReservationButton;
        private System.Windows.Forms.Button deleteReservationButton;
        private System.Windows.Forms.Button factureButton;
        private System.Windows.Forms.ListView reservationsList;
        private System.Windows.Forms.ColumnHeader beginDateColumnHeader;
        private System.Windows.Forms.ColumnHeader endDateColumnHeader;
        private System.Windows.Forms.ColumnHeader locationNameColumnHeader;
        private System.Windows.Forms.ColumnHeader ispayedColumnHeader;
        private System.Windows.Forms.ColumnHeader nbPersColumnHeader;
    }
}