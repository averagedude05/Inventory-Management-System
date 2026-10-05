using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class CurrentUser
    {
        public static ManagerRepository m = new ManagerRepository();
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
        public static int CheckUser(string name, string pass)
        {
            User u = m.Verify(name, pass);
            if (u == null) return -1;
            getCurrentUser(u);
            User.UserRoleType userRole;
            bool isValid = Enum.TryParse(u.UserRole, out userRole);
            string status = u.Status;
            if (status.ToLower() == "active")
            {
                if (isValid)
                {
                    switch (userRole)
                    {
                        case User.UserRoleType.Admin:
                            return 1;
                            break;
                        case User.UserRoleType.Manager:
                            return 2;
                            break;
                        case User.UserRoleType.Sales:
                            return 3;
                            break;
                        default:
                            return -1;
                            break;
                    }
                }
            }
            return -1;
        }
    } 
}
