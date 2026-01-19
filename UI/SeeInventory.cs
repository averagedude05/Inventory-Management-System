using Repository;
using Service;
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
    public partial class SeeInventory : Form
    {
        ManagerRepository m = new ManagerRepository();
        ErrorProvider error = new ErrorProvider();
        public SeeInventory()
        {
            InitializeComponent();
            FullNamelb.Text = "Welcome: " + CurrentUser.UserFullName;
        }


        public void loadAll()
        {
            seealldatagridview.DataSource = m.getAllProduct();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchitem = searchtb.Text;
            if (!string.IsNullOrEmpty(searchitem))
            {
                DataTable dt = m.searchProduct(searchitem);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Product Found");
                    seealldatagridview.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Product not found");
                }
            }
            else
            {
                error.SetError(searchtb, "Search Box is empty");

            }
        }

        private void SeeInventory_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ManagerMenu m = new ManagerMenu();
            m.Show();
            this.Hide();
        }
    }
}
