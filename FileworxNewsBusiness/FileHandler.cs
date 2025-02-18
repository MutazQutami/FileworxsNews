using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileworxNewsBusiness
{
    public static class FileHandler
    {
        public static string FindPath(FileWorxEntity obj)
        {
            string _projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string _folderType = obj switch
            {
                AppUser => "Users",
                Photo => "Photos",
                _ => "News"
            };

            string _targetFolder = Path.Combine(_projectPath, _folderType);

            if (!Directory.Exists(_targetFolder))
            {
                Directory.CreateDirectory(_targetFolder);
            }

            return _targetFolder;
        }
        public static void JsonSerialization(FileWorxEntity _obj)
        {
            string _folderPath = FindPath(_obj);
            string _finalPath = Path.Combine(_folderPath, $"{_obj.GuidValue}.json");

            if (File.Exists(_finalPath))
            {
                File.Delete(_finalPath);
            }

            string _jsonObject = JsonConvert.SerializeObject(_obj, Formatting.Indented);

            try
            {
                File.WriteAllText(_finalPath, _jsonObject);
            }
            catch (Exception _ex)
            {
                //MessageBox.Show($"Can't store the file. Error: {_ex.Message}");
            }
        }
        public static List<FileWorxEntity> JsonDeserializationObjects(FileWorxEntity _obj)
        {
            List<FileWorxEntity> _objectList = new List<FileWorxEntity>();
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
                    FileWorxEntity _deserializedObject = _obj switch
                    {
                        Photo => JsonConvert.DeserializeObject<Photo>(_fileContent),
                        New => JsonConvert.DeserializeObject<New>(_fileContent),
                        AppUser => JsonConvert.DeserializeObject<AppUser>(_fileContent),
                        _ => null
                    };

                    if (_deserializedObject != null)
                    {
                        _objectList.Add(_deserializedObject);
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Error reading file {_file}: {ex.Message}");
                }
            }

            return _objectList;
        }
        public static void DeleteObject(FileWorxEntity _obj)
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
                    //MessageBox.Show("Error deleting the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
