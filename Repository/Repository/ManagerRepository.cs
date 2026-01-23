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
            //@ are placeholders in the query. They can be anything 
            //but make sure the same thing is used in command.Parameters.AddWithValue(Placeholde, the value you want to replace it with
            var sql = "select * from Users where UserName=@Name and UserPassword =@Password";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Password", pass);
            var datatable = d.Execute(command);//returns the data table
            if (datatable.Rows.Count > 0) {
                DataRow row = datatable.Rows[0];
                return new User(row["UserName"].ToString(), row["Role"].ToString(), int.Parse(row["UserId"].ToString()), row["UserPhone"].ToString(), row["Full_name"].ToString());
            }
            return null;

        }
        public int AddProduct(Product p)
        {
            var sql = "insert into Product(Price,ProductName,StockQuantity,CatagoryId,Restock_at) values(@Price,@ProductName,@StockQuantity,@CatagoryId,@Restock)";
            var command = d.GetCommand(sql); 
            command.Parameters.AddWithValue("@ProductName",p.ProductName);
            command.Parameters.AddWithValue("@Price", p.ProductPrice);
            command.Parameters.AddWithValue("@StockQuantity", p.ProductQuantity);
            command.Parameters.AddWithValue("@CatagoryId", p.ProductCatagory);
            command.Parameters.AddWithValue("@Restock", p.Restock);
            return d.ExecuteNonQuery(command);
         
        }
        public DataTable getAllProduct()
        {
            var sql = "select p.ProductId, p.ProductName, p.Price, p.StockQuantity, p.Restock_at, p.Created_at, p.Updated_at, P.Status, c.CatagoryName FROM Product p JOIN Catagory c ON p.CatagoryId = c.CatagoryId";
            var command = d.GetCommand(sql);
            return d.Execute(command);
            
        }

        public DataTable getAllProductDelete()
        {
            var sql = "select p.ProductId, p.ProductName, p.Price, p.StockQuantity, p.Restock_at, p.Created_at, p.Updated_at, P.Status, c.CatagoryName FROM Product p JOIN Catagory c ON p.CatagoryId = c.CatagoryId where p.Status='Available'";
            var command = d.GetCommand(sql);
            return d.Execute(command);

        }
        public string getUnitPrice(int id)
        {
            var sql = "select Price from Product where ProductId=@id";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@id", id);
            DataTable dt = d.Execute(command);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Price"].ToString(); 
            }
            return null;
        }


        public DataTable getAllCatagories()
        {
            var sql = "select * from Catagory";
            var command = d.GetCommand(sql);
            return d.Execute(command);
        }
    
        public int deleteProduct(int id)
        {
            var sql = "update Product set Status= 'UnAvailable' where ProductId=@ProductId";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@ProductId", id);
            return d.ExecuteNonQuery(command);
        }
        public int updateProduct(int id, Product p)
        {
            var sql = "update Product set Price=@price, ProductName=@productname," +
                " StockQuantity=@stockquantity, CatagoryId=@catagoryId, Updated_at=getdate(), " +
                "Status=@status, Restock_at=@restock where ProductId=@id";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@price", p.ProductPrice);
            command.Parameters.AddWithValue("@productname", p.ProductName);
            command.Parameters.AddWithValue("@stockquantity", p.ProductQuantity);
            command.Parameters.AddWithValue("@catagoryId", p.ProductCatagory);
            command.Parameters.AddWithValue("@status", p.Status);
            command.Parameters.AddWithValue("@restock", p.Restock);
            command.Parameters.AddWithValue("@id",id);

            return d.ExecuteNonQuery(command);
           
        }
       
        public DataTable getAllProduct_Purchase()
        {
            var sql = "select * from Product_Purchase ";
            var command = d.GetCommand(sql);
            return d.Execute(command);
        }
        public DataTable getSelectedProduct(int id)
        {
            var sql = "select p.ProductId, p.ProductName FROM Product p JOIN Catagory c ON p.CatagoryId = c.CatagoryId" +
                " where p.CatagoryId=@id and p.Status='Available'";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@id", id);
            return d.Execute(command);

        }
        public int CreatePurchase(int id, decimal total,string n)
        {
            var sql = "insert into Purchase(UserId,TotalAmount,Status, Notes)" +
                " values (@id, @total, 'Complete', @n); " +
                "SELECT SCOPE_IDENTITY();";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@total", total);
            command.Parameters.AddWithValue("@n", n);
            DataTable dt = d.Execute(command);
            return int.Parse(dt.Rows[0][0].ToString());
        }
        
        public int addProduct_Purchase(int productid, int q, decimal unit, int purchaseid)
        {
            var sql = "insert into Product_Purchase(ProductId,PurchaseId,Quantity,UnitPrice) " +
                "values(@pid, @purchaseid, @qty, @unitp)";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@pid", productid);
            command.Parameters.AddWithValue("@purchaseid", purchaseid);
            command.Parameters.AddWithValue("@qty", q);
            command.Parameters.AddWithValue("@unitp", unit);
            return d.ExecuteNonQuery(command);
        }
        public DataTable getFullPurchaseHistory()
        {
           var sql = "select pp.ProductPurchaseId, p.PurchaseId, pr.ProductId, u.UserName, pr.ProductName, pp.Quantity, pp.UnitPrice, " +
              "(pp.Quantity * pp.UnitPrice) as SubTotal, p.TotalAmount, p.PurchaseDate, p.Notes " +
              "from Purchase p " +
              "join Product_Purchase pp ON p.PurchaseId = pp.PurchaseId " +
              "join Product pr ON pp.ProductId = pr.ProductId " +
              "join Users u ON p.UserId = u.UserId " +
              "order by p.PurchaseId desc";
            var command = d.GetCommand(sql);
            return d.Execute(command);
        }
        public int restockProduct(int productId, int qty)
        {
            var sql = "update product set StockQuantity = StockQuantity + @Qty WHERE ProductId = @ProductId";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@Qty", qty);
            command.Parameters.AddWithValue("@ProductId", productId);
            return d.ExecuteNonQuery(command);
        }
        public int updateRestockDel(int productid, int qty)
        {
            var sql = "update Product set StockQuantity = StockQuantity - @Qty WHERE ProductId = @ProductId";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@Qty", qty);
            command.Parameters.AddWithValue("@ProductId", productid);
            return d.ExecuteNonQuery(command);
        }
        public int getSystemid()
        {
            var sql = "select UserId from Users where Username='system'";
            var command = d.GetCommand(sql);
            DataTable dt = d.Execute(command);
            if (dt.Rows.Count > 0)
            {
                return int.Parse(dt.Rows[0]["UserId"].ToString());
            }
            else return 0;
        }
        public DataTable autorestock()
        {
            var sql = "select ProductName, ProductId, Price, StockQuantity, Restock_at from Product " +
                "where StockQuantity<Restock_at";
            var command = d.GetCommand(sql);
            return d.Execute(command);

        }
        public DataTable searchProduct(string name)
        {
            var sql = "select p.ProductId, p.ProductName, p.Price, p.StockQuantity, p.Restock_at, " +
                "p.Created_at, p.Updated_at, P.Status, c.CatagoryName " +
                "FROM Product p JOIN Catagory c ON p.CatagoryId = c.CatagoryId " +
                "where p.ProductName like @name";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@name", "%" + name + "%");
            return d.Execute(command);
        }
        public int deleteProductPurchase(int id)
        {
            var sql = "delete from Product_Purchase where ProductPurchaseId=@id";
            var command = d.GetCommand(sql);
            command.Parameters.AddWithValue("@id", id);
            return d.ExecuteNonQuery(command);
        }

    }
}
