using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace FileworxsNews
{
    public partial class Login : Form
    {
        private void SignUp(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Size = this.Size;
            userForm.ShowDialog();
        }
        private void LogIn(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameField.Text) || string.IsNullOrEmpty(passwordField.Text))
            {
                wrongCredentials.Hide();
                nullFieldWarning.Show();
                return;
            }

            nullFieldWarning.Hide();
            User loginUser = new User
            {
                LogInName = userNameField.Text,
                Password = passwordField.Text
            };

            string usersFilePath = FileHandler.FindPath(loginUser);

            foreach (var file in Directory.GetFiles(usersFilePath, "*.json"))
            {
                string fileContent = File.ReadAllText(file);
                User deserializedUser = JsonConvert.DeserializeObject<User>(fileContent);

                if (loginUser.IsEqual(deserializedUser))
                {
                    FileWorx fileWorx = new FileWorx();
                    fileWorx.Show();
                    return;
                }
            }
            wrongCredentials.Show();
        }
        public Login()
        {
            InitializeComponent();
            nullFieldWarning.Hide();
            wrongCredentials.Hide();
        }

    }
}
