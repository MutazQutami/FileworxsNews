using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

namespace FileworxNewsBusiness;
public class AppUser : FileWorxEntity
{
    public string LogInName { get; set; }

    public string Password { get; set; }

    public bool IsAdmin { get; set; }

    public ICollection<FileWorxEntity> CreatedEntities { get; set; }
    public ICollection<FileWorxEntity> ModifiedEntities { get; set; }

    public AppUser()
    {
        IsAdmin = false;
    }

    public bool IsEqual(AppUser? other)
    {
        if (other == null || string.IsNullOrEmpty(LogInName) || string.IsNullOrEmpty(Password))
            return false;

        return LogInName == other.LogInName && Password == other.Password;
    }

    public override void Update()
    {
        Validate();

        using (var context = new Context())
        {
            try
            {
                if (context.User.Any(x => x.LogInName == this.LogInName && x.Id != Id))// Duplicate Login name
                {
                    throw new Exception("Invalid Login Name");
                }
                if (Id == Guid.Empty)
                {
                    Id = Guid.NewGuid();
                    CreatorId = null;
                    LastModifierId = null;
                    context.User.Add(this);

                    if (CreatorId == null)
                    {
                        InitializeUserIds();
                        this.Update();
                    }
                }
                else
                {
                    context.Entry(this).State = EntityState.Modified;
                    context.Entry(this).CurrentValues.SetValues(this);
                }
                context.SaveChanges();

              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public override void Delete()
    {
        using (var context = new Context())
        {
            if(LastModifierId!= null)
            {
                this.LastModifierId = null;
                this.CreatorId = null;
                this.Update();
            }

            try
            {
                context.User.Remove(this);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting User.", ex);
            }
        }
    }
    public override AppUser Read()
    {
        using (var context = new Context())
        {
            return context.User.SingleOrDefault(x => x.Id == this.Id);
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

    private void InitializeUserIds()
    {
        CreatorId = Id;
        LastModifierId = Id;
    }
}
