namespace PT_Camping
{
    partial class ClientsUserControl
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ClientlistView = new System.Windows.Forms.ListView();
            this.clientbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ClientlistView
            // 
            this.ClientlistView.Location = new System.Drawing.Point(58, 96);
            this.ClientlistView.Name = "ClientlistView";
            this.ClientlistView.Size = new System.Drawing.Size(259, 337);
            this.ClientlistView.TabIndex = 10;
            this.ClientlistView.UseCompatibleStateImageBehavior = false;
            // 
            // clientbutton
            // 
            this.clientbutton.Location = new System.Drawing.Point(135, 460);
            this.clientbutton.Name = "clientbutton";
            this.clientbutton.Size = new System.Drawing.Size(99, 26);
            this.clientbutton.TabIndex = 11;
            this.clientbutton.Text = "Valider";
            this.clientbutton.UseVisualStyleBackColor = true;
            // 
            // ClientsUserControl
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientbutton);
            this.Controls.Add(this.ClientlistView);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ClientsUserControl";
            this.Size = new System.Drawing.Size(1423, 738);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.Controls.SetChildIndex(this.ClientlistView, 0);
            this.Controls.SetChildIndex(this.clientbutton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView ClientlistView;
        private System.Windows.Forms.Button clientbutton;
    }
}
