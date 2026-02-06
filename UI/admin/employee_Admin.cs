using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Repository;


namespace UI
{
    public partial class employee_Admin : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }
        private UserRepository userRepo { get; set; }
        
        public employee_Admin()
        {

            InitializeComponent();
            this.Da = new DataAccess();
            userRepo = new UserRepository();
            PopulateGridView();
            GenerateUserID();
            txtbox_empUser.ReadOnly = false;
            txtbox_empPass.ReadOnly = false;
        }

        private void ClearAll()
        {
            this.txtbox_empID.Clear();
            this.txtbox_empID.ReadOnly = true;
            this.txtbox_empName.Clear();
            this.txtbox_empPhone.Clear();
            this.txtbox_empUser.Clear();
            this.txtbox_empPass.Clear();
            GenerateUserID();
        }

        private void GenerateUserID()
        {
            
            this.txtbox_empID.Text = userRepo.GenerateUserID();
        }

        private void PopulateGridView(string sql = "select * from Users where Status='Active';")
        {
            this.Dt = this.Da.Execute(sql);
            this.grid_User.AutoGenerateColumns = false;
            this.grid_User.DataSource = this.Dt;
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            ClearAll();

        }
        private void txtbox_empID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_empName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_empPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_empPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_empAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_empUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            { 
                string empID = this.txtbox_empID.Text?.Trim();
                string empName = this.txtbox_empName.Text?.Trim();
                string empPhone = this.txtbox_empPhone.Text?.Trim();
                string empUserName = this.txtbox_empUser.Text?.Trim();
                string empPassword = this.txtbox_empPass.Text?.Trim();
                string empRole = this.cmbox_role.Text?.Trim();

                int flag = userRepo.AddUser(empID, empName, empPhone, empUserName, empRole, empPassword);

                if (flag == 1) { MessageBox.Show("Please fill in all required fields."); return; }
                if (flag==2) { MessageBox.Show("Phone number must be numeric and 11 digits"); return; }
                if (flag == 3) { MessageBox.Show("Username already exists. Please choose a different username."); return; }
                if (flag == 4)
                {
                    MessageBox.Show("Employee added successfully.");
                    PopulateGridView();
                    ClearAll();
                }
                if (flag == 5) { MessageBox.Show("No rows were inserted.");return; }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }
        private void btn_dlt_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the DataGridView
                if (grid_User.CurrentRow == null)
                {
                    MessageBox.Show("Please select a row to delete.");
                    return;
                }

                // Get the UserID from the selected row
                string userID = grid_User.CurrentRow.Cells["UserID"].Value?.ToString();
                string userName = grid_User.CurrentRow.Cells["Full_name"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(userID))
                {
                    MessageBox.Show("Invalid user selected.");
                    return;
                }
                // Show confirmation dialog
                DialogResult result = MessageBox.Show($"Are you sure you want to delete user '{userName}' (ID: {userID})?\n\nThis action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (userRepo.DeleteUser(userID))
                    {
                        MessageBox.Show("User deleted successfully.");
                        PopulateGridView(); // Refresh the grid
                        ClearAll(); // Clear the form fields
                    }
                    else
                    {
                        MessageBox.Show("No user was deleted. ");
                    }

                }
            }
            catch (SqlException ex)
            {
                // Check for foreign key violation (error number 547)
                if (ex.Number == 547)
                {
                    // Custom message for foreign key constraint violation
                    MessageBox.Show("Cannot delete user: This user is linked to existing sales records.");
                }
                else
                {
                    // Generic fallback for other SQL errors
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (this.txtbox_empID.ReadOnly && !string.IsNullOrWhiteSpace(this.txtbox_empID.Text))
                {
                    string userID = this.txtbox_empID.Text.Trim();
                    string empName = this.txtbox_empName.Text?.Trim();
                    string empPhone = this.txtbox_empPhone.Text?.Trim();
                    string empUserName = this.txtbox_empUser.Text?.Trim();
                    string empRole = this.cmbox_role.Text?.Trim();

                    int flag = userRepo.UpdateUser(userID, empName, empPhone, empUserName, empRole);

                    if (flag == 1)
                    {
                        MessageBox.Show("Fill All the fields");
                        return;
                    }

                    else if( flag ==2) MessageBox.Show("Phone number must numeric and be 11 digits");
                    else if(flag==3)
                    {
                        MessageBox.Show("User updated successfully.");
                        PopulateGridView();
                        ClearAll();
                    }
                    else if(flag==4) MessageBox.Show("No user was updated. Try Again.");
                }
                else
                {
                    MessageBox.Show("Please double-click on a row to edit a user first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
           
        }


        private void cmbox_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grid_User_DoubleClick(object sender, EventArgs e)
        {
            txtbox_empUser.ReadOnly = true;
            txtbox_empPass.ReadOnly = true;
           
            if (grid_User.CurrentRow != null)
            {
                try
                {
                    //this.txtbox_empName.ReadOnly = true;
                    this.txtbox_empID.ReadOnly = true;
                    this.txtbox_empPass.ReadOnly = true;
                    this.txtbox_empID.Text = grid_User.CurrentRow.Cells["UserId"].Value?.ToString();
                    this.txtbox_empName.Text = grid_User.CurrentRow.Cells["Full_name"].Value?.ToString();
                    this.txtbox_empPhone.Text = grid_User.CurrentRow.Cells["UserPhone"].Value?.ToString();
                    this.txtbox_empUser.Text = grid_User.CurrentRow.Cells["UserName"].Value?.ToString();
                    this.txtbox_empPass.Text = "**********";
                    this.cmbox_role.Text = grid_User.CurrentRow.Cells["Role"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Employee details: " + ex.Message);
                }
            }
        }

        private void txtbox_test_TextChanged(object sender, EventArgs e)
        {

        }

        private void employee_F_Load(object sender, EventArgs e)
        {

        }

        private void txtlbl_username_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_empName_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_phn_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_ID_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_role_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_address_Click(object sender, EventArgs e)
        {

        }

  
    }
}
