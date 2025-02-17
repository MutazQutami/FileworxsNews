using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxsNews
{
    public class FileWorxEntity

    {
        public Guid GuidValue { get; set; }
        public DateTime Date { get; set; }
        public FileWorxEntity()
        {
            GuidValue = Guid.NewGuid();
            Date = DateTime.Now;
        }
    }
}
