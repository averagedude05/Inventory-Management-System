using Models;
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
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            
            //used to make sure no bad data is entered to database
            //error handler only shows the error but doesn't stop from entering the data
            
            int Valid = Service.InputValidation.IsInputValid(productNametb.Text, productQuantitytb.Text, productPricttb.Text, restocktb.Text, catagorycombo.SelectedValue.ToString());
            if (Valid != 0)
            {
                MessageBox.Show(Service.InputValidation.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {

                    string status = "";
                    int r = Service.AddProduct.createproduct(productNametb.Text, productQuantitytb.Text, catagorycombo.SelectedValue.ToString(), productPricttb.Text, restocktb.Text, status);
                    if (r == 1)
                    {
                        MessageBox.Show("Prodcut Added Successfully");
                        loadProduct();
                        ClearForm.Clear(this);
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

            loadAll();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearForm.Clear(this);
        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
