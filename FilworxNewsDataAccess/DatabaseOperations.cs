using FileworxNewsBusiness;
using Microsoft.EntityFrameworkCore;

namespace FilworxNewsDataAccess
{
    public static class DatabaseOperations<T> where T : FileWorxEntity, new()
    {
        private static readonly FilworxContext Context = new FilworxContext();
        public static void AddElement(T Object)
        {
            Context.Add(Object);
            Context.SaveChanges();
        }
        public static void DeleteElement(T Object)
        {
            Context.Remove(Object);
            Context.SaveChanges();
        }
        public static void UpdateElement(T Object)
        {
            Context.Update(Object);
             Context.SaveChanges();
        }
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
