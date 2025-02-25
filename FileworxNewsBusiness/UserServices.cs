namespace FileworxNewsBusiness;
public static class UserServices 
{
    public static (bool,string) UpdateUser(AppUser _userItem )
    {
        string _message=string.Empty;
        AppUser _checkUser =  BaseOperations<AppUser>.Retrieve(_userItem.GuidValue);
        if (_checkUser != null)  // Existing User
        {
            if (_userItem.LogInName == _checkUser.LogInName)  // No change in login name
            {
                BaseOperations<AppUser>.Update(_userItem);
                _message = "User updated successfully.";
                return (true,_message);
            }
            else if ( ValidUser(_userItem)) // Login name changed, but valid
            {
                BaseOperations<AppUser>.Update(_userItem);
                _message = "User updated successfully.";
                return (true, _message);
            }
            else  
            {
                _message = "Invalid login name.";
                return (false, _message);
            }
        }
        _message = "User not found";
        return (false,_message);
    }
    public static  (bool,string) SignUp(AppUser _user )
    {
        string _message=string.Empty;
        if ( ValidUser(_user))
        {
            BaseOperations<AppUser>.Add(_user);
            _message  = "User Created Successfully.";
            return (true,_message);
        }
        _message = "Invalid login name.";
        return (false,_message);
    }
    public static  bool AuthenticateUser(AppUser _newUser , out Guid guidValue)
    {
        var _users = BaseOperations<AppUser>.RetrieveAll();
        foreach (AppUser _user in _users)
        {
            if (_user.IsEqual(_newUser))
            {
                guidValue = _user.GuidValue;
                return true;
            }
        }
        guidValue = Guid.Empty;
        return false;
    }
    private static  bool ValidUser(AppUser _user)
    {
        List<AppUser> _users =  BaseOperations<AppUser>.RetrieveAll();
        return !_users.Any(item => item.LogInName.Equals(_user.LogInName));
    }
}
