
namespace Staff_Part
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewProductbtn = new System.Windows.Forms.Button();
            this.CreateSalebtn = new System.Windows.Forms.Button();
            this.SalesHistorybtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.RoleLabel);
            this.panel1.Controls.Add(this.StaffNameLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 75);
            this.panel1.TabIndex = 0;
            // 
            // RoleLabel
            // 
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.ForeColor = System.Drawing.Color.White;
            this.RoleLabel.Location = new System.Drawing.Point(681, 25);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(70, 20);
            this.RoleLabel.TabIndex = 2;
            this.RoleLabel.Text = "Role";
            this.RoleLabel.Click += new System.EventHandler(this.RoleLabel_Click);
            // 
            // StaffNameLabel
            // 
            this.StaffNameLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNameLabel.ForeColor = System.Drawing.Color.White;
            this.StaffNameLabel.Location = new System.Drawing.Point(148, 18);
            this.StaffNameLabel.Name = "StaffNameLabel";
            this.StaffNameLabel.Size = new System.Drawing.Size(144, 40);
            this.StaffNameLabel.TabIndex = 1;
            this.StaffNameLabel.Text = "StaffName";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // ViewProductbtn
            // 
            this.ViewProductbtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ViewProductbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProductbtn.ForeColor = System.Drawing.Color.White;
            this.ViewProductbtn.Location = new System.Drawing.Point(114, 160);
            this.ViewProductbtn.Name = "ViewProductbtn";
            this.ViewProductbtn.Size = new System.Drawing.Size(197, 69);
            this.ViewProductbtn.TabIndex = 1;
            this.ViewProductbtn.Text = "View Product";
            this.ViewProductbtn.UseVisualStyleBackColor = false;
            this.ViewProductbtn.Click += new System.EventHandler(this.ViewProductbtn_Click);
            // 
            // CreateSalebtn
            // 
            this.CreateSalebtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.CreateSalebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSalebtn.ForeColor = System.Drawing.Color.White;
            this.CreateSalebtn.Location = new System.Drawing.Point(439, 160);
            this.CreateSalebtn.Name = "CreateSalebtn";
            this.CreateSalebtn.Size = new System.Drawing.Size(178, 69);
            this.CreateSalebtn.TabIndex = 2;
            this.CreateSalebtn.Text = "Create Sale";
            this.CreateSalebtn.UseVisualStyleBackColor = false;
            this.CreateSalebtn.Click += new System.EventHandler(this.CreateSalebtn_Click);
            // 
            // SalesHistorybtn
            // 
            this.SalesHistorybtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.SalesHistorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesHistorybtn.ForeColor = System.Drawing.Color.White;
            this.SalesHistorybtn.Location = new System.Drawing.Point(114, 295);
            this.SalesHistorybtn.Name = "SalesHistorybtn";
            this.SalesHistorybtn.Size = new System.Drawing.Size(197, 69);
            this.SalesHistorybtn.TabIndex = 3;
            this.SalesHistorybtn.Text = "Sales History";
            this.SalesHistorybtn.UseVisualStyleBackColor = false;
            this.SalesHistorybtn.Click += new System.EventHandler(this.SalesHistorybtn_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.ForeColor = System.Drawing.Color.White;
            this.Logoutbtn.Location = new System.Drawing.Point(439, 295);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(178, 69);
            this.Logoutbtn.TabIndex = 4;
            this.Logoutbtn.Text = "Log Out";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(780, 487);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.SalesHistorybtn);
            this.Controls.Add(this.CreateSalebtn);
            this.Controls.Add(this.ViewProductbtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Button ViewProductbtn;
        private System.Windows.Forms.Button CreateSalebtn;
        private System.Windows.Forms.Button SalesHistorybtn;
        private System.Windows.Forms.Button Logoutbtn;
    }
}

