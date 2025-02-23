using Newtonsoft.Json;
namespace FileworxNewsBusiness;
internal static class FileHandler<T>  where T : FileWorxEntity , new()
 {
    public static string FindPath(T obj)
    {
        string _projectPath = AppDomain.CurrentDomain.BaseDirectory; // Path of the currunt project
        string _folderType = typeof(T) switch                       // Folder Type based on T
        {
            Type t when t == typeof(AppUser) => "Users",
            Type t when t == typeof(Photo) => "Photos",
            _ => "News"
        };

        string _targetFolder = Path.Combine(_projectPath, _folderType); 

        if (!Directory.Exists(_targetFolder))
        {
            Directory.CreateDirectory(_targetFolder);
        }

        return _targetFolder;
    }
    public static void AddObjectJsonFile(T _obj)
    {
        string _folderPath = FindPath(_obj);
        string _finalPath = Path.Combine(_folderPath, $"{_obj.GuidValue}.json");

        if (File.Exists(_finalPath))
        {
            UpdateObjectJsonFile(_obj );
        }

        string _jsonObject = JsonConvert.SerializeObject(_obj, Formatting.Indented);

        try
        {
            File.WriteAllText(_finalPath, _jsonObject);
        }
        catch (Exception _ex)
        {
            return;
        }
    }
    public static List<T> RetrieveObjectsFromJson(T _obj)
    {
        List<T> _objectList = new List<T>();
        string _objectsPath = FindPath(_obj);

        if (!Directory.Exists(_objectsPath))
        {
            //MessageBox.Show("Error: Directory does not exist.");
            return _objectList;
        }

        foreach (var _file in Directory.GetFiles(_objectsPath, "*.json"))
        {
            try
            {
                string _fileContent = File.ReadAllText(_file);
                var _deserializedObject = JsonConvert.DeserializeObject<T>(_fileContent);

                if (_deserializedObject != null)
                {
                    _objectList.Add(_deserializedObject);
                }
            }
            catch (Exception ex)
            {
                return _objectList;
            }
        }

        return _objectList;
        }
    public static void DeleteObjectJsonFile(T _obj)
    {
        string _path = Path.Combine(FindPath(_obj), $"{_obj.GuidValue}.json");

        if (File.Exists(_path))
        {
            try
            {
                File.Delete(_path);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
    public static T RetrieveObjectFromJson(T _obj)
    {
        string _folderPath = FindPath(_obj);
        string _finalPath = Path.Combine(_folderPath, $"{_obj.GuidValue}.json");

        if (!File.Exists(_finalPath))
        {
            return null;
        }
        else
        {
            string _fileContent = File.ReadAllText(_finalPath);

            var _deserializedObject = JsonConvert.DeserializeObject<T>(_fileContent);
            {
                return _deserializedObject;
            }
        }
        return null;
    }
    public static void UpdateObjectJsonFile(T _obj )
    {
        string _folderPath = FindPath(_obj);
        string _finalPath = Path.Combine(_folderPath, $"{_obj.GuidValue}.json");

        if (File.Exists(_finalPath))
        {
            string _fileContent = File.ReadAllText(_finalPath);
            var _deserializedObject = JsonConvert.DeserializeObject<T>(_fileContent);

            if (_deserializedObject != null)
            {
                _obj.Date = _deserializedObject.Date;
                _obj.GuidValue = _deserializedObject.GuidValue;

                string updatedContent = JsonConvert.SerializeObject(_obj, Formatting.Indented);
                File.WriteAllText(_finalPath, updatedContent);
            }
        }

    }
}
