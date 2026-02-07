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
        public  int userRole;
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
            userRole = Service.CurrentUser.CheckUser(username, userpass);
            if (userRole == -1 )
            {
                MessageBox.Show("No user found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (userRole != null)
            {
                
                if (userRole==1)
                {
                    admin_Dash a = new admin_Dash(Service.CurrentUser.Username,Service.CurrentUser.Id.ToString());
                    a.Show();
                    this.Hide();

                }
                else if (userRole==2)
                {
                    ManagerMenu m = new ManagerMenu(this);
                    m.Show();
                    this.Hide();
                    nametb.Text = " ";
                    passtb.Text = " ";
                }
                else if (userRole==3)
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
