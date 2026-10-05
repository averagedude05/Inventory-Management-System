using System.Linq;
using System.Windows.Forms;

namespace Service
{
    public class InputValidation
    {
        /// <summary>
        ///  Property used to set the ErrorMessage and use it later
        /// </summary>
        public static string ErrorMessage
        {
            get; private set;
        }
        public static int IsInputValid(Control f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is TextBox tb)
                {

                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        ErrorMessage = "Please fill all fields"; return -1;
                    }
                    ///<summary>if it contains price, quantity, catagory checks for number</summary>
                    if (tb.Name.ToLower().Contains("price") || tb.Name.ToLower().Contains("quantity")|| tb.Name.ToLower().Contains("restock")){
                        if (!decimal.TryParse(tb.Text, out decimal xd) || xd <= 0)
                        {
                            ErrorMessage = "Please enter a valid number";
                            return -1;
                        }

                    }
                    /// <summary>
                    /// Checks if the entire string consists only of alphanumeric characters.
                    /// Returns true if every character is either a letter or a decimal digit.
                    /// Returns false if any character is a space, symbol, or punctuation.
                    /// </summary>
                    if (!tb.Text.All(input => char.IsLetterOrDigit(input)))
                    {
                        ErrorMessage = "Please enter valid data";
                        return -1;
                    }
                    if (tb.Name.ToLower().Contains("name"))
                    {
                        if (char.IsDigit(tb.Text[0]))
                        {

                            ErrorMessage = "Product name can't start with a digit";
                            return -1;
                        }
                    }
                   
                }
                else if(c is ComboBox cb)
                {
                    if (cb.SelectedIndex == -1)
                    {
                        ErrorMessage = "Please fill all fields";
                        return -1;
                    }
                }
                if (c.HasChildren)
                {
                    int result = IsInputValid(c);

                    // If the child found an error, stop and return -1 now!
                    if (result == -1) return -1;
                }
            }
                return 0;
        } 
        
        //public static int IsInputValid(string name, string quantity, string price, string restock, string selectedcatid)
        //{
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        ErrorMessage = "Product name is empty";
        //        return -1;
        //    }
        //    else if (char.IsDigit(name[0]))
        //    {
        //        ErrorMessage = "Product name must start with a letter";
        //        return -1;
        //    }
        //    ErrorMessage = string.Empty;

        //    if (!int.TryParse(quantity, out int qty))
        //    {
        //        ErrorMessage = "Enter a valid number";
        //        return -1;
        //    }
        //    if (!decimal.TryParse(price, out decimal prc))
        //    {
        //        ErrorMessage = "Enter a valid number";
        //        return -1;
        //    }
        //    if (!int.TryParse(restock, out int restk))
        //    {
        //        ErrorMessage = "Enter a valid number";
        //        return -1;
        //    }
        //    if (qty <= 0 || prc <= 0 || restk <= 0)
        //    {
        //        ErrorMessage = "Please enter a value greater than zero";
        //        return -1;
        //    }
        //    if (int.Parse(selectedcatid) == -1) { ErrorMessage = "Please choose an error message"; return -1; }
        //    return 0;
        //}
    }
}
