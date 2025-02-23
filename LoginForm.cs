using Newtonsoft.Json;
namespace FileworxsNews;
public partial class LoginForm : Form
{
    private void SignUp(object sender, LinkLabelLinkClickedEventArgs e)
    {
        UserForm userForm = new UserForm();
        userForm.Size = this.Size;
        this.Hide();

        // Show the form as a dialog and store the result in a variable
        DialogResult result = userForm.ShowDialog();

        // Check the dialog result
        if (result == DialogResult.OK || result == DialogResult.Cancel)
        {
            this.Show();
        }
    }
    private void LogIn(object sender, EventArgs e)
    {
        HideLables();

        bool isUsernameEmpty = string.IsNullOrWhiteSpace(userNameField.Text);
        bool isPasswordEmpty = string.IsNullOrWhiteSpace(passwordField.Text);

        if (isUsernameEmpty || isPasswordEmpty)
        {
            if (isUsernameEmpty)
                lblNullUsername.Show();

            if (isPasswordEmpty)
                lblNullPassword.Show();

            return;
        }

        HideLables();

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
                this.Hide();
                return;
            }
        }

        lblWrongCredentials.Show();
    }
    public LoginForm()
    {
        InitializeComponent();
    }
    private void HideLables()
    {
        lblNullUsername.Hide();
        lblNullPassword.Hide();
        lblWrongCredentials.Hide();
    }
}
