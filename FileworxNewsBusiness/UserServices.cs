using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public static bool UpdateUser(AppUser _userItem , out string _message)
        {
            AppUser _checkUser = RetrieveUser(_userItem.GuidValue);

            if (_checkUser != null)  // Existing User
            {
                if (_userItem.LogInName == _checkUser.LogInName)  // No change in login name
                {
                    BaseServices.Update(_userItem);
                    _message = "User updated successfully.";
                    return true;
                }
                else if (ValidUser(_userItem)) // Login name changed, but valid
                {
                    BaseServices.Update(_userItem);
                    _message = "User updated successfully.";
                    return true;
                }
                else  
                {
                    _message = "Invalid login name.";
                    return false;
                }
            }
            _message = "User not found";
            return false;
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
        public static bool SignUp(AppUser _user , out string _message)
        {
            if (ValidUser(_user))
            {
                AddUser(_user);
                _message  = "User Created Successfully.";
                return true;
            }
            _message = "Invalid login name.";
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
