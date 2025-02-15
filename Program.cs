using System.CodeDom;
using System.Web;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace FileworxsNews
{



    public interface IFileWorxEntity

    {
        Guid GuidValue { get; set; }

        public DateTime Date { get; set; }

    }


    public class Content : IFileWorxEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Body { get; set; }

        public Guid GuidValue { get; set; }

        public DateTime Date { get; set; }
        public Content()
        {

            GuidValue = Guid.NewGuid();

            Date = DateTime.Now;
        }

    }

    public class User : IFileWorxEntity

    {

        public string Name { get; set; }

        public string LogInName { get; set; }

        public string Password { get; set; }

        public string Last_modifier { get; set; }



        public DateTime Date { get; set; }

        public Guid GuidValue { get; set; }




        public User()

        {

            GuidValue = Guid.NewGuid();

            Date = DateTime.Now;

        }

    }



    public class Photo : Content

    {

        public string photoName;

        public string photoPath;

    }



    public class New : Content
    {

        //public  enum Category { General, Sports, Health, Politics }
        public string Category { get; set; }


    }



    public static class FileHandler

    {

        public static string FindPath(IFileWorxEntity _obj)

        {

            string _projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string _folderType = string.Empty;



            _folderType = _obj switch
            {
                User => "Users",
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

        public static void JsonSerialization(IFileWorxEntity _obj)

        {


            string _folderPath = FindPath(_obj);

            string _finalPath = Path.Combine(_folderPath, $"{_obj.GuidValue}.json");


            if (File.Exists(_finalPath))
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




        public static List<IFileWorxEntity> JsonDeserializationObjects(IFileWorxEntity _obj)
        {


            List<IFileWorxEntity> _objectList = new List<IFileWorxEntity>();

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

                    IFileWorxEntity deserializedObject = null;

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


        public static void DeleteObject(IFileWorxEntity _obj)
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


    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Dashboard());



        }
    }


}


