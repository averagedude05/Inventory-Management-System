using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class CurrentUser
    {
        public static string Username { get; set; }
        public static string UserFullName { get; set; }
        public static int Id { get; set; }
        public static string Status { get; set; }
        public static void getCurrentUser(User u)
        {
            Username = u.UserName;
            Id = u.UserId;
            UserFullName = u.Full_Name;
            Status = u.Status;
        }
    }
}
