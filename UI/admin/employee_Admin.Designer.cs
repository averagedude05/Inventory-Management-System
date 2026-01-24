namespace UI
{
    partial class employee_Admin
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_dlt = new System.Windows.Forms.Button();
            this.txtlbl_ID = new System.Windows.Forms.Label();
            this.txtbox_empID = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtbox_empPass = new System.Windows.Forms.TextBox();
            this.txtbox_empUser = new System.Windows.Forms.TextBox();
            this.txtbox_empPhone = new System.Windows.Forms.TextBox();
            this.txtlbl_pass = new System.Windows.Forms.Label();
            this.txtlbl_username = new System.Windows.Forms.Label();
            this.txtlbl_phn = new System.Windows.Forms.Label();
            this.txtlbl_empName = new System.Windows.Forms.Label();
            this.txtbox_empName = new System.Windows.Forms.TextBox();
            this.grid_User = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbox_role = new System.Windows.Forms.ComboBox();
            this.txtlbl_role = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_User)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Location = new System.Drawing.Point(392, 448);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 37);
            this.btn_save.TabIndex = 42;
            this.btn_save.Text = "Save and Update";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_dlt
            // 
            this.btn_dlt.BackColor = System.Drawing.Color.LightCoral;
            this.btn_dlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dlt.Location = new System.Drawing.Point(508, 448);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(110, 37);
            this.btn_dlt.TabIndex = 41;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseVisualStyleBackColor = false;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // txtlbl_ID
            // 
            this.txtlbl_ID.AutoSize = true;
            this.txtlbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_ID.Location = new System.Drawing.Point(65, 300);
            this.txtlbl_ID.Name = "txtlbl_ID";
            this.txtlbl_ID.Size = new System.Drawing.Size(92, 18);
            this.txtlbl_ID.TabIndex = 40;
            this.txtlbl_ID.Text = "Employee ID";
            this.txtlbl_ID.Click += new System.EventHandler(this.txtlbl_ID_Click);
            // 
            // txtbox_empID
            // 
            this.txtbox_empID.BackColor = System.Drawing.Color.White;
            this.txtbox_empID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_empID.Location = new System.Drawing.Point(158, 294);
            this.txtbox_empID.Name = "txtbox_empID";
            this.txtbox_empID.Size = new System.Drawing.Size(155, 24);
            this.txtbox_empID.TabIndex = 39;
            this.txtbox_empID.TextChanged += new System.EventHandler(this.txtbox_empID_TextChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(276, 448);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 37);
            this.btn_Add.TabIndex = 38;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.Location = new System.Drawing.Point(160, 448);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(110, 37);
            this.btn_clearAll.TabIndex = 37;
            this.btn_clearAll.Text = "Clear All";
            this.btn_clearAll.UseVisualStyleBackColor = true;
            this.btn_clearAll.Click += new System.EventHandler(this.btn_clearAll_Click);
            // 
            // txtbox_empPass
            // 
            this.txtbox_empPass.BackColor = System.Drawing.SystemColors.Info;
            this.txtbox_empPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_empPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_empPass.Location = new System.Drawing.Point(158, 400);
            this.txtbox_empPass.Name = "txtbox_empPass";
            this.txtbox_empPass.Size = new System.Drawing.Size(155, 24);
            this.txtbox_empPass.TabIndex = 35;
            this.txtbox_empPass.TextChanged += new System.EventHandler(this.txtbox_empPass_TextChanged);
            // 
            // txtbox_empUser
            // 
            this.txtbox_empUser.BackColor = System.Drawing.SystemColors.Info;
            this.txtbox_empUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_empUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_empUser.Location = new System.Drawing.Point(158, 370);
            this.txtbox_empUser.Name = "txtbox_empUser";
            this.txtbox_empUser.ReadOnly = true;
            this.txtbox_empUser.Size = new System.Drawing.Size(155, 24);
            this.txtbox_empUser.TabIndex = 34;
            this.txtbox_empUser.TextChanged += new System.EventHandler(this.txtbox_empUser_TextChanged);
            // 
            // txtbox_empPhone
            // 
            this.txtbox_empPhone.BackColor = System.Drawing.Color.White;
            this.txtbox_empPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_empPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_empPhone.Location = new System.Drawing.Point(479, 330);
            this.txtbox_empPhone.Name = "txtbox_empPhone";
            this.txtbox_empPhone.Size = new System.Drawing.Size(225, 24);
            this.txtbox_empPhone.TabIndex = 32;
            this.txtbox_empPhone.TextChanged += new System.EventHandler(this.txtbox_empPhone_TextChanged);
            // 
            // txtlbl_pass
            // 
            this.txtlbl_pass.AutoSize = true;
            this.txtlbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_pass.Location = new System.Drawing.Point(63, 402);
            this.txtlbl_pass.Name = "txtlbl_pass";
            this.txtlbl_pass.Size = new System.Drawing.Size(75, 18);
            this.txtlbl_pass.TabIndex = 31;
            this.txtlbl_pass.Text = "Password";
            // 
            // txtlbl_username
            // 
            this.txtlbl_username.AutoSize = true;
            this.txtlbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_username.Location = new System.Drawing.Point(63, 372);
            this.txtlbl_username.Name = "txtlbl_username";
            this.txtlbl_username.Size = new System.Drawing.Size(84, 18);
            this.txtlbl_username.TabIndex = 30;
            this.txtlbl_username.Text = "User Name";
            this.txtlbl_username.Click += new System.EventHandler(this.txtlbl_username_Click);
            // 
            // txtlbl_phn
            // 
            this.txtlbl_phn.AutoSize = true;
            this.txtlbl_phn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_phn.Location = new System.Drawing.Point(355, 332);
            this.txtlbl_phn.Name = "txtlbl_phn";
            this.txtlbl_phn.Size = new System.Drawing.Size(108, 18);
            this.txtlbl_phn.TabIndex = 28;
            this.txtlbl_phn.Text = "Phone Number";
            this.txtlbl_phn.Click += new System.EventHandler(this.txtlbl_phn_Click);
            // 
            // txtlbl_empName
            // 
            this.txtlbl_empName.AutoSize = true;
            this.txtlbl_empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_empName.Location = new System.Drawing.Point(355, 300);
            this.txtlbl_empName.Name = "txtlbl_empName";
            this.txtlbl_empName.Size = new System.Drawing.Size(118, 18);
            this.txtlbl_empName.TabIndex = 27;
            this.txtlbl_empName.Text = "Employee Name";
            this.txtlbl_empName.Click += new System.EventHandler(this.txtlbl_empName_Click);
            // 
            // txtbox_empName
            // 
            this.txtbox_empName.BackColor = System.Drawing.Color.White;
            this.txtbox_empName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_empName.Location = new System.Drawing.Point(479, 298);
            this.txtbox_empName.Name = "txtbox_empName";
            this.txtbox_empName.Size = new System.Drawing.Size(225, 24);
            this.txtbox_empName.TabIndex = 26;
            this.txtbox_empName.TextChanged += new System.EventHandler(this.txtbox_empName_TextChanged);
            // 
            // grid_User
            // 
            this.grid_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.Password,
            this.Full_name,
            this.Role,
            this.UserPhone});
            this.grid_User.Location = new System.Drawing.Point(60, 12);
            this.grid_User.Name = "grid_User";
            this.grid_User.RowHeadersVisible = false;
            this.grid_User.Size = new System.Drawing.Size(644, 273);
            this.grid_User.TabIndex = 43;
            this.grid_User.DoubleClick += new System.EventHandler(this.grid_User_DoubleClick);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // Full_name
            // 
            this.Full_name.DataPropertyName = "Full_name";
            this.Full_name.HeaderText = "Full_name";
            this.Full_name.Name = "Full_name";
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // UserPhone
            // 
            this.UserPhone.DataPropertyName = "UserPhone";
            this.UserPhone.HeaderText = "UserPhone";
            this.UserPhone.Name = "UserPhone";
            // 
            // cmbox_role
            // 
            this.cmbox_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbox_role.FormattingEnabled = true;
            this.cmbox_role.Items.AddRange(new object[] {
            "Sales Man",
            "Technician"});
            this.cmbox_role.Location = new System.Drawing.Point(158, 328);
            this.cmbox_role.Name = "cmbox_role";
            this.cmbox_role.Size = new System.Drawing.Size(155, 26);
            this.cmbox_role.TabIndex = 44;
            this.cmbox_role.SelectedIndexChanged += new System.EventHandler(this.cmbox_role_SelectedIndexChanged);
            // 
            // txtlbl_role
            // 
            this.txtlbl_role.AutoSize = true;
            this.txtlbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_role.Location = new System.Drawing.Point(65, 331);
            this.txtlbl_role.Name = "txtlbl_role";
            this.txtlbl_role.Size = new System.Drawing.Size(39, 18);
            this.txtlbl_role.TabIndex = 45;
            this.txtlbl_role.Text = "Role";
            this.txtlbl_role.Click += new System.EventHandler(this.txtlbl_role_Click);
            // 
            // employee_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 510);
            this.Controls.Add(this.txtlbl_role);
            this.Controls.Add(this.cmbox_role);
            this.Controls.Add(this.grid_User);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.txtlbl_ID);
            this.Controls.Add(this.txtbox_empID);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_clearAll);
            this.Controls.Add(this.txtbox_empPass);
            this.Controls.Add(this.txtbox_empUser);
            this.Controls.Add(this.txtbox_empPhone);
            this.Controls.Add(this.txtlbl_pass);
            this.Controls.Add(this.txtlbl_username);
            this.Controls.Add(this.txtlbl_phn);
            this.Controls.Add(this.txtlbl_empName);
            this.Controls.Add(this.txtbox_empName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employee_Admin";
            this.Text = "employee_F";
            this.Load += new System.EventHandler(this.employee_F_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_dlt;
        private System.Windows.Forms.Label txtlbl_ID;
        private System.Windows.Forms.TextBox txtbox_empID;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_clearAll;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtbox_empPass;
        private System.Windows.Forms.TextBox txtbox_empUser;
        private System.Windows.Forms.TextBox txtbox_empPhone;
        private System.Windows.Forms.Label txtlbl_pass;
        private System.Windows.Forms.Label txtlbl_username;
        private System.Windows.Forms.Label txtlbl_phn;
        private System.Windows.Forms.Label txtlbl_empName;
        private System.Windows.Forms.TextBox txtbox_empName;
        private System.Windows.Forms.DataGridView grid_User;
        private System.Windows.Forms.ComboBox cmbox_role;
        private System.Windows.Forms.Label txtlbl_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
    }
}