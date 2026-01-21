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
            purchasedataGridView.ReadOnly = true;

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
                MessageBox.Show("Please choose quantity");
            }
            var unitprice = m.getUnitPrice(productId);
            if (unitprice != null)
            {
                price = decimal.Parse(unitprice);
            }
            showpricelb.Text = "৳ " + price.ToString();
            DataRow row = temptable.NewRow();
            row["Product Id"] = productId;
            row["Product Name"] = productName;
            row["Quantity"] = qty;
            row["Unit Price"] = price;
            row["Sub Total"] = qty * price;

            showsubtotal.Text = $"৳ {qty} x {price}= {(qty * price).ToString()}";

            bool found = false;

            foreach (DataRow exist in temptable.Rows)
            {
                if (int.Parse(exist["Product Id"].ToString()) == productId)
                {
                    int currentquantity = int.Parse(exist["Quantity"].ToString());
                    int newquantity = currentquantity + qty;

                    exist["Quantity"] = newquantity;
                    exist["Sub Total"] = newquantity * price;

                    found = true;
                    
                }
            }

            if (!found)
            {
                temptable.Rows.Add(row);
            }
            showsubtotal.Text = $"৳ {qty} x {price} = {qty * price}";
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
                    purchaseId = m.CreatePurchase(Service.CurrentUser.Id, total, "");

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
                MessageBox.Show("Purchase Successfull");

                temptable.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

     
    }
}
