using Service;
using System.Data;
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

    }
}
