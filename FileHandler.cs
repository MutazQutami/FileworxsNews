using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FileworxsNews
{
    public static class FileHandler
    {
        public static string FindPath(FileWorxEntity obj)
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderType = obj switch
            {
                User => "Users",
                Photo => "Photos",
                _ => "News"
            };

            string targetFolder = Path.Combine(projectPath, folderType);

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            return targetFolder;
        }

        public static void JsonSerialization(FileWorxEntity obj)
        {
            string folderPath = FindPath(obj);
            string finalPath = Path.Combine(folderPath, $"{obj.GuidValue}.json");

            if (File.Exists(finalPath))
            {
                File.Delete(finalPath);
            }

            string jsonObject = JsonConvert.SerializeObject(obj, Formatting.Indented);

            try
            {
                File.WriteAllText(finalPath, jsonObject);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't store the file. Error: {ex.Message}");
            }
        }

        public static List<FileWorxEntity> JsonDeserializationObjects(FileWorxEntity obj)
        {
            List<FileWorxEntity> objectList = new List<FileWorxEntity>();
            string objectsPath = FindPath(obj);

            if (!Directory.Exists(objectsPath))
            {
                MessageBox.Show("Error: Directory does not exist.");
                return objectList;
            }

            foreach (var file in Directory.GetFiles(objectsPath, "*.json"))
            {
                try
                {
                    string fileContent = File.ReadAllText(file);
                    FileWorxEntity deserializedObject = obj switch
                    {
                        Photo => JsonConvert.DeserializeObject<Photo>(fileContent),
                        New => JsonConvert.DeserializeObject<New>(fileContent),
                        User => JsonConvert.DeserializeObject<User>(fileContent),
                        _ => null
                    };

                    if (deserializedObject != null)
                    {
                        objectList.Add(deserializedObject);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file {file}: {ex.Message}");
                }
            }

            return objectList;
        }

        public static void DeleteObject(FileWorxEntity obj)
        {
            string path = Path.Combine(FindPath(obj), $"{obj.GuidValue}.json");

            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error deleting the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
