using System.Security.Cryptography;
using System.Windows.Forms;
using FileworxNewsBusiness;
using Microsoft.VisualBasic.ApplicationServices;

namespace FileworxsNewsUI
{
    public partial class UserForm : Form
    {
        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            if (!AreFieldsValid())
            {
                passMatchWarning.Hide();
                lblNullwarning.Show();

                return;
            }
            if (!ArePasswordsEqual())
            {

                lblNullwarning.Hide();
                passMatchWarning.Show();

                return;
            }

            AppUser _appUserItem = UserFormData();
            string _message=string.Empty;

            try
            {
                AppUser _checkUser = UserServices.RetrieveUser(_appUserItem.GuidValue);

                if(_checkUser != null) //Existing User , update
                {
                    if (UserServices.UpdateUser(_appUserItem, out _message))
                    {
                        CompletedRegistration(_message);
                    }
                    else
                    {
                        InCompleteRegistration(_message);   
                    }
                }
                else if (UserServices.SignUp(_appUserItem , out _message)) // New user , Sign up
                {
                    CompletedRegistration(_message);
                }
                else
                {
                    InCompleteRegistration(_message);

                }
            }
            catch (Exception _ex)
            {
                MessageBox.Show($"An unexpected error occurred: {_ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
        public  Guid FormGuidValue;
        public UserForm() : this(Guid.NewGuid()) { }
        public UserForm(Guid _guidValue)
        {
            InitializeComponent();

            FormGuidValue = _guidValue;

            AppUser _userItem = UserServices.RetrieveUser(_guidValue);

            InitializeUserForm(_userItem);

            lblNullwarning.Hide();
            passMatchWarning.Hide();
        }
        private void InitializeUserForm(AppUser _userItem)
        {
            if(_userItem is null)
            {
                _userItem =new AppUser(); // New User Form
                return;
            }

            lblTitle.Text = "Edit User"; // Edit User Form
            this.Text = "Edit User";

            txtPassword.Text = _userItem.Password;
            txtLoginName.Text = _userItem.LogInName;
            txtName.Text = _userItem.Name;
            txtConfirmPass.Text = _userItem.Password;
        }
        private bool AreFieldsValid()
        {
            return !string.IsNullOrWhiteSpace(txtName.Text) &&
            !string.IsNullOrWhiteSpace(txtLoginName.Text) &&
            !string.IsNullOrWhiteSpace(txtPassword.Text) &&
            !string.IsNullOrWhiteSpace(txtConfirmPass.Text);
        }
        private bool ArePasswordsEqual()
        {
            return AreFieldsValid() &&
            txtPassword.Text.Equals(txtConfirmPass.Text);
        }
        private AppUser UserFormData()
        {
            return new AppUser
            {
                LogInName = txtLoginName.Text,
                Name = txtName.Text,
                Password = txtPassword.Text,
                GuidValue = FormGuidValue
            };
        }
        private void CompletedRegistration(string _message)
        {
            MessageBox.Show(_message);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void InCompleteRegistration(string _message)
        {
            MessageBox.Show(_message);
        }
    }
}