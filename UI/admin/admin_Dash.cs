using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;

namespace UI
{
    public partial class admin_Dash : Form
    {

        public string managerID { get; set; }
        public admin_Dash(string m, string id)
        {
            InitializeComponent();
            this.welcome_lbl.Text = "Welcome " + m;
            managerID = m;
            loadform(new inventory_Admin());
            
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0) this.mainpanel.Controls.RemoveAt(0);
            
            if(Form is Form)
            {
                Form f = Form as Form;

                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(f);
                this.mainpanel.Tag = f;
                f.Show();
            }
            else if(Form is UserControl)
            {
                UserControl f = Form as UserControl;

                f.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(f);
                this.mainpanel.Tag = f;
                f.Show();
            }   
        }
        private void btn_Employee_Click(object sender, EventArgs e)
        {
            loadform(new employee_Admin());
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            loadform(new inventory_Admin());
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Dispose();
            login.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void admin_Dash_Load(object sender, EventArgs e)
        {

        }
    }
}
