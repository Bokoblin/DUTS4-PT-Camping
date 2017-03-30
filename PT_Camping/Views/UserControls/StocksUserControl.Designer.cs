namespace PT_Camping.Views.UserControls
{
    partial class StocksUserControl
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
            this.productListView = new System.Windows.Forms.ListView();
            this.addStockButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.informationsLabel = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.amountProductLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.commandButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.criticQuantityLabel = new System.Windows.Forms.Label();
            this.criticAmountTextBox = new System.Windows.Forms.TextBox();
            this.providerLabel = new System.Windows.Forms.Label();
            this.detailsTitlePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.detailsTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productListView
            // 
            this.productListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productListView.FullRowSelect = true;
            this.productListView.GridLines = true;
            this.productListView.HideSelection = false;
            this.productListView.Location = new System.Drawing.Point(52, 47);
            this.productListView.Name = "productListView";
            this.productListView.Scrollable = false;
            this.productListView.Size = new System.Drawing.Size(387, 390);
            this.productListView.TabIndex = 9;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.View = System.Windows.Forms.View.List;
            this.productListView.SelectedIndexChanged += new System.EventHandler(this.ProductListView_SelectedIndexChanged);
            this.productListView.Resize += new System.EventHandler(this.ProductListView_Resize);
            // 
            // addStockButton
            // 
            this.addStockButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStockButton.Location = new System.Drawing.Point(185, 463);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(120, 35);
            this.addStockButton.TabIndex = 12;
            this.addStockButton.Text = "Nouveau Stock";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddStockButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.Location = new System.Drawing.Point(196, 130);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(120, 20);
            this.idTextBox.TabIndex = 13;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTextBox.Location = new System.Drawing.Point(197, 235);
            this.priceTextBox.MaxLength = 7;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.ShortcutsEnabled = false;
            this.priceTextBox.Size = new System.Drawing.Size(119, 20);
            this.priceTextBox.TabIndex = 17;
            this.priceTextBox.Enter += new System.EventHandler(this.PriceTextBox_Enter);
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTextBox_KeyPress);
            this.priceTextBox.Leave += new System.EventHandler(this.PriceTextBox_Leave);
            // 
            // informationsLabel
            // 
            this.informationsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.informationsLabel.AutoSize = true;
            this.informationsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.informationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationsLabel.ForeColor = System.Drawing.Color.White;
            this.informationsLabel.Location = new System.Drawing.Point(136, 10);
            this.informationsLabel.Name = "informationsLabel";
            this.informationsLabel.Size = new System.Drawing.Size(103, 20);
            this.informationsLabel.TabIndex = 16;
            this.informationsLabel.Text = "Détail produit";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(64, 133);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(57, 13);
            this.productCodeLabel.TabIndex = 17;
            this.productCodeLabel.Text = "Référence";
            // 
            // amountProductLabel
            // 
            this.amountProductLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountProductLabel.AutoSize = true;
            this.amountProductLabel.Location = new System.Drawing.Point(64, 185);
            this.amountProductLabel.Name = "amountProductLabel";
            this.amountProductLabel.Size = new System.Drawing.Size(47, 13);
            this.amountProductLabel.TabIndex = 18;
            this.amountProductLabel.Text = "Quantité";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(64, 238);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(24, 13);
            this.priceLabel.TabIndex = 19;
            this.priceLabel.Text = "Prix";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(64, 159);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(37, 13);
            this.ProductNameLabel.TabIndex = 20;
            this.ProductNameLabel.Text = "Libellé";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNameTextBox.Location = new System.Drawing.Point(197, 156);
            this.productNameTextBox.MaxLength = 30;
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.ShortcutsEnabled = false;
            this.productNameTextBox.Size = new System.Drawing.Size(119, 20);
            this.productNameTextBox.TabIndex = 14;
            this.productNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductNameTextBox_KeyPress);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_delete;
            this.deleteProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProductButton.Location = new System.Drawing.Point(316, 46);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(30, 30);
            this.deleteProductButton.TabIndex = 11;
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_edit;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Location = new System.Drawing.Point(352, 46);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(30, 30);
            this.editButton.TabIndex = 12;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_undo;
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Location = new System.Drawing.Point(280, 46);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(30, 30);
            this.resetButton.TabIndex = 10;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // commandButton
            // 
            this.commandButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.commandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commandButton.Location = new System.Drawing.Point(204, 340);
            this.commandButton.Name = "commandButton";
            this.commandButton.Size = new System.Drawing.Size(120, 30);
            this.commandButton.TabIndex = 20;
            this.commandButton.Text = "Commander";
            this.commandButton.UseVisualStyleBackColor = true;
            this.commandButton.Click += new System.EventHandler(this.CommandButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountTextBox.Location = new System.Drawing.Point(197, 182);
            this.amountTextBox.MaxLength = 4;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.ShortcutsEnabled = false;
            this.amountTextBox.Size = new System.Drawing.Size(119, 20);
            this.amountTextBox.TabIndex = 15;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTextBox_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // providerComboBox
            // 
            this.providerComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.providerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerComboBox.Enabled = false;
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Location = new System.Drawing.Point(197, 261);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(120, 21);
            this.providerComboBox.TabIndex = 18;
            // 
            // sellButton
            // 
            this.sellButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellButton.Location = new System.Drawing.Point(60, 340);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(120, 30);
            this.sellButton.TabIndex = 19;
            this.sellButton.Text = "Vendre";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Controls.Add(this.productListView, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.addStockButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.detailsPanel, 3, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(984, 550);
            this.tableLayoutPanel.TabIndex = 30;
            // 
            // detailsPanel
            // 
            this.detailsPanel.BackColor = System.Drawing.Color.White;
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.criticQuantityLabel);
            this.detailsPanel.Controls.Add(this.criticAmountTextBox);
            this.detailsPanel.Controls.Add(this.providerLabel);
            this.detailsPanel.Controls.Add(this.detailsTitlePanel);
            this.detailsPanel.Controls.Add(this.sellButton);
            this.detailsPanel.Controls.Add(this.productCodeLabel);
            this.detailsPanel.Controls.Add(this.ProductNameLabel);
            this.detailsPanel.Controls.Add(this.amountTextBox);
            this.detailsPanel.Controls.Add(this.amountProductLabel);
            this.detailsPanel.Controls.Add(this.priceLabel);
            this.detailsPanel.Controls.Add(this.providerComboBox);
            this.detailsPanel.Controls.Add(this.productNameTextBox);
            this.detailsPanel.Controls.Add(this.resetButton);
            this.detailsPanel.Controls.Add(this.priceTextBox);
            this.detailsPanel.Controls.Add(this.commandButton);
            this.detailsPanel.Controls.Add(this.deleteProductButton);
            this.detailsPanel.Controls.Add(this.editButton);
            this.detailsPanel.Controls.Add(this.idTextBox);
            this.detailsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(543, 47);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(387, 390);
            this.detailsPanel.TabIndex = 13;
            // 
            // criticQuantityLabel
            // 
            this.criticQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criticQuantityLabel.AutoSize = true;
            this.criticQuantityLabel.Location = new System.Drawing.Point(64, 211);
            this.criticQuantityLabel.Name = "criticQuantityLabel";
            this.criticQuantityLabel.Size = new System.Drawing.Size(84, 13);
            this.criticQuantityLabel.TabIndex = 33;
            this.criticQuantityLabel.Text = "Quantité critique";
            // 
            // criticAmountTextBox
            // 
            this.criticAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criticAmountTextBox.Location = new System.Drawing.Point(197, 208);
            this.criticAmountTextBox.MaxLength = 4;
            this.criticAmountTextBox.Name = "criticAmountTextBox";
            this.criticAmountTextBox.ReadOnly = true;
            this.criticAmountTextBox.ShortcutsEnabled = false;
            this.criticAmountTextBox.Size = new System.Drawing.Size(119, 20);
            this.criticAmountTextBox.TabIndex = 16;
            this.criticAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CriticAmountTextBox_KeyPress);
            // 
            // providerLabel
            // 
            this.providerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.providerLabel.AutoSize = true;
            this.providerLabel.Location = new System.Drawing.Point(64, 264);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(61, 13);
            this.providerLabel.TabIndex = 31;
            this.providerLabel.Text = "Fournisseur";
            // 
            // detailsTitlePanel
            // 
            this.detailsTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.detailsTitlePanel.Controls.Add(this.informationsLabel);
            this.detailsTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.detailsTitlePanel.Name = "detailsTitlePanel";
            this.detailsTitlePanel.Size = new System.Drawing.Size(385, 40);
            this.detailsTitlePanel.TabIndex = 30;
            // 
            // StocksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "StocksUserControl";
            this.Size = new System.Drawing.Size(984, 600);
            this.Controls.SetChildIndex(this.tableLayoutPanel, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.tableLayoutPanel.ResumeLayout(false);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.detailsTitlePanel.ResumeLayout(false);
            this.detailsTitlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label informationsLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label amountProductLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button commandButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox providerComboBox;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label providerLabel;
        private System.Windows.Forms.Panel detailsTitlePanel;
        private System.Windows.Forms.Label criticQuantityLabel;
        private System.Windows.Forms.TextBox criticAmountTextBox;
    }
}