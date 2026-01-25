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
    public partial class DeleteForm : Form
    {
        ManagerMenu mm;
        ManagerRepository m;
        string name=Service.CurrentUser.Username;
        public DeleteForm()
        {
            InitializeComponent();
            FullNamelb.Text = "Welcome: "+ Service.CurrentUser.UserFullName;

            m = new ManagerRepository();
           
        }
        void loadAll()
        {
            deleteGrid.DataSource = m.getAllProductNotDelete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ManagerMenu f1 = new ManagerMenu();
            f1.Show();
            this.Hide();
        }

        private void deleteGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (deleteGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select one column");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id = int.Parse(deleteGrid.SelectedRows[0].Cells["ProductId"].Value.ToString());
                    if (m.deleteProduct(id) > 0)
                    {
                       
                        loadAll();
                        MessageBox.Show("Delete Successfull");
                    }
                    else
                    {
                        MessageBox.Show("Error. Please try again");
                    }
                }
                
            }
        }
    }
}
