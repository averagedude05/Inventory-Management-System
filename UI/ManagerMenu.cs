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
    public partial class ManagerMenu : Form
    {
        Form1 f;
        string name = Service.CurrentUser.Username;
        ManagerRepository m = new ManagerRepository();
        public ManagerMenu()
        {
            InitializeComponent();
            wlclb.Text = "Welcome: " + CurrentUser.UserFullName;
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
            decimal total=0;
            int quantity=0;
            decimal unitPrice=0;
            
            DataTable dt = m.autorestock();
            if (dt.Rows.Count > 0)
            {
                DialogResult result =MessageBox.Show("Inventory of some products are low. Create Restock Request","Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Request Created");
                    foreach (DataRow row in dt.Rows)
                    {  //1 more than restock amount will be purchased
                        quantity = int.Parse(row["Restock_at"].ToString()) + 1 - int.Parse(row["StockQuantity"].ToString());
                        total += quantity * decimal.Parse(row["Price"].ToString());
                    }
                    string note = "Created by system";
                    int purchaseid = m.CreatePurchase(m.getSystemid(), total, note);

                    foreach (DataRow row in dt.Rows)
                    {
                        unitPrice = decimal.Parse(row["Price"].ToString());
                        int productid = int.Parse(row["ProductId"].ToString());
                        try
                        {
                            quantity = int.Parse(row["Restock_at"].ToString()) + 1 - int.Parse(row["StockQuantity"].ToString());
                            m.addProduct_Purchase(productid, quantity, unitPrice, purchaseid);
                            m.updateProductStock(productid, quantity);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Occured please try again");
                        }
                    }
                }
            }
               
            pf.Show();
            this.Hide();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkinventorybtn_Click(object sender, EventArgs e)
        {
            SeeInventory s = new SeeInventory();
            s.Show();
            this.Hide();
        }
    }
}
