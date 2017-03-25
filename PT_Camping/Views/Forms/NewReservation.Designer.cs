namespace PT_Camping.Views.Forms
{
    partial class NewReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.reservationHolderComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lodgersListBox = new System.Windows.Forms.ListBox();
            this.addReservationButton = new System.Windows.Forms.Button();
            this.addLocationButton = new System.Windows.Forms.Button();
            this.deleteLocationButton = new System.Windows.Forms.Button();
            this.removeLodgerButton = new System.Windows.Forms.Button();
            this.addLodgerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulaire de la reservation";
            // 
            // reservationHolderComboBox
            // 
            this.reservationHolderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.reservationHolderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.reservationHolderComboBox.FormattingEnabled = true;
            this.reservationHolderComboBox.Location = new System.Drawing.Point(15, 29);
            this.reservationHolderComboBox.Name = "reservationHolderComboBox";
            this.reservationHolderComboBox.Size = new System.Drawing.Size(200, 24);
            this.reservationHolderComboBox.TabIndex = 1;
            this.reservationHolderComboBox.TextChanged += new System.EventHandler(this.reservationHolderComboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date début";
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.Location = new System.Drawing.Point(15, 76);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.beginDateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date fin";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(15, 121);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endDateTimePicker.TabIndex = 5;
            // 
            // locationsListBox
            // 
            this.locationsListBox.FormattingEnabled = true;
            this.locationsListBox.ItemHeight = 16;
            this.locationsListBox.Location = new System.Drawing.Point(15, 166);
            this.locationsListBox.Name = "locationsListBox";
            this.locationsListBox.Size = new System.Drawing.Size(252, 212);
            this.locationsListBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Emplacements pris par ette réservation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Résidents de cet emplacement";
            // 
            // lodgersListBox
            // 
            this.lodgersListBox.FormattingEnabled = true;
            this.lodgersListBox.ItemHeight = 16;
            this.lodgersListBox.Location = new System.Drawing.Point(311, 167);
            this.lodgersListBox.Name = "lodgersListBox";
            this.lodgersListBox.Size = new System.Drawing.Size(266, 212);
            this.lodgersListBox.TabIndex = 9;
            // 
            // addReservationButton
            // 
            this.addReservationButton.Location = new System.Drawing.Point(219, 418);
            this.addReservationButton.Name = "addReservationButton";
            this.addReservationButton.Size = new System.Drawing.Size(143, 33);
            this.addReservationButton.TabIndex = 10;
            this.addReservationButton.Text = "Ajouter Réservation";
            this.addReservationButton.UseVisualStyleBackColor = true;
            this.addReservationButton.Click += new System.EventHandler(this.addReservationButton_Click);
            // 
            // addLocationButton
            // 
            this.addLocationButton.Location = new System.Drawing.Point(15, 385);
            this.addLocationButton.Name = "addLocationButton";
            this.addLocationButton.Size = new System.Drawing.Size(37, 23);
            this.addLocationButton.TabIndex = 11;
            this.addLocationButton.Text = "+";
            this.addLocationButton.UseVisualStyleBackColor = true;
            this.addLocationButton.Click += new System.EventHandler(this.addLocationButton_Click);
            // 
            // deleteLocationButton
            // 
            this.deleteLocationButton.Location = new System.Drawing.Point(58, 385);
            this.deleteLocationButton.Name = "deleteLocationButton";
            this.deleteLocationButton.Size = new System.Drawing.Size(38, 23);
            this.deleteLocationButton.TabIndex = 12;
            this.deleteLocationButton.Text = "-";
            this.deleteLocationButton.UseVisualStyleBackColor = true;
            this.deleteLocationButton.Click += new System.EventHandler(this.deleteLocationButton_Click);
            // 
            // removeLodgerButton
            // 
            this.removeLodgerButton.Location = new System.Drawing.Point(355, 385);
            this.removeLodgerButton.Name = "removeLodgerButton";
            this.removeLodgerButton.Size = new System.Drawing.Size(38, 23);
            this.removeLodgerButton.TabIndex = 14;
            this.removeLodgerButton.Text = "-";
            this.removeLodgerButton.UseVisualStyleBackColor = true;
            this.removeLodgerButton.Click += new System.EventHandler(this.removeLodgerButton_Click);
            // 
            // addLodgerButton
            // 
            this.addLodgerButton.Location = new System.Drawing.Point(312, 385);
            this.addLodgerButton.Name = "addLodgerButton";
            this.addLodgerButton.Size = new System.Drawing.Size(37, 23);
            this.addLodgerButton.TabIndex = 13;
            this.addLodgerButton.Text = "+";
            this.addLodgerButton.UseVisualStyleBackColor = true;
            this.addLodgerButton.Click += new System.EventHandler(this.addLodgerButton_Click);
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 463);
            this.Controls.Add(this.removeLodgerButton);
            this.Controls.Add(this.addLodgerButton);
            this.Controls.Add(this.deleteLocationButton);
            this.Controls.Add(this.addLocationButton);
            this.Controls.Add(this.addReservationButton);
            this.Controls.Add(this.lodgersListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.locationsListBox);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.beginDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reservationHolderComboBox);
            this.Controls.Add(this.label1);
            this.Name = "NewReservation";
            this.Text = "NewReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox reservationHolderComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.ListBox locationsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lodgersListBox;
        private System.Windows.Forms.Button addReservationButton;
        private System.Windows.Forms.Button addLocationButton;
        private System.Windows.Forms.Button deleteLocationButton;
        private System.Windows.Forms.Button removeLodgerButton;
        private System.Windows.Forms.Button addLodgerButton;
    }
}