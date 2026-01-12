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
        Product pu;
        int rowclicked;

        public UpdateForm(string name)
        {
            InitializeComponent();
            this.Text = " Welcome " + name + " Update Product Details";
            m = new ManagerRepository();
            loadAll();
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
            string n = productNametb.Text;
            decimal p = decimal.Parse(productPricetb.Text);
            int q = int.Parse(productQuantitytb.Text);
            int catid = int.Parse(productCatagoryCombobox.SelectedValue.ToString());
            pu = new Product(n, q, catid, p);
            if(m.updateProduct(rowclicked, pu) > 0)
            {
                MessageBox.Show("Update Successfull");
                loadAll();
            }
            else
            {
                MessageBox.Show(rowclicked.ToString());
            }
        }

        private void updatedatagridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (updatedatagridview.SelectedRows.Count > 0)
            {
                rowclicked= int.Parse(updatedatagridview.SelectedRows[0].Cells["ProductId"].Value.ToString());
                productNametb.Text = updatedatagridview.SelectedRows[0].Cells["ProductName"].Value.ToString();
                productPricetb.Text = updatedatagridview.SelectedRows[0].Cells["Price"].Value.ToString();
                productQuantitytb.Text = updatedatagridview.SelectedRows[0].Cells["StockQuantity"].Value.ToString();
                productCatagoryCombobox.DisplayMember = updatedatagridview.SelectedRows[0].Cells["CatagoryName"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMenu f = new ManagerMenu();
            f.Show();
        }
    }
}
