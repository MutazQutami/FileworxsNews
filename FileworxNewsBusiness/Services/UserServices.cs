//using FileworxNews.Business.Queries;
//using FileworxNews.Business.Models;
//namespace FileworxNews.Business;
//public static class UserServices
//{
//    public static AppUser AuthenticateUser(AppUser user)
//    {

//        var userQuery = new AppUserQuery();

//        userQuery.QLogInName = new StringFilter()
//        {
//            FilterType = StringFilterType.Exact,
//            Value = user.LogInName,
//        };

//        userQuery.QPassword = new StringFilter()
//        {
//            FilterType = StringFilterType.Exact,
//            Value = user.Password,
//        };

//        var result = userQuery.Run();
//        AppUser foundUser = result.FirstOrDefault();


//        if (foundUser != null)
//        {

//            return foundUser;
//        }
//        else
//        {
//            throw new Exception("Invalid user name or password");

//        }

//    }
////}
