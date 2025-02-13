using Newtonsoft.Json;

namespace FileworxsNews
{
    public partial class UsersListForm : Form
    {
        public UsersListForm()
        {
            InitializeComponent();
            resizeUsersTable();
            retreiveUsers();
        }

        public void resizeUsersTable()
        {
            int columnWidth = userList.Width;

            //for (int i = 0; i < userList.Columns.Count; i++) {
            //    userList.Columns[0].Width = (int)(columnWidth * 0.25);

            //}

            userList.Columns[0].Width = (int)(columnWidth * 0.25);
            userList.Columns[1].Width = (int)(columnWidth * 0.25);
            userList.Columns[2].Width = (int)(columnWidth * 0.25);
            userList.Columns[3].Width = (int)(columnWidth * 0.25);


        }

        private void UsersList_Resize(object sender, EventArgs e)
        {
            resizeUsersTable();
        }

        public void retreiveUsers()
        {

            userList.Items.Clear();

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string photosPath = Path.Combine(baseDirectory, "Users");

            if (Directory.Exists(photosPath))
            {
                foreach (var file in Directory.GetFiles(photosPath, "*.json"))
                {
                    try
                    {
                        string fileContent = File.ReadAllText(file);
                        var deserializedUser = JsonConvert.DeserializeObject<User>(fileContent);

                        if (deserializedUser != null)
                        {
                            ListViewItem listItem = new ListViewItem(deserializedUser.Name);


                            listItem.SubItems.Add(deserializedUser.LogInName);
                            listItem.SubItems.Add(deserializedUser.Date.ToString());
                            listItem.SubItems.Add(deserializedUser.last_modifier);


                            listItem.Tag = deserializedUser;
                            userList.Items.Add(listItem);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error reading file {file}: {ex.Message}");
                    }
                }
            }


        }
    }
}
