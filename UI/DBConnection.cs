using System.Data.SqlClient;

namespace Staff_Part
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=Inventory Management System;Integrated Security=True"
            );
        }
    }
}
