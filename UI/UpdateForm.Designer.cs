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
            this.productCatagoryCombobox = new System.Windows.Forms.ComboBox();
            this.productNamelb = new System.Windows.Forms.Label();
            this.productQuantitylb = new System.Windows.Forms.Label();
            this.productPricelb = new System.Windows.Forms.Label();
            this.catagorylb = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.delwlclb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.updatedatagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatedatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updatedatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updatedatagridview.Location = new System.Drawing.Point(268, 46);
            this.updatedatagridview.Name = "updatedatagridview";
            this.updatedatagridview.RowHeadersWidth = 51;
            this.updatedatagridview.RowTemplate.Height = 24;
            this.updatedatagridview.Size = new System.Drawing.Size(951, 225);
            this.updatedatagridview.TabIndex = 0;
            this.updatedatagridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.updatedatagridview_CellMouseClick);
            // 
            // productNametb
            // 
            this.productNametb.Location = new System.Drawing.Point(592, 403);
            this.productNametb.Name = "productNametb";
            this.productNametb.Size = new System.Drawing.Size(100, 22);
            this.productNametb.TabIndex = 1;
            // 
            // productQuantitytb
            // 
            this.productQuantitytb.Location = new System.Drawing.Point(1001, 403);
            this.productQuantitytb.Name = "productQuantitytb";
            this.productQuantitytb.Size = new System.Drawing.Size(100, 22);
            this.productQuantitytb.TabIndex = 2;
            // 
            // productPricetb
            // 
            this.productPricetb.Location = new System.Drawing.Point(592, 583);
            this.productPricetb.Name = "productPricetb";
            this.productPricetb.Size = new System.Drawing.Size(100, 22);
            this.productPricetb.TabIndex = 4;
            // 
            // productCatagoryCombobox
            // 
            this.productCatagoryCombobox.FormattingEnabled = true;
            this.productCatagoryCombobox.Location = new System.Drawing.Point(1067, 583);
            this.productCatagoryCombobox.Name = "productCatagoryCombobox";
            this.productCatagoryCombobox.Size = new System.Drawing.Size(121, 24);
            this.productCatagoryCombobox.TabIndex = 5;
            // 
            // productNamelb
            // 
            this.productNamelb.AutoSize = true;
            this.productNamelb.Location = new System.Drawing.Point(409, 409);
            this.productNamelb.Name = "productNamelb";
            this.productNamelb.Size = new System.Drawing.Size(93, 16);
            this.productNamelb.TabIndex = 6;
            this.productNamelb.Text = "Product Name";
            // 
            // productQuantitylb
            // 
            this.productQuantitylb.AutoSize = true;
            this.productQuantitylb.Location = new System.Drawing.Point(858, 409);
            this.productQuantitylb.Name = "productQuantitylb";
            this.productQuantitylb.Size = new System.Drawing.Size(104, 16);
            this.productQuantitylb.TabIndex = 7;
            this.productQuantitylb.Text = "Product Quantity";
            // 
            // productPricelb
            // 
            this.productPricelb.AutoSize = true;
            this.productPricelb.Location = new System.Drawing.Point(394, 591);
            this.productPricelb.Name = "productPricelb";
            this.productPricelb.Size = new System.Drawing.Size(87, 16);
            this.productPricelb.TabIndex = 8;
            this.productPricelb.Text = "Product Price";
            // 
            // catagorylb
            // 
            this.catagorylb.AutoSize = true;
            this.catagorylb.Location = new System.Drawing.Point(889, 586);
            this.catagorylb.Name = "catagorylb";
            this.catagorylb.Size = new System.Drawing.Size(62, 16);
            this.catagorylb.TabIndex = 9;
            this.catagorylb.Text = "Catagory";
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(465, 712);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 10;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.delwlclb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 756);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Move to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // delwlclb
            // 
            this.delwlclb.AutoSize = true;
            this.delwlclb.Location = new System.Drawing.Point(60, 212);
            this.delwlclb.Name = "delwlclb";
            this.delwlclb.Size = new System.Drawing.Size(44, 16);
            this.delwlclb.TabIndex = 11;
            this.delwlclb.Text = "label1";
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
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1255, 756);
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
            this.Text = "Update Menu";
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
        private System.Windows.Forms.ComboBox productCatagoryCombobox;
        private System.Windows.Forms.Label productNamelb;
        private System.Windows.Forms.Label productQuantitylb;
        private System.Windows.Forms.Label productPricelb;
        private System.Windows.Forms.Label catagorylb;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label delwlclb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}