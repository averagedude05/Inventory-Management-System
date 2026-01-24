using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;


namespace Staff_Part
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            StaffNameLabel.Text = Service.CurrentUser.UserFullName;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateSalebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateSaleForm cs = new CreateSaleForm();
            cs.ShowDialog();
            this.Show();
        }

        private void RoleLabel_Click(object sender, EventArgs e)
        {

        }

        private void ViewProductbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProduct vp = new ViewProduct();
            vp.ShowDialog();
            this.Show();
        }

        private void SalesHistorybtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesHistory sh = new SalesHistory();
            sh.ShowDialog();
            this.Show();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to logout?",
               "Logout Confirmation",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                // Clear session
                Session.UserId = 0;
                Session.FullName = "";
                Session.Role = "";

                
                 
                Form1 f = new Form1();
                f.Show();
               
            }
        }
    }
}
