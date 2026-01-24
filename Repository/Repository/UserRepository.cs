using System;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class UserRepository
    {
        private DataAccess d;

        public UserRepository()
        {
            d = new DataAccess();
        }

        public int AddUser(string empID, string empName, string empPhone, string empUserName, string empRole, string empPassword)
        {
            if (string.IsNullOrWhiteSpace(empName) || string.IsNullOrWhiteSpace(empPhone) ||
                string.IsNullOrWhiteSpace(empRole) || string.IsNullOrWhiteSpace(empUserName) ||
                string.IsNullOrWhiteSpace(empPassword))
            {
                return 1;
            }

            if (!IsValidPhoneNumber(empPhone, out long? phoneNumber)) return 2;

            if (IsUserExist(empUserName) > 0) return 3;

            string insertSql = @"INSERT INTO Users
                        (UserName, UserPhone, UserPassword, Role, Full_name, Status)
                        VALUES (@UserName, @UserPhone, @UserPassword, @Role, @Full_name, 'Active');";

            SqlCommand cmd = d.GetCommand(insertSql);
            cmd.Parameters.AddWithValue("@Full_name", empName);
            cmd.Parameters.AddWithValue("@UserPhone", phoneNumber);
            cmd.Parameters.AddWithValue("@UserName", empUserName);
            cmd.Parameters.AddWithValue("@UserPassword", empPassword);
            cmd.Parameters.AddWithValue("@Role", empRole);

            int rows = d.ExecuteNonQuery(cmd);
            return rows > 0 ? 4 : 5;
        }


        public int UpdateUser(string userID, string empName, string empPhone, string empUserName, string empRole)
        {
            if (string.IsNullOrWhiteSpace(empName) || string.IsNullOrWhiteSpace(empPhone) ||
                string.IsNullOrWhiteSpace(empRole) || string.IsNullOrWhiteSpace(empUserName))
                return 1;

            bool validPhone = IsValidPhoneNumber(empPhone, out long? phoneNumber) && IsElevenDigits(empPhone);
            if (!validPhone) return 2;

            string updateSql = @"UPDATE Users
                                 SET Full_name=@Full_name,
                                     UserPhone=@UserPhone,
                                     UserName=@UserName,
                                     Role=@Role
                                 WHERE UserId=@UserId";

            SqlCommand cmd = d.GetCommand(updateSql);
            cmd.Parameters.AddWithValue("@Full_name", empName);
            cmd.Parameters.AddWithValue("@UserPhone", phoneNumber);
            cmd.Parameters.AddWithValue("@UserName", empUserName);
            cmd.Parameters.AddWithValue("@Role", empRole);
            cmd.Parameters.AddWithValue("@UserId", userID);

            int rows = d.ExecuteNonQuery(cmd);
            return rows > 0 ? 3 : 4;
        }

        public bool DeleteUser(string userID)
        {
            string deleteSql = "UPDATE Users SET Status='Inactive' WHERE UserId=@UserId";
            SqlCommand cmd = d.GetCommand(deleteSql);
            cmd.Parameters.AddWithValue("@UserId", userID);
            return d.ExecuteNonQuery(cmd) > 0;
        }

        public string GenerateUserID()
        {
            string sql = "select * from Users order by UserId desc;";
            DataTable dt = d.Execute(sql);
            int n = dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0]["UserId"]) : 0;
            return (++n).ToString();
        }

    
        private bool IsValidPhoneNumber(string phone, out long? number)
        {
            if (long.TryParse(phone, out long parsed))
            {
                number = parsed;
                return true;
            }
            number = null;
            return false;
        }

        private bool IsElevenDigits(string phone) => phone.Length == 11;

        private int IsUserExist(string username)
        {
            string checkSql = "SELECT COUNT(*) FROM Users WHERE UserName=@Username";
            SqlCommand cmd = d.GetCommand(checkSql);
            cmd.Parameters.AddWithValue("@Username", username);
            DataTable dt = d.Execute(cmd);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }
    }
}
