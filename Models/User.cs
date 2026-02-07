using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //modles was created because in the repo class method verify returns 
    //user but it needs to look into user which is in services class but in 
    //order to use verify in the services class a reference needed to be made'
    //to the service class thus making a circular dependency 
    //so this class was created to store this now services can look into user
    //to check what it needs to return and the services can use repo without issues
    //gemini note:
    /*LEARNING NOTE: WHY WE USE A SEPARATE MODELS PROJECT
   --------------------------------------------------
   1. THE PROBLEM: 
      - The Repo needs to return a 'User' object.
      - If 'User' is defined in the Service, the Repo must reference the Service.
      - But the Service already references the Repo to use its methods.
      - This creates a CIRCULAR DEPENDENCY (an infinite loop).

   2. WHERE THE "TRAP" HAPPENS:
      - The Repo's Problem: Its job is to create the User (fetching data from DB). 
        If the User class lives in the Service, the Repo has to "reach up" to find 
        the blueprint for how to build that User.
      - The Service's Problem: The Service has to "reach down" into the Repo 
        to call the Verify method.
      - Result: Both projects are reaching for each other at the same time.

   3. THE SOLUTION (Models Project):
      - We moved 'User' and 'Role' into this neutral project.
      - Now, both the Repo and the Service can look "down" at the Models.
      - This breaks the circle and allows a clean, one-way flow of data.
*/
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
        public enum UserRoleType
        {
            Admin,
            Manager,
            Sales
        }

    }
   
}
