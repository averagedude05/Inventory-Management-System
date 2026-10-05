namespace UI
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.updatedatagridview = new System.Windows.Forms.DataGridView();
            this.productNametb = new System.Windows.Forms.TextBox();
            this.productQuantitytb = new System.Windows.Forms.TextBox();
            this.productPricetb = new System.Windows.Forms.TextBox();
            this.productNamelb = new System.Windows.Forms.Label();
            this.productQuantitylb = new System.Windows.Forms.Label();
            this.productPricelb = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.FullNamelb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.restocktb = new System.Windows.Forms.TextBox();
            this.productCatagoryCombobox = new System.Windows.Forms.ComboBox();
            this.catagorylb = new System.Windows.Forms.Label();
            this.availablelb = new System.Windows.Forms.Label();
            this.availablecombobox = new System.Windows.Forms.ComboBox();
            this.clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updatedatagridview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // updatedatagridview
            // 
            this.updatedatagridview.AllowUserToAddRows = false;
            this.updatedatagridview.AllowUserToDeleteRows = false;
            this.updatedatagridview.AllowUserToResizeColumns = false;
            this.updatedatagridview.AllowUserToResizeRows = false;
            this.updatedatagridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatedatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updatedatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updatedatagridview.Location = new System.Drawing.Point(233, 29);
            this.updatedatagridview.Name = "updatedatagridview";
            this.updatedatagridview.RowHeadersWidth = 51;
            this.updatedatagridview.RowTemplate.Height = 24;
            this.updatedatagridview.Size = new System.Drawing.Size(1096, 287);
            this.updatedatagridview.TabIndex = 0;
            this.updatedatagridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.updatedatagridview_CellMouseClick);
            // 
            // productNametb
            // 
            this.productNametb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNametb.Location = new System.Drawing.Point(488, 387);
            this.productNametb.Name = "productNametb";
            this.productNametb.Size = new System.Drawing.Size(199, 24);
            this.productNametb.TabIndex = 1;
            // 
            // productQuantitytb
            // 
            this.productQuantitytb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productQuantitytb.Location = new System.Drawing.Point(964, 389);
            this.productQuantitytb.Name = "productQuantitytb";
            this.productQuantitytb.Size = new System.Drawing.Size(100, 22);
            this.productQuantitytb.TabIndex = 2;
            // 
            // productPricetb
            // 
            this.productPricetb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productPricetb.Location = new System.Drawing.Point(500, 510);
            this.productPricetb.Name = "productPricetb";
            this.productPricetb.Size = new System.Drawing.Size(100, 22);
            this.productPricetb.TabIndex = 4;
            // 
            // productNamelb
            // 
            this.productNamelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNamelb.AutoSize = true;
            this.productNamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNamelb.Location = new System.Drawing.Point(346, 389);
            this.productNamelb.Name = "productNamelb";
            this.productNamelb.Size = new System.Drawing.Size(116, 20);
            this.productNamelb.TabIndex = 6;
            this.productNamelb.Text = "Product Name";
            // 
            // productQuantitylb
            // 
            this.productQuantitylb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productQuantitylb.AutoSize = true;
            this.productQuantitylb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantitylb.Location = new System.Drawing.Point(786, 389);
            this.productQuantitylb.Name = "productQuantitylb";
            this.productQuantitylb.Size = new System.Drawing.Size(134, 20);
            this.productQuantitylb.TabIndex = 7;
            this.productQuantitylb.Text = "Product Quantity";
            // 
            // productPricelb
            // 
            this.productPricelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productPricelb.AutoSize = true;
            this.productPricelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPricelb.Location = new System.Drawing.Point(352, 511);
            this.productPricelb.Name = "productPricelb";
            this.productPricelb.Size = new System.Drawing.Size(111, 20);
            this.productPricelb.TabIndex = 8;
            this.productPricelb.Text = "Product Price";
            // 
            // updatebtn
            // 
            this.updatebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(535, 689);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(152, 48);
            this.updatebtn.TabIndex = 10;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.FullNamelb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 765);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Move to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // FullNamelb
            // 
            this.FullNamelb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FullNamelb.AutoSize = true;
            this.FullNamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNamelb.ForeColor = System.Drawing.SystemColors.Control;
            this.FullNamelb.Location = new System.Drawing.Point(3, 219);
            this.FullNamelb.Name = "FullNamelb";
            this.FullNamelb.Size = new System.Drawing.Size(53, 20);
            this.FullNamelb.TabIndex = 11;
            this.FullNamelb.Text = "label1";
            this.FullNamelb.Click += new System.EventHandler(this.FullNamelb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Restock Level";
            // 
            // restocktb
            // 
            this.restocktb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.restocktb.Location = new System.Drawing.Point(500, 597);
            this.restocktb.Name = "restocktb";
            this.restocktb.Size = new System.Drawing.Size(100, 22);
            this.restocktb.TabIndex = 17;
            // 
            // productCatagoryCombobox
            // 
            this.productCatagoryCombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productCatagoryCombobox.FormattingEnabled = true;
            this.productCatagoryCombobox.Location = new System.Drawing.Point(964, 508);
            this.productCatagoryCombobox.Name = "productCatagoryCombobox";
            this.productCatagoryCombobox.Size = new System.Drawing.Size(172, 24);
            this.productCatagoryCombobox.TabIndex = 5;
            // 
            // catagorylb
            // 
            this.catagorylb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.catagorylb.AutoSize = true;
            this.catagorylb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagorylb.Location = new System.Drawing.Point(786, 511);
            this.catagorylb.Name = "catagorylb";
            this.catagorylb.Size = new System.Drawing.Size(76, 20);
            this.catagorylb.TabIndex = 9;
            this.catagorylb.Text = "Catagory";
            // 
            // availablelb
            // 
            this.availablelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.availablelb.AutoSize = true;
            this.availablelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablelb.Location = new System.Drawing.Point(786, 593);
            this.availablelb.Name = "availablelb";
            this.availablelb.Size = new System.Drawing.Size(92, 20);
            this.availablelb.TabIndex = 20;
            this.availablelb.Text = "Availablility";
            // 
            // availablecombobox
            // 
            this.availablecombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.availablecombobox.FormattingEnabled = true;
            this.availablecombobox.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.availablecombobox.Location = new System.Drawing.Point(964, 590);
            this.availablecombobox.Name = "availablecombobox";
            this.availablecombobox.Size = new System.Drawing.Size(172, 24);
            this.availablecombobox.TabIndex = 19;
            // 
            // clearbtn
            // 
            this.clearbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(842, 689);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(143, 48);
            this.clearbtn.TabIndex = 21;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1400, 765);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.availablelb);
            this.Controls.Add(this.availablecombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restocktb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.catagorylb);
            this.Controls.Add(this.productPricelb);
            this.Controls.Add(this.productQuantitylb);
            this.Controls.Add(this.productNamelb);
            this.Controls.Add(this.productCatagoryCombobox);
            this.Controls.Add(this.productPricetb);
            this.Controls.Add(this.productQuantitytb);
            this.Controls.Add(this.productNametb);
            this.Controls.Add(this.updatedatagridview);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System, Update Menu";
            ((System.ComponentModel.ISupportInitialize)(this.updatedatagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView updatedatagridview;
        private System.Windows.Forms.TextBox productNametb;
        private System.Windows.Forms.TextBox productQuantitytb;
        private System.Windows.Forms.TextBox productPricetb;
        private System.Windows.Forms.Label productNamelb;
        private System.Windows.Forms.Label productQuantitylb;
        private System.Windows.Forms.Label productPricelb;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FullNamelb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox restocktb;
        private System.Windows.Forms.ComboBox productCatagoryCombobox;
        private System.Windows.Forms.Label catagorylb;
        private System.Windows.Forms.Label availablelb;
        private System.Windows.Forms.ComboBox availablecombobox;
        private System.Windows.Forms.Button clearbtn;
    }
}