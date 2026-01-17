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
    public partial class AddForm : Form
    {
        string name;
        ManagerRepository m;
        Product p;
        ErrorProvider errorProvider;
        
       
        public AddForm(string name)
        {
            InitializeComponent();
           
            this.name = name;
            FullNamelb.Text = "Welcome: "+Service.CurrentUser.UserFullName;
            m = new ManagerRepository();
            errorProvider = new ErrorProvider();
            this.Text = "Welcome: " + name+" Add products";
            
        }
        void loadProduct()
        {
            dgvloadproduct.DataSource = m.getAllProduct();
        }
        void loadAll()
        {
            loadProduct();
            catagorycombo.DataSource = m.getAllCatagories();
            catagorycombo.DisplayMember = "CatagoryName";//name user can see
            catagorycombo.ValueMember = "CatagoryId";//the code will see only the id number

        }
        private void backbtn_Click(object sender, EventArgs e)
        {

            ManagerMenu f1 = new ManagerMenu();
            f1.Show();
            this.Hide();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            
            string productname= productNametb.Text; 
            int productquantity; 
            int catid; 
            decimal price;
            int restock;
            bool isValid = true;//used to make sure no bad data is entered to database
            //error handler only shows the error but doesn't stop from entering the data
            int v;
            if (string.IsNullOrEmpty(productname))
            {
                errorProvider.SetError(productNametb, "Product Name is required");
                isValid = false;

            }
            else if (char.IsDigit(productname[0]))
            {
                MessageBox.Show("Product name can't start with number");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(productNametb, "");
            }
            if (string.IsNullOrEmpty(productQuantitytb.Text))
            {
                errorProvider.SetError(productQuantitytb, "Product Quantity is required");
                isValid = false;

            }
            else
            {
                errorProvider.SetError(productQuantitytb, "");
            }
            if (string.IsNullOrEmpty(catagorycombo.SelectedValue.ToString()))
            {
                errorProvider.SetError(catagorycombo, "Catagory is required");
                isValid = false;

            }
            else
            {
                errorProvider.SetError(catagorycombo, "");
            }
            if (string.IsNullOrEmpty(productPricttb.Text))
            {
                errorProvider.SetError(productPricttb, "Product Price is required");
                isValid = false;

            }
            else
            {
                errorProvider.SetError(productPricttb, "");
            }
            if (string.IsNullOrEmpty(restocktb.Text))
            {
                errorProvider.SetError(restocktb, "Restock Level is Empty");
                isValid = false;

            }
            else
            {
                errorProvider.SetError(restocktb, "");
            }
            if (!isValid)
            {
                return;//stops the program if all data not valid
            }
            try
            {
                
                productquantity = int.Parse(productQuantitytb.Text);
                catid = int.Parse(catagorycombo.SelectedValue.ToString());                                                     
                price = decimal.Parse(productPricttb.Text);
                restock = int.Parse(restocktb.Text);
                string status = "";
                p = new Product(productname, productquantity, catid, price,restock,status);
                int r = m.AddProduct(p);
                if (r > 0)
                {
                    MessageBox.Show("Prodcut Added Successfully");
                   loadProduct();
                }
                else if (r == -1)
                {
                    MessageBox.Show("Product already exists");
                }
                else
                {
                    MessageBox.Show("Please enter a product");
                }

            }
            catch (FormatException fe)
            {
                MessageBox.Show("Please enter the correct data");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
                Console.WriteLine(ex.Message);
            }
            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

            loadAll();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            productNametb.Text = "";
            productQuantitytb.Text = "";
            productPricttb.Text = "";
            restocktb.Text = "";

        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void dgvloadproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FullNamelb_Click(object sender, EventArgs e)
        {

        }
    }
}
