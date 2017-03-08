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
            this.reducCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.seniority = new System.Windows.Forms.Label();
            this.ValidReducbutton = new System.Windows.Forms.Button();
            this.percentageSeniorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reducCheckedListBox
            // 
            this.reducCheckedListBox.AllowDrop = true;
            this.reducCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reducCheckedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.reducCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reducCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reducCheckedListBox.FormattingEnabled = true;
            this.reducCheckedListBox.Items.AddRange(new object[] {
            "Etudiant",
            "Senior",
            "Famille",
            "Groupe"});
            this.reducCheckedListBox.Location = new System.Drawing.Point(42, 31);
            this.reducCheckedListBox.Margin = new System.Windows.Forms.Padding(10);
            this.reducCheckedListBox.Name = "reducCheckedListBox";
            this.reducCheckedListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reducCheckedListBox.Size = new System.Drawing.Size(179, 129);
            this.reducCheckedListBox.TabIndex = 6;
            this.reducCheckedListBox.TabStop = false;
            this.reducCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // seniority
            // 
            this.seniority.AutoSize = true;
            this.seniority.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniority.Location = new System.Drawing.Point(81, 157);
            this.seniority.Name = "seniority";
            this.seniority.Size = new System.Drawing.Size(140, 29);
            this.seniority.TabIndex = 8;
            this.seniority.Text = "Ancienneté";
            // 
            // ValidReducbutton
            // 
            this.ValidReducbutton.Location = new System.Drawing.Point(108, 205);
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
            this.percentageSeniorLabel.Location = new System.Drawing.Point(243, 164);
            this.percentageSeniorLabel.Name = "percentageSeniorLabel";
            this.percentageSeniorLabel.Size = new System.Drawing.Size(36, 20);
            this.percentageSeniorLabel.TabIndex = 10;
            // 
            // Reductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 253);
            this.Controls.Add(this.percentageSeniorLabel);
            this.Controls.Add(this.ValidReducbutton);
            this.Controls.Add(this.seniority);
            this.Controls.Add(this.reducCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reductions";
            this.ShowIcon = false;
            this.Text = "Reductions applicables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox reducCheckedListBox;
        private System.Windows.Forms.Label seniority;
        private System.Windows.Forms.Button ValidReducbutton;
        private System.Windows.Forms.Label percentageSeniorLabel;
    }
}