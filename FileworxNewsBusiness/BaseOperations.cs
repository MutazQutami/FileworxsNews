namespace FileworxNewsBusiness;
public static class BaseOperations<T> where T : FileWorxEntity ,new()
{
    public static void Add(T _entity)
    {
        try
        {
            FileHandler<T>.AddObjectJsonFile(_entity);
            
        }
        catch (Exception ex)
        {

            return;
        }
    }
    public static void Update(T _newEntity)
    {
        try
        {
            FileHandler<T>.UpdateObjectJsonFile(_newEntity);
        }
        catch (Exception ex)
        {
            return ;
        }
    }
    public static void Delete(T _entity)
    {
        try
        {
            FileHandler<T>.DeleteObjectJsonFile(_entity);
        }
        catch (Exception ex)
        {
            return;
        }
    }
    public static T Retrieve(Guid _guidValue)
    {
        return (T)FileHandler<T>.RetrieveObjectFromJson(new T { GuidValue= _guidValue});
    }
    public static List<T> RetrieveAll()
    {
        return FileHandler<T>.RetrieveObjectsFromJson(new T()).Cast<T>().ToList();
    }
}
