using System;
using System.Windows.Forms;
using Repository;
using Service;
using Staff_Part;

namespace UI
{
 
    public partial class Form1 : Form
    {
        ManagerRepository manager;
        string name;
        string password;
        public  User user;
        public Form1()
        {
            InitializeComponent();
            manager = new ManagerRepository();
        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string username = nametb.Text.ToLower().Trim();
            string userpass = passtb.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userpass))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //user = manager.Verify(username, userpass);
            if (user == null || user.Status=="Inactive")
            {
                MessageBox.Show("No user found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (user != null)
            {
                CurrentUser.getCurrentUser(user);
                if (user.UserRole.ToLower() == "admin")
                {
                    admin_Dash a = new admin_Dash(Service.CurrentUser.Username,Service.CurrentUser.Id.ToString());
                    a.Show();
                    this.Hide();

                }
                else if (user.UserRole.ToLower() == "manager"&&user.Status=="Active")
                {
                    ManagerMenu m = new ManagerMenu(this);
                    m.Show();
                    this.Hide();
                    nametb.Text = " ";
                    passtb.Text = " ";
                }
                else if (user.UserRole.ToLower() == "sales" && user.Status == "Active")
                {
                    Dashboard s = new Dashboard();
                    s.Show();
                    this.Hide();
                    nametb.Text = " ";
                    passtb.Text = " ";

                }
            }
            


        }
       
    }
}
