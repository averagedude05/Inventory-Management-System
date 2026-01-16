using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagerMenu : Form
    {
        Form1 f;
        string name = Service.CurrentUser.Username;
      //  ManagerRepository man = new ManagerRepository(); 
        public ManagerMenu()
        {
            InitializeComponent();
        }
        public ManagerMenu(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            
            this.Text = "Inventory Managament System, "+name;
            wlclb.Text = " Welcome, " + name;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Hide();
        }

        

    

        private void wellb_Click(object sender, EventArgs e)
        {
            wellb.Text = " Welcome, " + name;

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            UpdateForm u = new UpdateForm();
            u.Show();
            this.Hide();

        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            PurchaseForm pf = new PurchaseForm();
            pf.Show();
            this.Hide();
        }
        private void restockbtn_Click(object sender, EventArgs e)
        {
            PurchaseForm pf = new PurchaseForm();
            pf.Show();
            this.Hide();
          //  man.CreatePurchase(Service.CurrentUser.Id,0);
            
        }
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeleteForm df=new DeleteForm();
            df.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

           
            if (result == DialogResult.Yes)
            { 
                Form1 login = new Form1();
                login.Show();
                this.Dispose();
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddForm a = new AddForm(name);
            a.Show();
            this.Hide();
        }

        private void historybtn_Click(object sender, EventArgs e)
        {
            HistoryForm f = new HistoryForm();
            f.Show();
            this.Hide();
        }
    }
}
