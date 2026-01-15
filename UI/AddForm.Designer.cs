namespace UI
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.dgvloadproduct = new System.Windows.Forms.DataGridView();
            this.clearbtn = new System.Windows.Forms.Button();
            this.catagorycombo = new System.Windows.Forms.ComboBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.productCatagorylb = new System.Windows.Forms.Label();
            this.productQuantitylb = new System.Windows.Forms.Label();
            this.productPricelb = new System.Windows.Forms.Label();
            this.productNamelb = new System.Windows.Forms.Label();
            this.productQuantitytb = new System.Windows.Forms.TextBox();
            this.productPricttb = new System.Windows.Forms.TextBox();
            this.productNametb = new System.Windows.Forms.TextBox();
            this.Restocklb = new System.Windows.Forms.Label();
            this.restocktb = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FullNamelb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloadproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvloadproduct
            // 
            this.dgvloadproduct.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvloadproduct.AllowUserToAddRows = false;
            this.dgvloadproduct.AllowUserToDeleteRows = false;
            this.dgvloadproduct.AllowUserToResizeColumns = false;
            this.dgvloadproduct.AllowUserToResizeRows = false;
            this.dgvloadproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvloadproduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvloadproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloadproduct.Location = new System.Drawing.Point(230, 12);
            this.dgvloadproduct.Name = "dgvloadproduct";
            this.dgvloadproduct.ReadOnly = true;
            this.dgvloadproduct.RowHeadersWidth = 51;
            this.dgvloadproduct.RowTemplate.Height = 24;
            this.dgvloadproduct.Size = new System.Drawing.Size(1013, 267);
            this.dgvloadproduct.TabIndex = 23;
            this.dgvloadproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloadproduct_CellContentClick);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(739, 677);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(146, 48);
            this.clearbtn.TabIndex = 45;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // catagorycombo
            // 
            this.catagorycombo.FormattingEnabled = true;
            this.catagorycombo.Location = new System.Drawing.Point(837, 551);
            this.catagorycombo.Name = "catagorycombo";
            this.catagorycombo.Size = new System.Drawing.Size(104, 24);
            this.catagorycombo.TabIndex = 44;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(400, 676);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(154, 46);
            this.savebtn.TabIndex = 36;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // productCatagorylb
            // 
            this.productCatagorylb.AutoSize = true;
            this.productCatagorylb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCatagorylb.Location = new System.Drawing.Point(662, 553);
            this.productCatagorylb.Name = "productCatagorylb";
            this.productCatagorylb.Size = new System.Drawing.Size(150, 22);
            this.productCatagorylb.TabIndex = 43;
            this.productCatagorylb.Text = "Product Catagory";
            // 
            // productQuantitylb
            // 
            this.productQuantitylb.AutoSize = true;
            this.productQuantitylb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantitylb.Location = new System.Drawing.Point(302, 559);
            this.productQuantitylb.Name = "productQuantitylb";
            this.productQuantitylb.Size = new System.Drawing.Size(144, 22);
            this.productQuantitylb.TabIndex = 42;
            this.productQuantitylb.Text = "Product Quantity";
            // 
            // productPricelb
            // 
            this.productPricelb.AutoSize = true;
            this.productPricelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPricelb.Location = new System.Drawing.Point(662, 402);
            this.productPricelb.Name = "productPricelb";
            this.productPricelb.Size = new System.Drawing.Size(118, 22);
            this.productPricelb.TabIndex = 41;
            this.productPricelb.Text = "Product Price";
            // 
            // productNamelb
            // 
            this.productNamelb.AutoSize = true;
            this.productNamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNamelb.Location = new System.Drawing.Point(302, 402);
            this.productNamelb.Name = "productNamelb";
            this.productNamelb.Size = new System.Drawing.Size(124, 22);
            this.productNamelb.TabIndex = 40;
            this.productNamelb.Text = "Product Name";
            // 
            // productQuantitytb
            // 
            this.productQuantitytb.Location = new System.Drawing.Point(479, 551);
            this.productQuantitytb.MinimumSize = new System.Drawing.Size(4, 30);
            this.productQuantitytb.Name = "productQuantitytb";
            this.productQuantitytb.Size = new System.Drawing.Size(123, 22);
            this.productQuantitytb.TabIndex = 39;
            // 
            // productPricttb
            // 
            this.productPricttb.Location = new System.Drawing.Point(818, 394);
            this.productPricttb.MinimumSize = new System.Drawing.Size(4, 30);
            this.productPricttb.Name = "productPricttb";
            this.productPricttb.Size = new System.Drawing.Size(123, 22);
            this.productPricttb.TabIndex = 38;
            // 
            // productNametb
            // 
            this.productNametb.Location = new System.Drawing.Point(479, 394);
            this.productNametb.MinimumSize = new System.Drawing.Size(4, 30);
            this.productNametb.Name = "productNametb";
            this.productNametb.Size = new System.Drawing.Size(123, 22);
            this.productNametb.TabIndex = 37;
            // 
            // Restocklb
            // 
            this.Restocklb.AutoSize = true;
            this.Restocklb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restocklb.Location = new System.Drawing.Point(973, 553);
            this.Restocklb.Name = "Restocklb";
            this.Restocklb.Size = new System.Drawing.Size(97, 22);
            this.Restocklb.TabIndex = 48;
            this.Restocklb.Text = "Restock At";
            // 
            // restocktb
            // 
            this.restocktb.Location = new System.Drawing.Point(1120, 551);
            this.restocktb.MinimumSize = new System.Drawing.Size(4, 30);
            this.restocktb.Name = "restocktb";
            this.restocktb.Size = new System.Drawing.Size(123, 22);
            this.restocktb.TabIndex = 49;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 676);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Move to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.FullNamelb);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 765);
            this.panel1.TabIndex = 47;
            // 
            // FullNamelb
            // 
            this.FullNamelb.AutoSize = true;
            this.FullNamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNamelb.ForeColor = System.Drawing.SystemColors.Control;
            this.FullNamelb.Location = new System.Drawing.Point(18, 254);
            this.FullNamelb.Name = "FullNamelb";
            this.FullNamelb.Size = new System.Drawing.Size(53, 20);
            this.FullNamelb.TabIndex = 13;
            this.FullNamelb.Text = "label1";
            this.FullNamelb.Click += new System.EventHandler(this.FullNamelb_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1400, 765);
            this.Controls.Add(this.restocktb);
            this.Controls.Add(this.Restocklb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.catagorycombo);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.productCatagorylb);
            this.Controls.Add(this.productQuantitylb);
            this.Controls.Add(this.productPricelb);
            this.Controls.Add(this.productNamelb);
            this.Controls.Add(this.productQuantitytb);
            this.Controls.Add(this.productPricttb);
            this.Controls.Add(this.productNametb);
            this.Controls.Add(this.dgvloadproduct);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvloadproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvloadproduct;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.ComboBox catagorycombo;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label productCatagorylb;
        private System.Windows.Forms.Label productQuantitylb;
        private System.Windows.Forms.Label productPricelb;
        private System.Windows.Forms.Label productNamelb;
        private System.Windows.Forms.TextBox productQuantitytb;
        private System.Windows.Forms.TextBox productPricttb;
        private System.Windows.Forms.TextBox productNametb;
        private System.Windows.Forms.Label Restocklb;
        private System.Windows.Forms.TextBox restocktb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FullNamelb;
    }
}