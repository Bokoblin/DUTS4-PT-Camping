namespace PT_Camping.View.Forms
{
    partial class Reductions
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
            this.seniority = new System.Windows.Forms.Label();
            this.ValidReducbutton = new System.Windows.Forms.Button();
            this.percentageSeniorLabel = new System.Windows.Forms.Label();
            this.ReducBox = new System.Windows.Forms.GroupBox();
            this.radioEtudiantButton = new System.Windows.Forms.RadioButton();
            this.radioFamilyButton = new System.Windows.Forms.RadioButton();
            this.radioGroupButton = new System.Windows.Forms.RadioButton();
            this.radioSeniorButton = new System.Windows.Forms.RadioButton();
            this.ReducBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // seniority
            // 
            this.seniority.AutoSize = true;
            this.seniority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniority.Location = new System.Drawing.Point(59, 213);
            this.seniority.Name = "seniority";
            this.seniority.Size = new System.Drawing.Size(111, 25);
            this.seniority.TabIndex = 8;
            this.seniority.Text = "Ancienneté";
            // 
            // ValidReducbutton
            // 
            this.ValidReducbutton.Location = new System.Drawing.Point(108, 267);
            this.ValidReducbutton.Name = "ValidReducbutton";
            this.ValidReducbutton.Size = new System.Drawing.Size(123, 36);
            this.ValidReducbutton.TabIndex = 9;
            this.ValidReducbutton.Text = "Valider";
            this.ValidReducbutton.UseVisualStyleBackColor = true;
            // 
            // percentageSeniorLabel
            // 
            this.percentageSeniorLabel.BackColor = System.Drawing.Color.White;
            this.percentageSeniorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percentageSeniorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentageSeniorLabel.Location = new System.Drawing.Point(228, 218);
            this.percentageSeniorLabel.Name = "percentageSeniorLabel";
            this.percentageSeniorLabel.Size = new System.Drawing.Size(36, 20);
            this.percentageSeniorLabel.TabIndex = 10;
            //
            // ReducBox
            // 
            this.ReducBox.Controls.Add(this.radioSeniorButton);
            this.ReducBox.Controls.Add(this.radioGroupButton);
            this.ReducBox.Controls.Add(this.radioFamilyButton);
            this.ReducBox.Controls.Add(this.radioEtudiantButton);
            this.ReducBox.Location = new System.Drawing.Point(64, 24);
            this.ReducBox.Name = "ReducBox";
            this.ReducBox.Size = new System.Drawing.Size(200, 167);
            this.ReducBox.TabIndex = 11;
            this.ReducBox.TabStop = false;
            this.ReducBox.MouseCaptureChanged += new System.EventHandler(this.ReducButtonSelected);
            // 
            // radioEtudiantButton
            // 
            this.radioEtudiantButton.AutoSize = true;
            this.radioEtudiantButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioEtudiantButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioEtudiantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEtudiantButton.Location = new System.Drawing.Point(44, 21);
            this.radioEtudiantButton.Name = "radioEtudiantButton";
            this.radioEtudiantButton.Size = new System.Drawing.Size(104, 29);
            this.radioEtudiantButton.TabIndex = 0;
            this.radioEtudiantButton.TabStop = true;
            this.radioEtudiantButton.Text = "Etudiant";
            this.radioEtudiantButton.UseVisualStyleBackColor = true;
            // 
            // radioFamilyButton
            // 
            this.radioFamilyButton.AutoSize = true;
            this.radioFamilyButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioFamilyButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioFamilyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFamilyButton.Location = new System.Drawing.Point(53, 91);
            this.radioFamilyButton.Name = "radioFamilyButton";
            this.radioFamilyButton.Size = new System.Drawing.Size(95, 29);
            this.radioFamilyButton.TabIndex = 1;
            this.radioFamilyButton.TabStop = true;
            this.radioFamilyButton.Text = "Famille";
            this.radioFamilyButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioFamilyButton.UseVisualStyleBackColor = true;
            // 
            // radioGroupButton
            // 
            this.radioGroupButton.AutoSize = true;
            this.radioGroupButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioGroupButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroupButton.Location = new System.Drawing.Point(50, 126);
            this.radioGroupButton.Name = "radioGroupButton";
            this.radioGroupButton.Size = new System.Drawing.Size(98, 29);
            this.radioGroupButton.TabIndex = 2;
            this.radioGroupButton.TabStop = true;
            this.radioGroupButton.Text = "Groupe";
            this.radioGroupButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioGroupButton.UseVisualStyleBackColor = true;
            // 
            // radioSeniorButton
            // 
            this.radioSeniorButton.AutoSize = true;
            this.radioSeniorButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioSeniorButton.FlatAppearance.BorderSize = 5;
            this.radioSeniorButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioSeniorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSeniorButton.Location = new System.Drawing.Point(59, 56);
            this.radioSeniorButton.Name = "radioSeniorButton";
            this.radioSeniorButton.Size = new System.Drawing.Size(90, 29);
            this.radioSeniorButton.TabIndex = 4;
            this.radioSeniorButton.TabStop = true;
            this.radioSeniorButton.Text = "Senior";
            this.radioSeniorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioSeniorButton.UseVisualStyleBackColor = true;
            // 
            // Reductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 324);
            this.Controls.Add(this.ReducBox);
            this.Controls.Add(this.percentageSeniorLabel);
            this.Controls.Add(this.ValidReducbutton);
            this.Controls.Add(this.seniority);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reductions";
            this.ShowIcon = false;
            this.Text = "Reductions applicables";
            this.ReducBox.ResumeLayout(false);
            this.ReducBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label seniority;
        private System.Windows.Forms.Button ValidReducbutton;
        private System.Windows.Forms.Label percentageSeniorLabel;
        private System.Windows.Forms.GroupBox ReducBox;
        private System.Windows.Forms.RadioButton radioSeniorButton;
        private System.Windows.Forms.RadioButton radioGroupButton;
        private System.Windows.Forms.RadioButton radioFamilyButton;
        private System.Windows.Forms.RadioButton radioEtudiantButton;
    }
}