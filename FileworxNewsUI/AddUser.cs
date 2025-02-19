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

            try
            {
                if(UserServices.SignUp(_appUserItem))
                {
                    UserServices.AddUser(_appUserItem);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Choose Another Login name");
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
            _userItem = _userItem ?? new AppUser();

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
    }
}