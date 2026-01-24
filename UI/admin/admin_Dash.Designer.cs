namespace UI
{
    partial class admin_Dash
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
            this.txtlbl_lapmart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtlbl_lapmart
            // 
            this.txtlbl_lapmart.AutoSize = true;
            this.txtlbl_lapmart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(103)))));
            this.txtlbl_lapmart.Font = new System.Drawing.Font("Ubuntu Mono Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_lapmart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtlbl_lapmart.Location = new System.Drawing.Point(58, 23);
            this.txtlbl_lapmart.Name = "txtlbl_lapmart";
            this.txtlbl_lapmart.Size = new System.Drawing.Size(87, 23);
            this.txtlbl_lapmart.TabIndex = 1;
            this.txtlbl_lapmart.Text = "LapMart";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_Employee);
            this.panel1.Controls.Add(this.btn_Inventory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 611);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Firebrick;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Ubuntu Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Location = new System.Drawing.Point(56, 534);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(68, 40);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.Font = new System.Drawing.Font("Ubuntu Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Employee.Location = new System.Drawing.Point(33, 146);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(119, 40);
            this.btn_Employee.TabIndex = 1;
            this.btn_Employee.Text = "Employee";
            this.btn_Employee.UseVisualStyleBackColor = true;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.Font = new System.Drawing.Font("Ubuntu Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventory.Location = new System.Drawing.Point(33, 91);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Size = new System.Drawing.Size(119, 40);
            this.btn_Inventory.TabIndex = 0;
            this.btn_Inventory.Text = "Inventory";
            this.btn_Inventory.UseVisualStyleBackColor = true;
            this.btn_Inventory.Click += new System.EventHandler(this.btn_Inventory_Click);
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.BackColor = System.Drawing.Color.White;
            this.welcome_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcome_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.welcome_lbl.Location = new System.Drawing.Point(745, 21);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(212, 34);
            this.welcome_lbl.TabIndex = 4;
            this.welcome_lbl.Text = "welcome, Admin";
            this.welcome_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.Transparent;
            this.mainpanel.Location = new System.Drawing.Point(201, 89);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(770, 510);
            this.mainpanel.TabIndex = 5;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // admin_Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.welcome_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtlbl_lapmart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "admin_Dash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.admin_Dash_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtlbl_lapmart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Inventory;
        private System.Windows.Forms.Button btn_Employee;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btn_exit;
    }
}