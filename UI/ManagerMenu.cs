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
            this.Hide();
            f.Show();
        }

        

    

        private void wellb_Click(object sender, EventArgs e)
        {
            wellb.Text = " Welcome, " + name;

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm u = new UpdateForm();
            u.Show();

        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            PurchaseForm pf = new PurchaseForm();
            this.Hide();
            pf.Show();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeleteForm df=new DeleteForm();
            this.Hide();
            df.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
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
            this.Hide();
            f.Show();
        }
    }
}
