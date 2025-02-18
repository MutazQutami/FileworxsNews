using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxNewsBusiness
{
    public static class NewServices 
    {
        public static bool AddNew(New _newsItem)
        {
            return BaseServices.Add(_newsItem);
        }
        public static bool UpdateNew(New _newsItem)
        {
            return BaseServices.Update(_newsItem);
        }
        public static bool DeleteNew(Guid _guidValue)
        {
            return BaseServices.Delete(new New { GuidValue = _guidValue });
        }
        public static New RetrieveNew(Guid _guidValue)
        {
            return (New)BaseServices.Retrieve(new New { GuidValue = _guidValue });
        }
        public static List<New> RetrieveNews()
        {
            return BaseServices.RetriveObjects(new New()).Cast<New>().ToList();
        }

    }
}
