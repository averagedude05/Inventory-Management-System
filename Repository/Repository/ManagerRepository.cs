using Service;
using System.Data;
using System.Xml.Linq;
namespace Repository
{
    public class ManagerRepository
    {
        DataAccess d;
        public ManagerRepository()
        {
            d = new DataAccess();
        }

        public User Verify(string name, string pass)
        {
            var sql = "select UserName, Role from Users where UserName=@Name and UserPassword =@Password";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Password", pass);
            var datatable = d.Execute(command);//returns the data table
            if (datatable.Rows.Count > 0) {
                DataRow row = datatable.Rows[0];
                return new User
                {
                    // UserPass = row["UserPassword"].ToString(),
                    UserName = row["UserName"].ToString(),
                    UserRole = row["Role"].ToString()
                }; 
            }
            return null;

        }
        public int AddProduct(Product p)
        {
            var sql = "insert into Product(Price,ProductName,StockQuantity,CatagoryId) values(@Price,@ProductName,@StockQuantity,@CatagoryId)";
            var command = d.GetCommand(sql); 
            command.Parameters.AddWithValue("@ProductName",p.ProductName);
            command.Parameters.AddWithValue("@Price", p.ProductPrice);
            command.Parameters.AddWithValue("@StockQuantity", p.ProductQuantity);
            command.Parameters.AddWithValue("@CatagoryId", p.ProductCatagory);
            return d.ExecuteNonQuery(command);
         
        }
        public DataTable getAllProduct()
        {
            var sql = "SELECT p.ProductId, p.ProductName, p.Price, p.StockQuantity, c.CatagoryName FROM Product p JOIN Catagory c ON p.CatagoryId = c.CatagoryId;";
            var command = d.GetCommand(sql);
            return d.Execute(command);
            
        }
        public DataTable getAllCatagories()
        {
            var sql = "select * from Catagory";
            var command = d.GetCommand(sql);
            return d.Execute(command);
        }
    }
}
