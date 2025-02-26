using FilworxNewsDataAccess;
namespace FileworxNewsBusiness;
public static class BaseOperations<T> where T :FileWorxEntity, new()
{
    //public static void Add(T _entity)
    //{
    //    try
    //    {
    //        DatabaseOperations<T>.AddElement(_entity);

    //    }
    //    catch (Exception ex)
    //    {

    //        return;
    //    }
    //}
    //public  static void Update(T _newEntity)
    //{
    //    try
    //    {
    //        DatabaseOperations<T>.UpdateElement(_newEntity);
    //    }
    //    catch (Exception ex)
    //    {
    //        return ;
    //    }
    //}
    //public  static void Delete(T _entity)
    //{
    //    try
    //    {
    //      DatabaseOperations<T>.DeleteElement(_entity);
    //    }
    //    catch (Exception ex)
    //    {
    //        return;
    //    }
    //}
    public static T Retrieve(Guid _guidValue)
    {
        return DatabaseOperations<T>.GetElementById(_guidValue);
    }
    public static List<T> RetrieveAll()
    {
        return DatabaseOperations<T>.GetElements();
    }
}
