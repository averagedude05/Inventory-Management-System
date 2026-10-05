using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Models;
namespace Service
{
    public static class AddProduct
    {
        static ManagerRepository m = new ManagerRepository();
      
        public static int createproduct(string prodname, string quantity, string catid, string price, string restock, string status)
        {
            Product p = new Product(prodname, int.Parse(quantity), int.Parse(catid), int.Parse(price), int.Parse(restock), status);
            if (m.AddProduct(p) > 0)
            {
                return 1;
            }
            else if (m.AddProduct(p) == -1)
            {
                return -1;
            }
            return 0;
        }
    }
}
