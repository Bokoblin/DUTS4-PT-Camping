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
            this.nbPersColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ispayedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.locationsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lodgerList = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newReservationButton
            // 
            this.newReservationButton.Location = new System.Drawing.Point(163, 307);
            this.newReservationButton.Margin = new System.Windows.Forms.Padding(2);
            this.newReservationButton.Name = "newReservationButton";
            this.newReservationButton.Size = new System.Drawing.Size(122, 26);
            this.newReservationButton.TabIndex = 1;
            this.newReservationButton.Text = "Nouvelle Réservation";
            this.newReservationButton.UseVisualStyleBackColor = true;
            this.newReservationButton.Click += new System.EventHandler(this.NewReservationButton_Click);
            // 
            // deleteReservationButton
            // 
            this.deleteReservationButton.Location = new System.Drawing.Point(12, 306);
            this.deleteReservationButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteReservationButton.Name = "deleteReservationButton";
            this.deleteReservationButton.Size = new System.Drawing.Size(66, 26);
            this.deleteReservationButton.TabIndex = 2;
            this.deleteReservationButton.Text = "Supprimer";
            this.deleteReservationButton.UseVisualStyleBackColor = true;
            this.deleteReservationButton.Click += new System.EventHandler(this.DeleteReservationButton_Click);
            // 
            // factureButton
            // 
            this.factureButton.Location = new System.Drawing.Point(289, 306);
            this.factureButton.Margin = new System.Windows.Forms.Padding(2);
            this.factureButton.Name = "factureButton";
            this.factureButton.Size = new System.Drawing.Size(128, 26);
            this.factureButton.TabIndex = 3;
            this.factureButton.Text = "Télécharger la facture";
            this.factureButton.UseVisualStyleBackColor = true;
            this.factureButton.Click += new System.EventHandler(this.FactureButton_Click);
            // 
            // reservationsList
            // 
            this.reservationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.beginDateColumnHeader,
            this.endDateColumnHeader,
            this.nbPersColumnHeader,
            this.ispayedColumnHeader});
            this.reservationsList.FullRowSelect = true;
            this.reservationsList.GridLines = true;
            this.reservationsList.Location = new System.Drawing.Point(10, 28);
            this.reservationsList.Margin = new System.Windows.Forms.Padding(2);
            this.reservationsList.MultiSelect = false;
            this.reservationsList.Name = "reservationsList";
            this.reservationsList.Size = new System.Drawing.Size(400, 262);
            this.reservationsList.TabIndex = 4;
            this.reservationsList.UseCompatibleStateImageBehavior = false;
            this.reservationsList.View = System.Windows.Forms.View.Details;
            this.reservationsList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ReservationsList_ItemSelectionChanged);
            // 
            // beginDateColumnHeader
            // 
            this.beginDateColumnHeader.Text = "Date Début";
            this.beginDateColumnHeader.Width = 145;
            // 
            // endDateColumnHeader
            // 
            this.endDateColumnHeader.Text = "Date Fin";
            this.endDateColumnHeader.Width = 162;
            // 
            // nbPersColumnHeader
            // 
            this.nbPersColumnHeader.DisplayIndex = 3;
            this.nbPersColumnHeader.Text = "Nombre personnes";
            this.nbPersColumnHeader.Width = 134;
            // 
            // ispayedColumnHeader
            // 
            this.ispayedColumnHeader.DisplayIndex = 2;
            this.ispayedColumnHeader.Text = "Est payée";
            this.ispayedColumnHeader.Width = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste des emplacements :";
            // 
            // locationsList
            // 
            this.locationsList.FormattingEnabled = true;
            this.locationsList.Location = new System.Drawing.Point(417, 25);
            this.locationsList.Margin = new System.Windows.Forms.Padding(2);
            this.locationsList.Name = "locationsList";
            this.locationsList.Size = new System.Drawing.Size(153, 121);
            this.locationsList.TabIndex = 6;
            this.locationsList.SelectedIndexChanged += new System.EventHandler(this.LocationsList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Liste des locataires :";
            // 
            // lodgerList
            // 
            this.lodgerList.FormattingEnabled = true;
            this.lodgerList.Location = new System.Drawing.Point(417, 168);
            this.lodgerList.Margin = new System.Windows.Forms.Padding(2);
            this.lodgerList.Name = "lodgerList";
            this.lodgerList.Size = new System.Drawing.Size(153, 121);
            this.lodgerList.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(10, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(127, 13);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Liste des réservations de ";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(83, 306);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 27);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Modifier";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(491, 306);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 27);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.Text = "Actualiser";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.lodgerList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservationsList);
            this.Controls.Add(this.factureButton);
            this.Controls.Add(this.deleteReservationButton);
            this.Controls.Add(this.newReservationButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Reservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newReservationButton;
        private System.Windows.Forms.Button deleteReservationButton;
        private System.Windows.Forms.Button factureButton;
        private System.Windows.Forms.ListView reservationsList;
        private System.Windows.Forms.ColumnHeader beginDateColumnHeader;
        private System.Windows.Forms.ColumnHeader endDateColumnHeader;
        private System.Windows.Forms.ColumnHeader ispayedColumnHeader;
        private System.Windows.Forms.ColumnHeader nbPersColumnHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox locationsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lodgerList;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button refreshButton;
    }
}