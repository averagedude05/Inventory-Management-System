using System.Configuration;
using System.Data.SqlClient;

namespace Staff_Part
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            return new SqlConnection(connectionString);
        }
    }
}