using FileworxNewsBusiness;
using Microsoft.VisualBasic.ApplicationServices;
namespace FileworxsNewsUI;
public partial class LoginForm : Form
{
    private void SignUpProcess(object sender, EventArgs e)
    {
        UserForm userForm = new UserForm();
        this.Hide();
        DialogResult result = userForm.ShowDialog();

        if (result == DialogResult.OK || result == DialogResult.Cancel)
        {
            this.Show();
        }
    }
    private  void LogInProcess(object sender, EventArgs e)
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

        AppUser _appUser = new AppUser
        {
            LogInName = userNameField.Text,
            Password = passwordField.Text
        };

        AppUser currentUser;
        try
        {
            currentUser = UserServices.AuthenticateUser(_appUser);

            FileWorx fileWorx = new FileWorx(currentUser);
            this.Hide();
            fileWorx.Show();
            return;
        }
        catch (Exception ex) {
            lblWrongCredentials.Show();
        }
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
