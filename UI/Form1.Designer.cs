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
            this.label1 = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.passtb = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(448, 170);
            this.nametb.MinimumSize = new System.Drawing.Size(4, 50);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(100, 22);
            this.nametb.TabIndex = 1;
            this.nametb.TextChanged += new System.EventHandler(this.nametb_TextChanged);
            // 
            // passtb
            // 
            this.passtb.Location = new System.Drawing.Point(448, 281);
            this.passtb.Name = "passtb";
            this.passtb.Size = new System.Drawing.Size(100, 22);
            this.passtb.TabIndex = 2;
            this.passtb.TextChanged += new System.EventHandler(this.passtb_TextChanged);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(448, 376);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 742);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(18, 50);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.Button savebtn;
    }
}

