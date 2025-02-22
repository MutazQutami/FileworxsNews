namespace FileworxNewsBusiness;
public static class UserServices 
{
    public static bool UpdateUser(AppUser _userItem , out string _message)
    {
        AppUser _checkUser = BaseOperations<AppUser>.Retrieve(_userItem.GuidValue);

        if (_checkUser != null)  // Existing User
        {
            if (_userItem.LogInName == _checkUser.LogInName)  // No change in login name
            {
                BaseOperations<AppUser>.Update(_userItem);
                _message = "User updated successfully.";
                return true;
            }
            else if (ValidUser(_userItem)) // Login name changed, but valid
            {
                BaseOperations<AppUser>.Update(_userItem);
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
    public static bool SignUp(AppUser _user , out string _message)
    {
        if (ValidUser(_user))
        {
            BaseOperations<AppUser>.Add(_user);
            _message  = "User Created Successfully.";
            return true;
        }
        _message = "Invalid login name.";
        return false;
    }
    public static bool AuthenticateUser(AppUser _newUser)
    {
        var _users =BaseOperations<AppUser>.RetrieveAll();
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
        List<AppUser> _users = BaseOperations<AppUser>.RetrieveAll();
        return !_users.Any(item => item.LogInName.Equals(_user.LogInName));
    }
}
