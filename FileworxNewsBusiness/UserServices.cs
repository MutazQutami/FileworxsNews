using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FileworxNewsBusiness
{
    public static class UserServices
    {
        public static bool AddUser(AppUser _userItem)
        {
            return BaseServices.Add(_userItem);
        }
        public static bool UpdateUser(AppUser _userItem)
        {
            return BaseServices.Update(_userItem);
        }
        public static bool DeleteUser(Guid _guidValue)
        {
            return BaseServices.Delete(new AppUser { GuidValue = _guidValue });
        }
        public static AppUser RetrieveUser(Guid _guidValue)
        {
            return (AppUser)BaseServices.Retrieve(new AppUser { GuidValue = _guidValue });
        }
        public static List<AppUser> RetrieveUsers()
        {
            return BaseServices.RetriveObjects(new AppUser()).Cast<AppUser>().ToList();
        }
        public static bool SignUp(AppUser _user)
        {
            if (ValidUser(_user))
            {
                AddUser(_user);
                return true;
            }
            return false;
        }
        public static bool AuthenticateUser(AppUser _newUser)
        {
            List<AppUser> _users = RetrieveUsers();
            foreach (AppUser _user in _users)
            {
                if (_user.Equals(_newUser))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool ValidUser(AppUser _user)
        {
            List<AppUser> _users = RetrieveUsers();

            foreach (var item in _users)
            {
                if (item.LogInName.Equals(_user.LogInName))
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
