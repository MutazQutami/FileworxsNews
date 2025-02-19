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
        public static void AddUser(AppUser _userItem)
        {
             BaseServices.Add(_userItem);
        }
        public static void UpdateUser(AppUser _userItem)
        {
             BaseServices.Update(_userItem);
        }
        public static void DeleteUser(Guid _guidValue)
        {
             BaseServices.Delete(new AppUser { GuidValue = _guidValue });
        }
        public static AppUser RetrieveUser(Guid _guidValue)
        {
            return (AppUser)BaseServices.Retrieve(new AppUser { GuidValue = _guidValue });
        }
        public static List<AppUser> RetrieveUsers()
        {
            return BaseServices.RetrieveObjects(new AppUser()).Cast<AppUser>().ToList();
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
                if (_user.IsEqual(_newUser))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool ValidUser(AppUser _user)
        {
            List<AppUser> _users = RetrieveUsers();
            return !_users.Any(item => item.LogInName.Equals(_user.LogInName));
        }
    }
}
