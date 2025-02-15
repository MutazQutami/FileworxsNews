using FileworxsNews;
using Newtonsoft.Json;

namespace FileworxsNews
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void Contentpanel_Click(object sender, EventArgs e)
        {
            FileWorx filewors = new FileWorx();
            filewors.Show();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
            userForm.StartPosition = this.StartPosition;
        }

        private void UsersList_Click(object sender, EventArgs e)
        {
            UsersListForm usersList = new UsersListForm();
            usersList.ShowDialog();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            NewsForm newsForm = new NewsForm();
            newsForm.ShowDialog();
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            PhotoForm photoForm = new PhotoForm();
            photoForm.ShowDialog();
        }
    }
}


