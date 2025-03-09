using System.ComponentModel.DataAnnotations;
using FileworxNews.Shared.Models;

namespace FileworxNews.Shared;
public class UserDto : FileWorxEntityDto
{
    public string LogInName { get; set; }

    public string Password { get; set; }

    public bool IsAdmin { get; set; }

    
}
