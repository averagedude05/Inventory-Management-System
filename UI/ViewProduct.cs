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
    public partial class ViewProduct : Form
    {
        public ViewProduct()
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
                    MessageBox.Show("Connected to DB!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Connection Error: " + ex.Message);
            }
        }

        private void LoadProducts2()
        {
            try
            {
                SqlConnection con = DBConnection.GetConnection();
                string query = @"
                    SELECT 
                        p.ProductName AS 'Product Name',
                        c.CatagoryName AS 'Category',
                        p.Price AS 'Price',
                        p.StockQuantity AS 'Stock',
                        p.Status AS 'Status'
                    FROM Product p
                    JOIN Catagory c ON p.CatagoryId = c.CatagoryId";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            LoadProducts2();
        }
    }
}
