namespace FileworxNewsBusiness;
public static class UserServices 
{
    public static  AppUser AuthenticateUser(AppUser _newUser)
    {
        var _user = BaseOperations<AppUser>.RetrieveAll().Where(x=>x.IsEqual(_newUser)).First();
        if (_user != null)
        {
            return _user;
        }
        else
        {
            throw new Exception("Invalid user name or password");
        }

    }
   
}
