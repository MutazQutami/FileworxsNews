using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxNewsBusiness
{
    public class Content : FileWorxEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
    }
}
