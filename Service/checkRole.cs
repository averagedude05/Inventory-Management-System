using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Service
{
    static class checkRole
    {
        static ManagerRepository m = new ManagerRepository();
        
        public enum Role
        {
            Admin,
            Manager,
            Sales

        }
        static int checkUser(string name, string pass)
        {
            User u = m.Verify(name, pass);
            
        }
    }
}
