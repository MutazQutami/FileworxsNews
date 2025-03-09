using System.Diagnostics.Eventing.Reader;
using FileworxNews.Busniess.Models;
using Microsoft.VisualBasic.ApplicationServices;
namespace FileworxsNewsUI;
public partial class LoginForm : Form
{
    private void SignUpProcess(object sender, EventArgs e)
    {
        UserForm userForm = new UserForm();

        this.Hide();

        if (userForm.ShowDialog() == DialogResult.OK || userForm.ShowDialog() == DialogResult.Cancel)
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

        FileworxNews.Busniess.Models.User checkUser = new FileworxNews.Busniess.Models.User
        {
            LogInName = userNameField.Text,
            Password = passwordField.Text
        };

        try
        {
            SharedClass.CurrentUser = UserServices.AuthenticateUser(checkUser);

            var fileWorx = new FileWorx();

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
