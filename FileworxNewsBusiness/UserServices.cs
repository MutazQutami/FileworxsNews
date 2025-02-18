using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FileworxNewsBusiness
{
        public  class UserServices
        {
            public static bool AddUser(string name , string loginName,string password)
            {
                return BaseServices.Add(new AppUser());
            }
            public static  bool UpdateUser(string name, string loginName, string password)
            {
                return BaseServices.Update(new AppUser());
            }
            public static  bool DeleteUser(string username , string Guid , string password)
            {
                return true;
            }
            public static bool AuthenticateUser()
            {
                return true;
            }
            public bool RetrieveUsers()
            {
                return true;
            }
            public bool SignUp()
            {
                 return true;
            }
        }
}
