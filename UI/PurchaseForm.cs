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
    public partial class PurchaseForm : Form
    {
        ManagerRepository m = new ManagerRepository();
        DataTable temptable=new DataTable();
        int productId;
        string productName;
        int qty;
        decimal price;
        decimal total;
        string note;
        int purchaseId;
        public PurchaseForm()
        {
            InitializeComponent();
            FullNamelb.Text = "Welcome: "+Service.CurrentUser.UserFullName;
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            loadAll();
            createTempTable();
        }
        
        private void backbtn_Click(object sender, EventArgs e)
        {
            ManagerMenu m = new ManagerMenu();
            m.Show();
            this.Hide();
        }

        private void productdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void loadAll()
        {
            
                productdatagridview.DataSource = m.getAllProductDelete();
                //purchasedataGridView.DataSource = m.getAllProduct_Purchase();

                
                productCatagoryCombobox.DataSource = m.getAllCatagories();
                productCatagoryCombobox.DisplayMember = "CatagoryName";
                productCatagoryCombobox.ValueMember = "CatagoryId";
        }


        private void productCatagoryCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            int categoryId;
            if (!int.TryParse(productCatagoryCombobox.SelectedValue.ToString(), out categoryId))
                return;

            productnamecombobox.DataSource = m.getSelectedProduct(categoryId);
            productnamecombobox.DisplayMember = "ProductName";
            productnamecombobox.ValueMember = "ProductId";
            showpricelb.Text = "0";
            showsubtotal.Text = "0";
            productquantitynumeric.Text = "0";

        }
        private void productnamecombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            int categoryId;
            if (string.IsNullOrEmpty(productnamecombobox.SelectedValue.ToString()))
                return;
               

            productnamecombobox.DataSource = m.getSelectedProduct(productId);
            showpricelb.Text = "0";
            showsubtotal.Text = "0";
            productquantitynumeric.Text = "0";

        }
        void createTempTable()
        {
            temptable.Columns.Add("Product Id", typeof(int));
            temptable.Columns.Add("Product Name", typeof(string));
            temptable.Columns.Add("Quantity", typeof(int));
            temptable.Columns.Add("Unit Price", typeof(decimal));
            temptable.Columns.Add("Sub Total", typeof(decimal));

            purchasedataGridView.DataSource = temptable;
        }

        private void purchasedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            productId = int.Parse(productnamecombobox.SelectedValue.ToString());
            productName = productnamecombobox.Text;
           
            

            if(!int.TryParse(productquantitynumeric.Text,out qty))
            {
                MessageBox.Show("Add Quantity");
            }
            var v = m.getUnitPrice(productId);
            if (v != null)
                price = decimal.Parse(v);
            MessageBox.Show(price.ToString());
            showpricelb.Text = "৳ " + price.ToString();
            DataRow row = temptable.NewRow();
            row["Product Id"] = productId;
            row["Product Name"] = productName;
            row["Quantity"] = qty;
            row["Unit Price"] = price;
            row["Sub Total"] = qty * price;
            showsubtotal.Text= (qty * price).ToString();

            temptable.Rows.Add(row);
            
            purchasedataGridView.DataSource = temptable;
           
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            if (purchasedataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select one");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Delete Successfull");
                    temptable.Rows.RemoveAt(purchasedataGridView.SelectedRows[0].Index);
                }
            }
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (temptable.Rows.Count == 0) 
                    return;
                note = notetb.Text;
                total = Service.Sub_total_Calculation.getTotal(temptable);

                if (string.IsNullOrEmpty(note))
                {
                 purchaseId = m.CreatePurchase(Service.CurrentUser.Id, total,"");

                }
                else
                {
                    purchaseId = m.CreatePurchase(Service.CurrentUser.Id, total, note);
                }


                    foreach (DataRow row in temptable.Rows)
                    {
                        productId = int.Parse(row["Product Id"].ToString());
                        qty = int.Parse(row["Quantity"].ToString());
                        price = decimal.Parse(row["Unit Price"].ToString());


                        m.addProduct_Purchase(productId, qty, price, purchaseId);
                        m.updateProductStock(productId, qty);
                    }

                MessageBox.Show("Purchase Saved. Total: " + total);
                temptable.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoryForm f = new HistoryForm();
            f.Show();
        }
    }
}
