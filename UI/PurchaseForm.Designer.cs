namespace UI
{
    partial class PurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.showsubtotal = new System.Windows.Forms.Label();
            this.showpricelb = new System.Windows.Forms.Label();
            this.Removebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.productdatagridview = new System.Windows.Forms.DataGridView();
            this.productquantitynumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.productnamecombobox = new System.Windows.Forms.ComboBox();
            this.catagorylb = new System.Windows.Forms.Label();
            this.productCatagoryCombobox = new System.Windows.Forms.ComboBox();
            this.subtotallb = new System.Windows.Forms.Label();
            this.unitpricelb = new System.Windows.Forms.Label();
            this.productQuantitylb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.notetb = new System.Windows.Forms.TextBox();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.purchasedataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backbtn = new System.Windows.Forms.Button();
            this.FullNamelb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productdatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productquantitynumeric)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showsubtotal);
            this.panel1.Controls.Add(this.showpricelb);
            this.panel1.Controls.Add(this.Removebtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.productdatagridview);
            this.panel1.Controls.Add(this.productquantitynumeric);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.productnamecombobox);
            this.panel1.Controls.Add(this.catagorylb);
            this.panel1.Controls.Add(this.productCatagoryCombobox);
            this.panel1.Controls.Add(this.subtotallb);
            this.panel1.Controls.Add(this.unitpricelb);
            this.panel1.Controls.Add(this.productQuantitylb);
            this.panel1.Location = new System.Drawing.Point(217, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 763);
            this.panel1.TabIndex = 0;
            // 
            // showsubtotal
            // 
            this.showsubtotal.AutoSize = true;
            this.showsubtotal.Location = new System.Drawing.Point(177, 634);
            this.showsubtotal.Name = "showsubtotal";
            this.showsubtotal.Size = new System.Drawing.Size(14, 16);
            this.showsubtotal.TabIndex = 60;
            this.showsubtotal.Text = "0";
            // 
            // showpricelb
            // 
            this.showpricelb.AutoSize = true;
            this.showpricelb.Location = new System.Drawing.Point(177, 582);
            this.showpricelb.Name = "showpricelb";
            this.showpricelb.Size = new System.Drawing.Size(14, 16);
            this.showpricelb.TabIndex = 59;
            this.showpricelb.Text = "0";
            // 
            // Removebtn
            // 
            this.Removebtn.Location = new System.Drawing.Point(366, 697);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(112, 36);
            this.Removebtn.TabIndex = 58;
            this.Removebtn.Text = "Remove";
            this.Removebtn.UseVisualStyleBackColor = true;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(137, 697);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(114, 37);
            this.addbtn.TabIndex = 57;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "All Product List";
            // 
            // productdatagridview
            // 
            this.productdatagridview.AllowUserToAddRows = false;
            this.productdatagridview.AllowUserToDeleteRows = false;
            this.productdatagridview.AllowUserToResizeColumns = false;
            this.productdatagridview.AllowUserToResizeRows = false;
            this.productdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdatagridview.Location = new System.Drawing.Point(12, 66);
            this.productdatagridview.Name = "productdatagridview";
            this.productdatagridview.RowHeadersWidth = 51;
            this.productdatagridview.RowTemplate.Height = 24;
            this.productdatagridview.Size = new System.Drawing.Size(688, 238);
            this.productdatagridview.TabIndex = 56;
            this.productdatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productdatagridview_CellContentClick);
            // 
            // productquantitynumeric
            // 
            this.productquantitynumeric.Location = new System.Drawing.Point(191, 496);
            this.productquantitynumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.productquantitynumeric.Name = "productquantitynumeric";
            this.productquantitynumeric.Size = new System.Drawing.Size(120, 22);
            this.productquantitynumeric.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Product Name";
            // 
            // productnamecombobox
            // 
            this.productnamecombobox.FormattingEnabled = true;
            this.productnamecombobox.Location = new System.Drawing.Point(211, 422);
            this.productnamecombobox.Name = "productnamecombobox";
            this.productnamecombobox.Size = new System.Drawing.Size(121, 24);
            this.productnamecombobox.TabIndex = 52;
            this.productnamecombobox.SelectedValueChanged += new System.EventHandler(this.productnamecombobox_SelectedValueChanged);
            // 
            // catagorylb
            // 
            this.catagorylb.AutoSize = true;
            this.catagorylb.Location = new System.Drawing.Point(33, 343);
            this.catagorylb.Name = "catagorylb";
            this.catagorylb.Size = new System.Drawing.Size(62, 16);
            this.catagorylb.TabIndex = 51;
            this.catagorylb.Text = "Catagory";
            // 
            // productCatagoryCombobox
            // 
            this.productCatagoryCombobox.FormattingEnabled = true;
            this.productCatagoryCombobox.Location = new System.Drawing.Point(211, 340);
            this.productCatagoryCombobox.Name = "productCatagoryCombobox";
            this.productCatagoryCombobox.Size = new System.Drawing.Size(121, 24);
            this.productCatagoryCombobox.TabIndex = 50;
            this.productCatagoryCombobox.SelectedValueChanged += new System.EventHandler(this.productCatagoryCombobox_SelectedValueChanged);
            // 
            // subtotallb
            // 
            this.subtotallb.AutoSize = true;
            this.subtotallb.Location = new System.Drawing.Point(41, 634);
            this.subtotallb.Name = "subtotallb";
            this.subtotallb.Size = new System.Drawing.Size(62, 16);
            this.subtotallb.TabIndex = 49;
            this.subtotallb.Text = "Sub total ";
            // 
            // unitpricelb
            // 
            this.unitpricelb.AutoSize = true;
            this.unitpricelb.Location = new System.Drawing.Point(41, 582);
            this.unitpricelb.Name = "unitpricelb";
            this.unitpricelb.Size = new System.Drawing.Size(64, 16);
            this.unitpricelb.TabIndex = 46;
            this.unitpricelb.Text = "Unit Price";
            // 
            // productQuantitylb
            // 
            this.productQuantitylb.AutoSize = true;
            this.productQuantitylb.Location = new System.Drawing.Point(33, 502);
            this.productQuantitylb.Name = "productQuantitylb";
            this.productQuantitylb.Size = new System.Drawing.Size(104, 16);
            this.productQuantitylb.TabIndex = 45;
            this.productQuantitylb.Text = "Product Quantity";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.notetb);
            this.panel2.Controls.Add(this.confirmbtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.purchasedataGridView);
            this.panel2.Location = new System.Drawing.Point(923, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 765);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Note:";
            // 
            // notetb
            // 
            this.notetb.Location = new System.Drawing.Point(47, 563);
            this.notetb.Multiline = true;
            this.notetb.Name = "notetb";
            this.notetb.Size = new System.Drawing.Size(233, 76);
            this.notetb.TabIndex = 61;
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(187, 699);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(108, 37);
            this.confirmbtn.TabIndex = 60;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 36);
            this.label7.TabIndex = 59;
            this.label7.Text = "Purchase Items";
            // 
            // purchasedataGridView
            // 
            this.purchasedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasedataGridView.Location = new System.Drawing.Point(3, 68);
            this.purchasedataGridView.Name = "purchasedataGridView";
            this.purchasedataGridView.RowHeadersWidth = 51;
            this.purchasedataGridView.RowTemplate.Height = 24;
            this.purchasedataGridView.Size = new System.Drawing.Size(455, 194);
            this.purchasedataGridView.TabIndex = 57;
            this.purchasedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchasedataGridView_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel3.Controls.Add(this.backbtn);
            this.panel3.Controls.Add(this.FullNamelb);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 765);
            this.panel3.TabIndex = 17;
            // 
            // backbtn
            // 
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(12, 699);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(185, 44);
            this.backbtn.TabIndex = 12;
            this.backbtn.Text = "Move to Main Menu";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // FullNamelb
            // 
            this.FullNamelb.AutoSize = true;
            this.FullNamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNamelb.ForeColor = System.Drawing.SystemColors.Control;
            this.FullNamelb.Location = new System.Drawing.Point(18, 216);
            this.FullNamelb.Name = "FullNamelb";
            this.FullNamelb.Size = new System.Drawing.Size(53, 20);
            this.FullNamelb.TabIndex = 11;
            this.FullNamelb.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 1;
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
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 765);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseForn";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productdatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productquantitynumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown productquantitynumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox productnamecombobox;
        private System.Windows.Forms.Label catagorylb;
        private System.Windows.Forms.ComboBox productCatagoryCombobox;
        private System.Windows.Forms.Label subtotallb;
        private System.Windows.Forms.Label unitpricelb;
        private System.Windows.Forms.Label productQuantitylb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView productdatagridview;
        private System.Windows.Forms.DataGridView purchasedataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label FullNamelb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Label showpricelb;
        private System.Windows.Forms.Label showsubtotal;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notetb;
    }
}