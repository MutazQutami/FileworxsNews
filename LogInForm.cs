using Newtonsoft.Json;

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


                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;  // the project path

                string UsersFile = Path.Combine(baseDirectory, "Users");      //user foder

                //List <User> Users = new List<User> ();    


                foreach (var file in Directory.GetFiles(UsersFile, "*.json"))
                {

                    string fileContent = File.ReadAllText(file);
                    var deserializeduser = JsonConvert.DeserializeObject<User>(fileContent);

                    if (deserializeduser.LogInName == userNameField.Text)
                    {
                        if (deserializeduser.Password == passwordField.Text)
                        {
                            FileWorx filewors = new FileWorx();   // success 
                            this.Hide();
                            filewors.Show();


                        }
                    }



                }

                wrongCredentials.Show(); // fail


            }
        }
    }
}
