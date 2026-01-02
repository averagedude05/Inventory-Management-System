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
            addwlclb.Text = "Welcome " + name;
            m = new ManagerRepository();
            errorProvider = new ErrorProvider();


        }
        void loadProduct()
        {
            dgvloadproduct.DataSource = m.getAllProduct();
        }
        void loadCatagory()
        {
            DataTable dt = m.getAllCatagories();
            catagorycombo.DataSource = dt;
            catagorycombo.DisplayMember = "CatagoryName";//name user can see
            catagorycombo.ValueMember = "CatagoryId";//the code will see only the id number
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            ManagerMenu m = new ManagerMenu();
            this.Hide();
            m.Show();

        }

        private void productPricttb_TextChanged(object sender, EventArgs e)
        {

        }

        private void productQuantitylb_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string productname= productNametb.Text; 
            int productquantity; 
            int catid; 
            decimal price;
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
                errorProvider.SetError(productNametb, "Please enter name");
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
            if (!isValid)
            {
                return;//stops the program if all data not valid
            }
            try
            {
                
                productquantity = int.Parse(productQuantitytb.Text);
                catid = int.Parse(catagorycombo.SelectedValue.ToString());/*catagorycombo.SelectedValue 
                                                                           returns an object need to convert 
                                                                           to string and then parse to an int*/
                price = decimal.Parse(productPricttb.Text);
                p = new Product(productname, productquantity, catid, price);
                if (m.AddProduct(p) > 0)
                {
                    MessageBox.Show("Entered");
                   loadProduct();
                }
                else
                {
                    MessageBox.Show("False");
                }

            }
            catch (FormatException fe)
            {
                MessageBox.Show("Please enter the correct data");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error happened");
                Console.WriteLine(ex.Message);
            }
            
        }

        private void productIdtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            
            loadProduct();
            dgvloadproduct.ReadOnly = true;
            loadCatagory();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            productNametb.Text = "";
            productQuantitytb.Text = "";
            productPricttb.Text = " ";

        }
    }
}
