namespace UI
{
    partial class SeeInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeInventory));
            this.seealldatagridview = new System.Windows.Forms.DataGridView();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FullNamelb = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seealldatagridview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // seealldatagridview
            // 
            this.seealldatagridview.AllowUserToAddRows = false;
            this.seealldatagridview.AllowUserToDeleteRows = false;
            this.seealldatagridview.AllowUserToResizeColumns = false;
            this.seealldatagridview.AllowUserToResizeRows = false;
            this.seealldatagridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seealldatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seealldatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seealldatagridview.Location = new System.Drawing.Point(225, 3);
            this.seealldatagridview.Name = "seealldatagridview";
            this.seealldatagridview.RowHeadersWidth = 51;
            this.seealldatagridview.RowTemplate.Height = 24;
            this.seealldatagridview.Size = new System.Drawing.Size(1128, 444);
            this.seealldatagridview.TabIndex = 0;
            // 
            // searchtb
            // 
            this.searchtb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtb.Location = new System.Drawing.Point(683, 539);
            this.searchtb.MaximumSize = new System.Drawing.Size(500, 500);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(275, 34);
            this.searchtb.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.FullNamelb);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 765);
            this.panel1.TabIndex = 48;
            // 
            // FullNamelb
            // 
            this.FullNamelb.AutoSize = true;
            this.FullNamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNamelb.ForeColor = System.Drawing.SystemColors.Control;
            this.FullNamelb.Location = new System.Drawing.Point(3, 255);
            this.FullNamelb.Name = "FullNamelb";
            this.FullNamelb.Size = new System.Drawing.Size(53, 20);
            this.FullNamelb.TabIndex = 13;
            this.FullNamelb.Text = "label1";
            // 
            // backbtn
            // 
            this.backbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(3, 690);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(216, 44);
            this.backbtn.TabIndex = 12;
            this.backbtn.Text = "Move to Main Menu";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(564, 545);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(91, 29);
            this.searchbtn.TabIndex = 49;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // SeeInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 765);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.seealldatagridview);
            this.Name = "SeeInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Mangement System, Search Product";
            this.Load += new System.EventHandler(this.SeeInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seealldatagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView seealldatagridview;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FullNamelb;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button searchbtn;
    }
}