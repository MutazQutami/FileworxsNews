using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxsNews
{
    public class User : Content
    {
        public string Name { get; set; }
        public string LogInName { get; set; }
        public string Password { get; set; }
        public string LastModifier { get; set; }
        public bool IsEqual(User? other)
        {
            if (other == null ||
                string.IsNullOrEmpty(LogInName) ||
                string.IsNullOrEmpty(Password))
                return false;

            return LogInName == other.LogInName && Password == other.Password;
        }
    }
}
