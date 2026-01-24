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
    public partial class Receipt : Form
    {
        private int saleId;
        public Receipt(int saleId)
        {
            InitializeComponent();
            this.saleId = saleId;
            label2.Text = Service.CurrentUser.UserFullName;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            LoadSaleInfo();
            LoadSaleItems();
        }

        private void LoadSaleInfo()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            SaleId,
                            Sale_date,
                            Payment_method,
                            Total
                        FROM Sale
                        WHERE SaleId = @SaleId";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SaleId", saleId);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        label4.Text = dr["SaleId"].ToString();
                        label3.Text = Convert.ToDateTime(dr["Sale_date"]).ToString("dd-MM-yyyy HH:mm");
                        label5.Text = dr["Total"].ToString();
                       // label2.Text = Session.FullName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading receipt info: " + ex.Message);
            }
        }
        private void LoadSaleItems()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = @"
                        SELECT
                            p.ProductName AS 'Product',
                            sp.Quantity AS 'Qty',
                            sp.Unitprice AS 'Unit Price',
                            sp.TotalPrice AS 'Total'
                        FROM Sale_Product sp
                        JOIN Product p ON sp.ProductId = p.ProductId
                        WHERE sp.SaleId = @SaleId";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@SaleId", saleId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading receipt items: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
