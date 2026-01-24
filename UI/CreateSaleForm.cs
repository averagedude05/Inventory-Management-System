using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Part
{
    public partial class CreateSaleForm : Form
    {
        DataTable cartTable = new DataTable();
        public CreateSaleForm()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT ProductId, ProductName, Price, StockQuantity FROM Product",
                        con
                    );

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    comboBox1.DataSource = dt;

                    comboBox1.DisplayMember = "ProductName";
                    comboBox1.ValueMember = "ProductId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }



        private void SetupCart()
        {
            cartTable.Columns.Add("ProductId");
            cartTable.Columns.Add("ProductName");
            cartTable.Columns.Add("Price");
            cartTable.Columns.Add("Quantity");
            cartTable.Columns.Add("Subtotal");
            dataGridView1.DataSource = cartTable;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateSaleForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            SetupCart();

            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add("Card");
            comboBox2.Items.Add("Bkash");
            comboBox2.Items.Add("Nagad");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                DataRowView drv = comboBox1.SelectedItem as DataRowView;
                textBox1.Text = drv["Price"].ToString();
            }
        }

        private void ViewProductbtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Select product and enter quantity");
                return;
            }

            DataRowView drv = (DataRowView)comboBox1.SelectedItem;

            int productId = Convert.ToInt32(drv["ProductId"]);
            string productName = drv["ProductName"].ToString();
            decimal price = Convert.ToDecimal(drv["Price"]);
            int quantity = Convert.ToInt32(numericUpDown1.Value);

            decimal subtotal = price * quantity;

            cartTable.Rows.Add(productId, productName, price, quantity, subtotal);

            UpdateTotal();
            numericUpDown1.Value = 0;
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }

            textBox2.Text = total.ToString("0.00");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty");
                return;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Select payment method");
                return;
            }

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    decimal total = Convert.ToDecimal(textBox2.Text);

                    SqlCommand cmdSale = new SqlCommand(
                        @"INSERT INTO Sale (UserId, Sale_date, Payment_method, Total)
                          VALUES (@UserId, GETDATE(), @Payment, @Total);
                          SELECT SCOPE_IDENTITY();",
                        con, tran);

                    cmdSale.Parameters.AddWithValue("@UserId", 1);
                    cmdSale.Parameters.AddWithValue("@Payment", comboBox2.Text);
                    cmdSale.Parameters.AddWithValue("@Total", total);

                    int saleId = Convert.ToInt32(cmdSale.ExecuteScalar());

                    foreach (DataRow row in cartTable.Rows)
                    {
                        SqlCommand cmdDetail = new SqlCommand(
                            @"INSERT INTO Sale_Product
                              (ProductId, SaleId, Quantity, Unitprice, TotalPrice)
                              VALUES (@ProductId, @SaleId, @Quantity, @Unitprice, @TotalPrice)",
                            con, tran);

                        cmdDetail.Parameters.AddWithValue("@ProductId", row["ProductId"]);
                        cmdDetail.Parameters.AddWithValue("@SaleId", saleId);
                        cmdDetail.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                        cmdDetail.Parameters.AddWithValue("@Unitprice", row["Price"]);
                        cmdDetail.Parameters.AddWithValue("@TotalPrice", row["Subtotal"]);

                        cmdDetail.ExecuteNonQuery();

                        SqlCommand cmdStock = new SqlCommand(
                            @"UPDATE Product
                              SET StockQuantity = StockQuantity - @Qty
                              WHERE ProductId = @ProductId",
                            con, tran);

                        cmdStock.Parameters.AddWithValue("@Qty", row["Quantity"]);
                        cmdStock.Parameters.AddWithValue("@ProductId", row["ProductId"]);
                        cmdStock.ExecuteNonQuery();
                    }

                    tran.Commit();

                    MessageBox.Show("Sale completed successfully!");

                    Receipt r = new Receipt(saleId);
                    r.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Error completing sale: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }