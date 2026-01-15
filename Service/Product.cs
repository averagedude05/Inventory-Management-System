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
        public int Restock { get; set; }
        public string Status { get; set; }

        public Product(string productName, int productQuantity, int productCatagory, decimal productPrice, int restock, string stats )
        {
            ProductName = productName;
            ProductQuantity = productQuantity;
            ProductCatagory = productCatagory;
            ProductPrice = productPrice;
            Restock = restock;
            Status = stats;
        }
    }
}
