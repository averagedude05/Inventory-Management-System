namespace UI
{
    partial class inventory_Admin
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
            this.grid_Inventory = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restock_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Inventory
            // 
            this.grid_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Catagory,
            this.Price,
            this.StockQuantity,
            this.Restock_at,
            this.Created_at,
            this.Updated_at,
            this.Status});
            this.grid_Inventory.Location = new System.Drawing.Point(5, 15);
            this.grid_Inventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_Inventory.Name = "grid_Inventory";
            this.grid_Inventory.RowHeadersVisible = false;
            this.grid_Inventory.RowHeadersWidth = 51;
            this.grid_Inventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_Inventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_Inventory.Size = new System.Drawing.Size(1016, 598);
            this.grid_Inventory.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductId";
            this.ProductID.HeaderText = "ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 140;
            // 
            // Catagory
            // 
            this.Catagory.DataPropertyName = "CatagoryName";
            this.Catagory.HeaderText = "Catagory";
            this.Catagory.MinimumWidth = 6;
            this.Catagory.Name = "Catagory";
            this.Catagory.ReadOnly = true;
            this.Catagory.Width = 70;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // StockQuantity
            // 
            this.StockQuantity.DataPropertyName = "StockQuantity";
            this.StockQuantity.HeaderText = "Stock";
            this.StockQuantity.MinimumWidth = 6;
            this.StockQuantity.Name = "StockQuantity";
            this.StockQuantity.ReadOnly = true;
            this.StockQuantity.Width = 80;
            // 
            // Restock_at
            // 
            this.Restock_at.DataPropertyName = "Restock_at";
            this.Restock_at.HeaderText = "RestockAt";
            this.Restock_at.MinimumWidth = 6;
            this.Restock_at.Name = "Restock_at";
            this.Restock_at.ReadOnly = true;
            this.Restock_at.Width = 80;
            // 
            // Created_at
            // 
            this.Created_at.DataPropertyName = "Created_at";
            this.Created_at.HeaderText = "CreatedAt";
            this.Created_at.MinimumWidth = 6;
            this.Created_at.Name = "Created_at";
            this.Created_at.ReadOnly = true;
            this.Created_at.Width = 80;
            // 
            // Updated_at
            // 
            this.Updated_at.DataPropertyName = "Updated_at";
            this.Updated_at.HeaderText = "UpdatedAt";
            this.Updated_at.MinimumWidth = 6;
            this.Updated_at.Name = "Updated_at";
            this.Updated_at.ReadOnly = true;
            this.Updated_at.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // inventory_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 628);
            this.Controls.Add(this.grid_Inventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "inventory_Admin";
            this.Text = "inventoryF";
            this.Load += new System.EventHandler(this.inventoryF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Inventory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restock_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}