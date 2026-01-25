namespace UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nametb = new System.Windows.Forms.TextBox();
            this.passtb = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.passwrdlb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(158, 232);
            this.nametb.MinimumSize = new System.Drawing.Size(4, 30);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(215, 30);
            this.nametb.TabIndex = 1;
            this.nametb.TextChanged += new System.EventHandler(this.nametb_TextChanged);
            // 
            // passtb
            // 
            this.passtb.Location = new System.Drawing.Point(158, 349);
            this.passtb.MinimumSize = new System.Drawing.Size(4, 30);
            this.passtb.Name = "passtb";
            this.passtb.PasswordChar = '*';
            this.passtb.Size = new System.Drawing.Size(215, 30);
            this.passtb.TabIndex = 2;
            this.passtb.TextChanged += new System.EventHandler(this.passtb_TextChanged);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(158, 418);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(144, 39);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "Confirm";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // passwrdlb
            // 
            this.passwrdlb.AutoSize = true;
            this.passwrdlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdlb.Location = new System.Drawing.Point(12, 357);
            this.passwrdlb.Name = "passwrdlb";
            this.passwrdlb.Size = new System.Drawing.Size(89, 22);
            this.passwrdlb.TabIndex = 4;
            this.passwrdlb.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "UserName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1336, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwrdlb);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.nametb);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(18, 50);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label passwrdlb;
        private System.Windows.Forms.Label label2;
    }
}

