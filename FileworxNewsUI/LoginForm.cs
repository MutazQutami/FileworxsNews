using FileworxNewsBusiness;
namespace FileworxsNewsUI;
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

        AppUser _appUser = new AppUser
        {
            LogInName = userNameField.Text,
            Password = passwordField.Text
        };

        if (UserServices.AuthenticateUser(_appUser))
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
}
