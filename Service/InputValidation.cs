using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public  class InputValidation
    {
       // public static string   ErrorMessage;
        public static string ErrorMessage
        {
            get; private set;
        }

        public static int IsInputValid(string name, string quantity, string price, string restock,string selectedcatid)
        {
            if (string.IsNullOrEmpty(name))
            {
                 ErrorMessage = "Product name is empty";
                return -1;
            }
            else if (char.IsDigit(name[0]))
            {
                 ErrorMessage = "Product name must start with a letter";
                return -1;
            }
             ErrorMessage = string.Empty;
            
            if(!int.TryParse(quantity,out int qty))
            {
                 ErrorMessage = "Enter a valid number";
                return -1;
            }
            if (!decimal.TryParse(price, out decimal prc))
            {
                 ErrorMessage = "Enter a valid number";
                return -1;
            }
            if (!int.TryParse(restock, out int restk))
            {
                 ErrorMessage = "Enter a valid number";
                return -1;
            }
            if (qty <= 0||prc <= 0||restk <= 0)
            {
                 ErrorMessage = "Please enter a value greater than zero";
                return -1;
            }
            if (int.Parse(selectedcatid) == -1) { ErrorMessage = "Please choose an error message"; return -1; }
            return 0;
        }
    }
}
