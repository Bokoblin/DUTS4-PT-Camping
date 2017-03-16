namespace PT_Camping.Views.Forms
{
    partial class ApplyReduction
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
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.groupRadioButton = new System.Windows.Forms.RadioButton();
            this.familyRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.ReducBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // seniority
            // 
            this.seniority.AutoSize = true;
            this.seniority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniority.Location = new System.Drawing.Point(70, 178);
            this.seniority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seniority.Name = "seniority";
            this.seniority.Size = new System.Drawing.Size(90, 20);
            this.seniority.TabIndex = 8;
            this.seniority.Text = "Ancienneté";
            // 
            // ValidReducbutton
            // 
            this.ValidReducbutton.Location = new System.Drawing.Point(83, 221);
            this.ValidReducbutton.Margin = new System.Windows.Forms.Padding(2);
            this.ValidReducbutton.Name = "ValidReducbutton";
            this.ValidReducbutton.Size = new System.Drawing.Size(92, 29);
            this.ValidReducbutton.TabIndex = 9;
            this.ValidReducbutton.Text = "Valider";
            this.ValidReducbutton.UseVisualStyleBackColor = true;
            this.ValidReducbutton.Click += new System.EventHandler(this.ValidReducbutton_Click);
            // 
            // percentageSeniorLabel
            // 
            this.percentageSeniorLabel.BackColor = System.Drawing.Color.White;
            this.percentageSeniorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percentageSeniorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentageSeniorLabel.Location = new System.Drawing.Point(164, 178);
            this.percentageSeniorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.percentageSeniorLabel.Name = "percentageSeniorLabel";
            this.percentageSeniorLabel.Size = new System.Drawing.Size(30, 20);
            this.percentageSeniorLabel.TabIndex = 10;
            // 
            // ReducBox
            // 
            this.ReducBox.Controls.Add(this.seniorRadioButton);
            this.ReducBox.Controls.Add(this.groupRadioButton);
            this.ReducBox.Controls.Add(this.familyRadioButton);
            this.ReducBox.Controls.Add(this.studentRadioButton);
            this.ReducBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReducBox.Location = new System.Drawing.Point(11, 20);
            this.ReducBox.Margin = new System.Windows.Forms.Padding(2);
            this.ReducBox.Name = "ReducBox";
            this.ReducBox.Padding = new System.Windows.Forms.Padding(2);
            this.ReducBox.Size = new System.Drawing.Size(242, 136);
            this.ReducBox.TabIndex = 11;
            this.ReducBox.TabStop = false;
            this.ReducBox.MouseCaptureChanged += new System.EventHandler(this.ReducButtonSelected);
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.FlatAppearance.BorderSize = 5;
            this.seniorRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.seniorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniorRadioButton.Location = new System.Drawing.Point(17, 45);
            this.seniorRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(73, 24);
            this.seniorRadioButton.TabIndex = 4;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupRadioButton
            // 
            this.groupRadioButton.AutoSize = true;
            this.groupRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRadioButton.Location = new System.Drawing.Point(17, 101);
            this.groupRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.groupRadioButton.Name = "groupRadioButton";
            this.groupRadioButton.Size = new System.Drawing.Size(81, 24);
            this.groupRadioButton.TabIndex = 2;
            this.groupRadioButton.TabStop = true;
            this.groupRadioButton.Text = "Groupe";
            this.groupRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.groupRadioButton.UseVisualStyleBackColor = true;
            // 
            // familyRadioButton
            // 
            this.familyRadioButton.AutoSize = true;
            this.familyRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.familyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familyRadioButton.Location = new System.Drawing.Point(17, 73);
            this.familyRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.familyRadioButton.Name = "familyRadioButton";
            this.familyRadioButton.Size = new System.Drawing.Size(77, 24);
            this.familyRadioButton.TabIndex = 1;
            this.familyRadioButton.TabStop = true;
            this.familyRadioButton.Text = "Famille";
            this.familyRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.familyRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.studentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRadioButton.Location = new System.Drawing.Point(17, 17);
            this.studentRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(87, 24);
            this.studentRadioButton.TabIndex = 0;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Etudiant";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // ApplyReduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.ReducBox);
            this.Controls.Add(this.percentageSeniorLabel);
            this.Controls.Add(this.ValidReducbutton);
            this.Controls.Add(this.seniority);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ApplyReduction";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Réductions applicables";
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
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton groupRadioButton;
        private System.Windows.Forms.RadioButton familyRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
    }
}