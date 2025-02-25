using FileworxNewsBusiness;
using Microsoft.EntityFrameworkCore;

namespace FilworxNewsDataAccess
{
    public static class DatabaseOperations<T> where T : FileWorxEntity, new()
    {
        private static readonly FileWorxContext Context = new FileWorxContext();
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
            var existingEntity = Context.Find<T>(Object.GuidValue);

            if (existingEntity != null)
            {
                Context.Entry(existingEntity).CurrentValues.SetValues(Object); // Update values
            }
            else
            {
                Context.Add(Object);
            }

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
