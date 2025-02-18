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
                lblNullWarnning.Show();

                return;
            }
            if (!ArePasswordsEqual())
            {

                lblNullWarnning.Hide();
                passMatchWarning.Show();

                return;
            }

            AppUser _appUserItem = FormUserInfo();

            try
            {
                FileHandler.JsonSerialization(_appUserItem);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception _ex) 
            {
                MessageBox.Show($"An unexpected error occurred: {_ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
        private FileWorxEntity _relatedFormEntity;
        public UserForm() : this(null) { }
        public UserForm(AppUser _userItem)
        {
            InitializeComponent();

            InitializeUserForm(_userItem);

            lblNullWarnning.Hide();
            passMatchWarning.Hide();
        }
        private void InitializeUserForm(AppUser _userItem)
        {
            _userItem = _userItem ?? new AppUser();

            txtPassword.Text = _userItem.Password;
            txtLoginName.Text = _userItem.LogInName;
            txtName.Text = _userItem.Name;
            txtConfirmPass.Text = _userItem.Password;
            _relatedFormEntity = new FileWorxEntity {
                Date=_userItem.Date,
                GuidValue = _userItem.GuidValue,
            };

        }
        public AppUser FormUserInfo()
        {
            return new AppUser()
            {
                Name = txtName.Text,
                LogInName = txtLoginName.Text,
                Password = txtPassword.Text,
                GuidValue = _relatedFormEntity is null ? Guid.NewGuid()
                :(_relatedFormEntity.GuidValue),
                Date= _relatedFormEntity is null ? DateTime.Now : _relatedFormEntity.Date,
            };
        }
        private bool AreFieldsValid()
        {
            return !string.IsNullOrEmpty(txtName.Text) &&
            !string.IsNullOrEmpty(txtLoginName.Text) &&
            !string.IsNullOrEmpty(txtPassword.Text) &&
            !string.IsNullOrEmpty(txtConfirmPass.Text);
        }
        private bool ArePasswordsEqual()
        {
            return AreFieldsValid() &&
            txtPassword.Text.Equals(txtConfirmPass.Text);
        }
    }
}