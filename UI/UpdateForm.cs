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
using Service;


namespace UI
{
    
    public partial class UpdateForm : Form
    {
        ManagerRepository m;
        Product updateproduct;
        int productclicked;
      
        public UpdateForm()
        {
            InitializeComponent();
           
            m = new ManagerRepository();
            loadAll();
            FullNamelb.Text = "Welcome: "+Service.CurrentUser.UserFullName;
            

        }
       
        void loadAll()
        {
            updatedatagridview.DataSource = m.getAllProduct();
            productCatagoryCombobox.DataSource = m.getAllCatagories();
            productCatagoryCombobox.DisplayMember = "CatagoryName";
            productCatagoryCombobox.ValueMember = "CatagoryId";
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                try
                {
                    string n = productNametb.Text;
                    decimal p = decimal.Parse(productPricetb.Text);
                    int q = int.Parse(productQuantitytb.Text);
                    int catid = int.Parse(productCatagoryCombobox.SelectedValue.ToString());
                    int restock = int.Parse(restocktb.Text.ToString());
                    string status = availablecombobox.Text;
                    updateproduct = new Product(n, q, catid, p, restock, status);
                    if (m.updateProduct(productclicked, updateproduct) > 0)
                    {
                        MessageBox.Show("Update Successfull");
                        loadAll();
                    }
                    else
                    {
                        MessageBox.Show("Update Unsuccessfull", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Please fill all fields.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }

        private void updatedatagridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (updatedatagridview.SelectedRows.Count > 0)
            {
                productclicked = int.Parse(updatedatagridview.SelectedRows[0].Cells["ProductId"].Value.ToString());
                productNametb.Text = updatedatagridview.SelectedRows[0].Cells["ProductName"].Value.ToString();
                productPricetb.Text = updatedatagridview.SelectedRows[0].Cells["Price"].Value.ToString();
                productQuantitytb.Text = updatedatagridview.SelectedRows[0].Cells["StockQuantity"].Value.ToString();
                productCatagoryCombobox.Text = updatedatagridview.SelectedRows[0].Cells["CatagoryName"].Value.ToString();
                restocktb.Text = updatedatagridview.SelectedRows[0].Cells["Restock_at"].Value.ToString();
                availablecombobox.Text= updatedatagridview.SelectedRows[0].Cells["Status"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {

            ManagerMenu f1 = new ManagerMenu();
            f1.Show();
            this.Hide();
        }

        private void FullNamelb_Click(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            productNametb.Text = "";
            productPricetb.Text = "";
            productQuantitytb.Text = "";
            restocktb.Text = "";
            productNametb.Text = "";
        }

        
    }
}
