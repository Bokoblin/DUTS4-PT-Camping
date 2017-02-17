namespace PT_Camping
{
    partial class IssuesUserControl
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
            this.issuesListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // issuesListView
            // 
            this.issuesListView.GridLines = true;
            this.issuesListView.HideSelection = false;
            this.issuesListView.Location = new System.Drawing.Point(25, 82);
            this.issuesListView.Name = "issuesListView";
            this.issuesListView.Size = new System.Drawing.Size(286, 479);
            this.issuesListView.TabIndex = 10;
            this.issuesListView.UseCompatibleStateImageBehavior = false;
            this.issuesListView.View = System.Windows.Forms.View.List;
            // 
            // IssuesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.issuesListView);
            this.Name = "IssuesUserControl";
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.Controls.SetChildIndex(this.issuesListView, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView issuesListView;
    }
}
