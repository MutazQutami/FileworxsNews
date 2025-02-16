using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileworxsNews
{
    public static class FileHandler

    {

        public static string FindPath(FileWorxEntity _obj)

        {

            string _projectPath = AppDomain.CurrentDomain.BaseDirectory; // Path of the current project



            string _folderType = string.Empty;

            _folderType = _obj switch
            {
                User => "Users",
                Photo => "Photos",
                _ => "News"
            };

            string _targetFolder = Path.Combine(_projectPath, _folderType);  // Path according to object type

            if (!Directory.Exists(_targetFolder))

            {

                Directory.CreateDirectory(_targetFolder); // Create the directory if it does not exist

            }

            return _targetFolder;

        }

        public static void JsonSerialization(FileWorxEntity _obj)

        {


            string _folderPath = FindPath(_obj); // Find the appropriate directory


            string _finalPath = Path.Combine(_folderPath, $"{_obj.GuidValue}.json");  // json file with GUID naming


            if (File.Exists(_finalPath))  // duplicate avoidance
            {
                File.Delete(_finalPath);
            }


            string _jsonObject = JsonConvert.SerializeObject(_obj, Newtonsoft.Json.Formatting.Indented);

            try

            {

                File.WriteAllText(_finalPath, _jsonObject);


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Can't Store the file. Error: {ex.Message}");
            }




        }

        public static List<FileWorxEntity> JsonDeserializationObjects(FileWorxEntity _obj)
        {


            List<FileWorxEntity> _objectList = new List<FileWorxEntity>();

            string _objectsPath = FindPath(_obj);

            if (!Directory.Exists(_objectsPath))
            {
                MessageBox.Show("Error: Directory does not exist.");
                return _objectList;
            }

            foreach (var file in Directory.GetFiles(_objectsPath, "*.json"))
            {
                try
                {
                    string fileContent = File.ReadAllText(file);

                    FileWorxEntity deserializedObject = null;

                    if (_obj is Photo)
                    {
                        deserializedObject = JsonConvert.DeserializeObject<Photo>(fileContent);
                    }
                    else if (_obj is New)
                    {
                        deserializedObject = JsonConvert.DeserializeObject<New>(fileContent);
                    }
                    else if (_obj is User)
                    {
                        deserializedObject = JsonConvert.DeserializeObject<User>(fileContent);
                    }



                    if (deserializedObject != null)
                    {
                        _objectList.Add(deserializedObject);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file {file}: {ex.Message}");
                }
            }

            return _objectList;
        }

        public static void DeleteObject(FileWorxEntity _obj)
        {
            string _path = FindPath(_obj);
            _path = Path.Combine(_path, _obj.GuidValue.ToString() + ".json");

            if (File.Exists(_path))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    if (File.Exists(_path))

                    {

                        File.Delete(_path);

                    }
                    else
                    {
                        MessageBox.Show($"Error deleting the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }


        }

    }
}
