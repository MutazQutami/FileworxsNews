using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FileworxNewsBusiness;
using Newtonsoft.Json;

namespace FileworxsNewsUI
{
    public partial class LoginForm : Form
    {
        private void SignUpProcess(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();

        }
        private void LogInProcess(object sender, EventArgs e)
        {
            if (IsNullLoginFields())
            {
                wrongCredentials.Hide();
                nullFieldWarning.Show();

                return;
            }

            nullFieldWarning.Hide();

            if (IsAuthenticatedUser())
            {

                FileWorx fileWorx = new FileWorx();
                fileWorx.Show();
                return;
            }

            wrongCredentials.Show();
        }
        public LoginForm()
        {
            InitializeComponent();

            nullFieldWarning.Hide();
            wrongCredentials.Hide();
        }
        private bool IsNullLoginFields()
        {
            return string.IsNullOrEmpty(userNameField.Text) ||
                   string.IsNullOrEmpty(passwordField.Text);
        }
        private bool IsAuthenticatedUser()
        {
            AppUser loginUser = new AppUser
            {
                LogInName = userNameField.Text,
                Password = passwordField.Text
            };

            string _usersFilePath = FileHandler.FindPath(loginUser);

            foreach (var file in Directory.GetFiles(_usersFilePath, "*.json"))
            {
                string fileContent = File.ReadAllText(file);
                AppUser deserializedUser = JsonConvert.DeserializeObject<AppUser>(fileContent);

                if (loginUser.IsEqual(deserializedUser))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
