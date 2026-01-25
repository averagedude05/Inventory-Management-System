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
            this.restockbtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkinventorybtn = new System.Windows.Forms.Button();
            this.historybtn = new System.Windows.Forms.Button();
            this.Addwindowbtn = new System.Windows.Forms.Button();
            this.wlclb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // restockbtn
            // 
            this.restockbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.restockbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.restockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restockbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.restockbtn.Location = new System.Drawing.Point(8, 501);
            this.restockbtn.Name = "restockbtn";
            this.restockbtn.Size = new System.Drawing.Size(196, 46);
            this.restockbtn.TabIndex = 4;
            this.restockbtn.Text = "Restock Product";
            this.restockbtn.UseVisualStyleBackColor = true;
            this.restockbtn.Click += new System.EventHandler(this.restockbtn_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button7.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(12, 357);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 43);
            this.button7.TabIndex = 6;
            this.button7.Text = "Update Details";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(8, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete Product";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.checkinventorybtn);
            this.panel1.Controls.Add(this.historybtn);
            this.panel1.Controls.Add(this.Addwindowbtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.restockbtn);
            this.panel1.Controls.Add(this.wlclb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 803);
            this.panel1.TabIndex = 11;
            // 
            // checkinventorybtn
            // 
            this.checkinventorybtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkinventorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinventorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinventorybtn.ForeColor = System.Drawing.Color.White;
            this.checkinventorybtn.Location = new System.Drawing.Point(8, 658);
            this.checkinventorybtn.Name = "checkinventorybtn";
            this.checkinventorybtn.Size = new System.Drawing.Size(198, 46);
            this.checkinventorybtn.TabIndex = 14;
            this.checkinventorybtn.Text = "Check Inventory";
            this.checkinventorybtn.UseVisualStyleBackColor = true;
            this.checkinventorybtn.Click += new System.EventHandler(this.checkinventorybtn_Click);
            // 
            // historybtn
            // 
            this.historybtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.historybtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.historybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historybtn.ForeColor = System.Drawing.SystemColors.Control;
            this.historybtn.Location = new System.Drawing.Point(8, 579);
            this.historybtn.Name = "historybtn";
            this.historybtn.Size = new System.Drawing.Size(198, 46);
            this.historybtn.TabIndex = 13;
            this.historybtn.Text = "Restock History";
            this.historybtn.UseVisualStyleBackColor = true;
            this.historybtn.Click += new System.EventHandler(this.historybtn_Click);
            // 
            // Addwindowbtn
            // 
            this.Addwindowbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Addwindowbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addwindowbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addwindowbtn.ForeColor = System.Drawing.Color.White;
            this.Addwindowbtn.Location = new System.Drawing.Point(8, 279);
            this.Addwindowbtn.Name = "Addwindowbtn";
            this.Addwindowbtn.Size = new System.Drawing.Size(198, 46);
            this.Addwindowbtn.TabIndex = 12;
            this.Addwindowbtn.Text = "Add Product";
            this.Addwindowbtn.UseVisualStyleBackColor = true;
            this.Addwindowbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // wlclb
            // 
            this.wlclb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wlclb.AutoSize = true;
            this.wlclb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlclb.ForeColor = System.Drawing.SystemColors.Control;
            this.wlclb.Location = new System.Drawing.Point(8, 220);
            this.wlclb.Name = "wlclb";
            this.wlclb.Size = new System.Drawing.Size(53, 20);
            this.wlclb.TabIndex = 11;
            this.wlclb.Text = "label4";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(8, 730);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pictureBox2.Location = new System.Drawing.Point(23, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1293, 801);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button restockbtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label wlclb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Addwindowbtn;
        private System.Windows.Forms.Button historybtn;
        private System.Windows.Forms.Button checkinventorybtn;
    }
}