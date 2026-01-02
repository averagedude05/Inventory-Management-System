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
        string name;
        public ManagerMenu()
        {
            InitializeComponent();
        }
        public ManagerMenu(Form1 f, string name)
        {
            InitializeComponent();
            this.f = f;
            this.name = name;
            this.Text = "Inventory Managament System, "+name;
            wlclb.Text = " Welcome, " + name;
        }

        private void ManagerMenu_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void wellb_Click(object sender, EventArgs e)
        {
            wellb.Text = " Welcome, " + name;

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
