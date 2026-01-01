namespace UI
{
    partial class ManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wellb = new System.Windows.Forms.Label();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.addcatagorybtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.logoutbtn);
            this.panel2.Controls.Add(this.addcatagorybtn);
            this.panel2.Controls.Add(this.Deletebtn);
            this.panel2.Controls.Add(this.wellb);
            this.panel2.Controls.Add(this.Updatebtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Addbtn);
            this.panel2.Controls.Add(this.dashboardbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 788);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // wellb
            // 
            this.wellb.AutoSize = true;
            this.wellb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wellb.ForeColor = System.Drawing.Color.White;
            this.wellb.Location = new System.Drawing.Point(18, 178);
            this.wellb.Name = "wellb";
            this.wellb.Size = new System.Drawing.Size(178, 25);
            this.wellb.TabIndex = 1;
            this.wellb.Text = "Welcome Manager";
            this.wellb.Click += new System.EventHandler(this.wellb_Click);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboardbtn.Location = new System.Drawing.Point(23, 270);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(171, 37);
            this.dashboardbtn.TabIndex = 4;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = true;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(23, 329);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(171, 36);
            this.Addbtn.TabIndex = 5;
            this.Addbtn.Text = "Add Product";
            this.Addbtn.UseVisualStyleBackColor = true;
            // 
            // Updatebtn
            // 
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Location = new System.Drawing.Point(23, 389);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(171, 42);
            this.Updatebtn.TabIndex = 6;
            this.Updatebtn.Text = "Update Details";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(23, 520);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(171, 38);
            this.Deletebtn.TabIndex = 7;
            this.Deletebtn.Text = "Delete Product";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // addcatagorybtn
            // 
            this.addcatagorybtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addcatagorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcatagorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcatagorybtn.ForeColor = System.Drawing.Color.White;
            this.addcatagorybtn.Location = new System.Drawing.Point(23, 453);
            this.addcatagorybtn.Name = "addcatagorybtn";
            this.addcatagorybtn.Size = new System.Drawing.Size(171, 36);
            this.addcatagorybtn.TabIndex = 8;
            this.addcatagorybtn.Text = "Add Catagory";
            this.addcatagorybtn.UseVisualStyleBackColor = true;
            // 
            // logoutbtn
            // 
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.White;
            this.logoutbtn.Location = new System.Drawing.Point(23, 727);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(171, 38);
            this.logoutbtn.TabIndex = 9;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 788);
            this.Controls.Add(this.panel2);
            this.Name = "ManagerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.ManagerMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wellb;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Button addcatagorybtn;
        private System.Windows.Forms.Button logoutbtn;
    }
}