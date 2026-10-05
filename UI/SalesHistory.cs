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
    public partial class SalesHistory : Form
    {
        public SalesHistory()
        {
            InitializeComponent();
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void LoadSales()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"
                        SELECT 
                            SaleId,
                            Sale_date AS 'Date',
                            Total AS 'Total Amount',
                            Payment_method AS 'Payment'
                        FROM Sale
                        WHERE UserId = @UserId
                        ORDER BY Sale_date DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@UserId", 1);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales: " + ex.Message);
            }
        }


        private void LoadSaleDetails(int saleId)
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = @"
                SELECT 
                    p.ProductName AS 'Product',
                    sp.Quantity AS 'Quantity',
                    sp.Unitprice AS 'Unit Price',
                    sp.TotalPrice AS 'Subtotal'
                FROM Sale_Product sp
                JOIN Product p ON sp.ProductId = p.ProductId
                WHERE sp.SaleId = @SaleId";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@SaleId", saleId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //dataGridView2.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sale details: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int saleId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SaleId"].Value);
                LoadSaleDetails(saleId);
            }
        }
    }
}
