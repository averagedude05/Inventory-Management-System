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
    public partial class HistoryForm : Form
    {
        ManagerRepository m=new ManagerRepository();
        public HistoryForm()
        {
            InitializeComponent();
            FullNamelb.Text="Welcome: "+Service.CurrentUser.UserFullName.ToString();
               
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            DataTable dt = m.getFullPurchaseHistory();
            int previd = 0;
            int currentid = 0;
            foreach (DataRow row in dt.Rows)
            {
                currentid = int.Parse(row["PurchaseId"].ToString());
                if (currentid == previd)
                {
                    row["UserName"] = "";
                    row["TotalAmount"] = row["SubTotal"] ;
                }
                else
                {
                    previd = currentid;
                }
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["PurchaseId"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerMenu f1 = new ManagerMenu();
            f1.Show();
            this.Hide();
        }
    }
}
