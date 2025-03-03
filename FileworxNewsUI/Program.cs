namespace FileworxsNewsUI;

using FileworxNewsBusiness;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    /// 
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // create admin user for the first time

            //AppUser user1 = new AppUser()
            //{
            //    LogInName = "admin",
            //    Password = "123",
            //    Name = "admin",
            //    IsAdmin = true,
            //};
            //user1.Update();

        Application.Run(new FileWorx());
    }
}
// last program

