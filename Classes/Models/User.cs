using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxNews.Shared.Models
{
    public class User : FileWorxEntity
    {
        public string LogInName { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}