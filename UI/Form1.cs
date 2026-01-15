using System;
using System.Windows.Forms;
using Repository;
using Service;

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

        private void Form1_Load(object sender, EventArgs e)
        {

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
            user = manager.Verify(username, userpass);
            if (user == null)
            {
                MessageBox.Show("No user found");
            }
            if (user != null)
            {
                CurrentUser.getCurrentUser(user);
                if (user.UserRole == "admin")
                {
                    MessageBox.Show("welcome admin");
                }
                else if (user.UserRole.ToLower() == "manager")
                {
                    ManagerMenu m = new ManagerMenu(this);
                    this.Hide();
                    m.Show();
                    nametb.Text = " ";
                    passtb.Text = " ";
                }
                else if (user.UserRole.ToLower() == "sales")
                {
                    ManagerMenu m = new ManagerMenu(this);
                    this.Hide();
                    m.Show();
                    nametb.Text = " ";
                    passtb.Text = " ";
                }
            }
            


        }
       
    }
}
