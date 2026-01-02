using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Product
    {
        public int ProductId{get;set;}
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductCatagory { get; set; }//id of the catagory not the name
        public decimal ProductPrice { get; set; }

        public Product(string productName, int productQuantity, int productCatagory, decimal productPrice )
        {
            ProductName = productName;
            ProductQuantity = productQuantity;
            ProductCatagory = productCatagory;
            ProductPrice = productPrice;
        }
    }
}
