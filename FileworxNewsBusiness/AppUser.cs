namespace FileworxNewsBusiness;
public class AppUser : FileWorxEntity
{
    public string Name { get; set; }
    public string LogInName { get; set; }
    public string Password { get; set; }
    public Guid LastModifier { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public bool IsAdmin { get; set; }
    public bool IsEqual(AppUser? other)
    {
        if (other == null ||
            string.IsNullOrEmpty(LogInName) ||
            string.IsNullOrEmpty(Password))
            return false;
        return LogInName == other.LogInName && Password == other.Password;
    }
    public AppUser()
    {
        IsAdmin = false;
        LastModifier = GuidValue;
        LastModifiedDate = Date;
    }
}