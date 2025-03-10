using System.ComponentModel.DataAnnotations;
using FileworxNews.Business.Repos;

namespace FileworxNews.Business.Models;
public class User : FileWorxEntity
{
    private IUserRepo _repo;
    
    public string LogInName { get; set; }

    public string Password { get; set; }

    public bool IsAdmin { get; set; }
    
    public User() => IsAdmin = false;

    public User(IUserRepo repo) => _repo = repo;

    public bool IsEqual(User? other)
    {
        if (other == null || string.IsNullOrEmpty(LogInName) || string.IsNullOrEmpty(Password))
            return false;

        return LogInName == other.LogInName && Password == other.Password;
    }

    public override async Task Update()
    {
        Validate();
        await _repo.Update(this);
        
    }

    public override async Task Delete() => await _repo.Delete(this);
   
    public  async Task<User> Read() => await _repo.Read(this);

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
