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
        public static void AddNew(New _newsItem)
        {
             BaseServices.Add(_newsItem);
        }
        public static void UpdateNew(New _newsItem)
        {
             BaseServices.Update(_newsItem);
        }
        public static void DeleteNew(Guid _guidValue)
        {
             BaseServices.Delete(new New { GuidValue = _guidValue });
        }
        public static New RetrieveNew(Guid _guidValue)
        {
            return (New)BaseServices.Retrieve(new New { GuidValue = _guidValue });
        }
        public static List<New> RetrieveNews()
        {
            return BaseServices.RetrieveObjects(new New()).Cast<New>().ToList();
        }
    }
}
