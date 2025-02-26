using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace FileworxNewsBusiness;
public class AppUser : FileWorxEntity
{
    public string LogInName { get; set; }
    public string Password { get; set; }
    public Guid LastModifier { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public bool IsAdmin { get; set; }
    public bool IsEqual(AppUser? other)
    {
        if (other == null || string.IsNullOrEmpty(LogInName) || string.IsNullOrEmpty(Password))
            return false;

        return LogInName == other.LogInName && Password == other.Password;
    }
    public AppUser()
    {
        IsAdmin = false;
        LastModifier = Id;
        LastModifiedDate = Date;
    }
    public new void Update()
    {
        Validate();
        using (var context = new Context())
        {
            try

            {

               if (context.Users.Any(x => x.LogInName == LogInName && x.Id != Id))
               {
                    throw new Exception("Invalid login name");
                    
               }

                var user = context.Users.FirstOrDefault(x => x.Id == this.Id);
                if (user == null)
                {
                    context.Users.Add(this);
                }
                else
                {
                    context.Entry(user).CurrentValues.SetValues(this);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    public new void Delete()
    {
        using (var context = new Context())
        {
            try
            {
                var user = context.Users.SingleOrDefault(x => x.Id == this.Id);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("User not found for deletion.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting user.", ex);
            }
        }
    }
    public new AppUser Read()
    {
        using (var context = new Context())
        {
            return context.Users.SingleOrDefault(x => x.Id == this.Id);
        }
    }
    private void Validate()
    {

        if (string.IsNullOrEmpty(Name))
            throw new ValidationException("Name cannot be empty.");

        if (string.IsNullOrEmpty(LogInName))
            throw new ValidationException("LogInName cannot be empty.");

        if (string.IsNullOrEmpty(Password))
            throw new ValidationException("Password cannot be empty.");
    }
}