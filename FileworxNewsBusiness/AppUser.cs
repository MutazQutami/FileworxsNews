using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxNewsBusiness
{
    public class AppUser : Content
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
}