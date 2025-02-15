using System.CodeDom;
using System.Web;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace FileworxsNews
{
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

    public interface FileWorxEntity

    {
        Guid GuidValue { get; set; }

        public DateTime Date { get; set; }

    }


    public class Content : FileWorxEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Body { get; set; }

        public Guid GuidValue { get;  set; }

        public DateTime Date { get; set; }
        public Content()
        {
            
              GuidValue = Guid.NewGuid();

              Date = DateTime.Now;
        }

    }

    public class User : FileWorxEntity

    {

        public string Name { get; set; }

        public string LogInName { get; set; }

        public string Password { get; set; }

        public string last_modifier { get; set; }



        public DateTime Date { get; set; }

        public Guid GuidValue { get;  set; }


     

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



    public class News : Content
    {

        //public  enum Category { General, Sports, Health, Politics }
        public string Category { get; set; }


    }



    public static class FileHandler

    {

        private static string findPath(FileWorxEntity obj)

        {

            string projectPath = AppDomain.CurrentDomain.BaseDirectory;


            string folderType = string.Empty;



            if (obj is User) 
                folderType = "Users";

            else if (obj is Photo)

            {

                folderType = "Photos";
            }

            else

            {

                folderType = "News";

            }



            string targetFolder = Path.Combine(projectPath, folderType);





            if (!Directory.Exists(targetFolder))

            {

                Directory.CreateDirectory(targetFolder);

            }


            return targetFolder;

        }

        public static void JsonSerialization(FileWorxEntity obj)

        {


            string folderPath = findPath(obj);

            string finalPath = Path.Combine(folderPath, $"{obj.GuidValue}.json");


            if (File.Exists(finalPath))
            {
                File.Delete(finalPath); 
            }


            string jsonObject = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);

            try

            {

                File.WriteAllText(finalPath, jsonObject);


            }

            catch (Exception ex)

            {

                MessageBox.Show("Can't Store the file.");

            }



        }




        public static List<FileWorxEntity> JsonDeserializationObjects(FileWorxEntity obj)
        {
            
            
            List<FileWorxEntity> objectList = new List<FileWorxEntity>();

            string objectsPath = findPath(obj);

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

                    FileWorxEntity deserializedObject = null;

                    if (obj is Photo)
                    {
                        deserializedObject = JsonConvert.DeserializeObject<Photo>(fileContent);
                    }
                    else if (obj is News)
                    {
                        deserializedObject = JsonConvert.DeserializeObject<News>(fileContent);
                    }

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


        public static void deleteObject(FileWorxEntity obj)
        {
       
            string path = findPath(obj);
            path = Path.Combine(path, obj.GuidValue.ToString() + ".json");

            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


           if (result==DialogResult.Yes)
            {
                if (File.Exists(path))

                {

                    File.Delete(path);
                    //MessageBox.Show("File deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                else
                {
                    MessageBox.Show($"Error deleting the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            


        }

    }

}


