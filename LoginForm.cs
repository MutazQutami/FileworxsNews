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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();

            nullFieldWarning.Hide();
            wrongCredentials.Hide();
        }



        private void signUpLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();


            UserForm user = new UserForm();
            user.Size = this.Size;
            user.ShowDialog();



        }



        private void logInButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userNameField.Text) || String.IsNullOrEmpty(passwordField.Text))
            {
                wrongCredentials.Hide();
                nullFieldWarning.Show();
            }
            else
            {

                nullFieldWarning.Hide();



                //search for username and password


                User loginUser = new User();

                loginUser.LogInName = userNameField.Text;
                loginUser.Password = passwordField.Text;

                string UsersFile = FileHandler.FindPath(loginUser);


                // compare with all users

                foreach (var file in Directory.GetFiles(UsersFile, "*.json"))
                {

                    // extract the content of the user 

                    string fileContent = File.ReadAllText(file);
                    User deserializeduser = JsonConvert.DeserializeObject<User>(fileContent);

                    if (loginUser.IsEqual(deserializeduser))
                    {

                        FileWorx filewors = new FileWorx();   // success 
                        this.Hide();
                        filewors.Show();
                        return;




                    }




                }
                wrongCredentials.Show(); // fail
            }
        }
    }
}


