namespace FileworxNewsBusiness;
public class AppUser : FileWorxEntity
{
    public string Name { get; set; }
    public string LogInName { get; set; }
    public string Password { get; set; }
    public string LastModifier { get; set; }
    public bool IsEqual(AppUser? other)
    {
        if (other == null ||
            string.IsNullOrEmpty(LogInName) ||
            string.IsNullOrEmpty(Password))
            return false;
        return LogInName == other.LogInName && Password == other.Password;
    }
}