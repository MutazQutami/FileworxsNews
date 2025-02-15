using System.Windows.Forms;
using Newtonsoft.Json;

namespace FileworxsNews
{
    public partial class UsersListForm : Form
    {

        private void UsersList_Resize(object sender, EventArgs e)
        {
            ResizeUsersTable();
        }

        public UsersListForm()
        {
            InitializeComponent();
            ResizeUsersTable();
            RetreiveUsers();
        }


        public void ResizeUsersTable()
        {
            int _columnWidth = userList.Width;


            for (int i = 0; i < userList.Columns.Count; i++)
            {
                userList.Columns[i].Width = (int)(_columnWidth * 0.25);
            }


        }

        public void RetreiveUsers()
        {

            userList.Items.Clear();

            List<User> _users = FileHandler.JsonDeserializationObjects(new User()).Cast<User>().ToList();

            foreach (var item in _users)
            {
                ListViewItem listItem = new ListViewItem(item.Name);
                listItem.SubItems.Add(item.LogInName);
                listItem.SubItems.Add(item.Date.ToString());
                listItem.SubItems.Add(item.Last_modifier);

                listItem.Tag = item;
                userList.Items.Add(listItem);

            }
        }
      

    }
}
