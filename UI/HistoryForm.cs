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
    public partial class HistoryForm : Form
    {
        ManagerRepository m=new ManagerRepository();
        DataTable dt;
        int productpurhcaseid;
        int productid;
        int qty;
        public HistoryForm()
        {
            InitializeComponent();
            FullNamelb.Text="Welcome: "+Service.CurrentUser.UserFullName.ToString();
               
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
             dt= m.getFullPurchaseHistory();
            int previd = 0;
            int currentid = 0;
            foreach (DataRow row in dt.Rows)
            {
                currentid = int.Parse(row["PurchaseId"].ToString());
                if (currentid == previd)
                {
                    row["UserName"] = "";
                    row["TotalAmount"] = row["SubTotal"] ;
                    row["Notes"] = "";
                }
                else
                {
                    previd = currentid;
                }
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["PurchaseId"].Visible = false;
            dataGridView1.Columns["ProductPurchaseId"].Visible = false;
            dataGridView1.Columns["ProductId"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerMenu f1 = new ManagerMenu();
            f1.Show();
            this.Hide();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
                productpurhcaseid = int.Parse(dataGridView1.SelectedRows[0].Cells["ProductPurchaseId"].Value.ToString());
                productid = int.Parse(dataGridView1.SelectedRows[0].Cells["ProductId"].Value.ToString());
                qty = int.Parse(dataGridView1.SelectedRows[0].Cells["Quantity"].Value.ToString());
                DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (m.deleteProductPurchase(productpurhcaseid) > 0)
                        {
                            
                            dt.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                            m.updateRestockDel(productid, qty);
                            MessageBox.Show("Delete Successfull");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }


            }
        }
    }
}
