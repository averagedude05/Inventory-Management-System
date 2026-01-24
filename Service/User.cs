using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class User
    {
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string UserRole { get; set; }
        public string UserPhone { get; set; }
        public string Full_Name { get; set; }
        public int UserId { get; private set; }
        public string Status { get; set; }
        public User(string name, string role, int id,string phn, string fn, string status)
        {
            UserName = name;
            UserRole = role;
            UserId = id;
            UserPhone = phn;
            Full_Name = fn;
            Status = status;
        }

    }
   
}
