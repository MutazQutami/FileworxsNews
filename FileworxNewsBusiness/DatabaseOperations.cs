using FileworxNewsBusiness;
using Microsoft.EntityFrameworkCore;

namespace FilworxNewsDataAccess
{
    public static class DatabaseOperations<T> where T : FileWorxEntity, new()
    {
        private static readonly Context Context = new Context();
        public static List<T> GetElements()
        {
            return Context.Set<T>().ToList();
        }
        public static T GetElementById(Guid id)
        {
            return Context.Find<T>(id);
        }
    }
}
