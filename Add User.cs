namespace FileworxsNews
{
    public partial class UserForm : Form
    {
        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtLoginName.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                passMatchWarning.Hide();
                lblNullWarnning.Show();
                return;
            }
            else if (!string.IsNullOrEmpty(txtPassword.Text) &&
                !string.IsNullOrEmpty(txtConfirmPass.Text) &&
                !txtPassword.Text.Equals(txtConfirmPass.Text))
            {

                lblNullWarnning.Hide();
                passMatchWarning.Show();
                return;
            }
            
            if (!isEditForm)
            {
                formUser = new User();
            }

            formUser.Name = txtName.Text;
            formUser.LogInName = txtLoginName.Text;
            formUser.Password = txtPassword.Text;

            FileHandler.JsonSerialization(formUser);

            if (!isEditForm)
            {
                MessageBox.Show("The User Added Successfully!");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public User formUser;
        private bool isEditForm;
        public UserForm(User user)
        {
            InitializeComponent();
            txtPassword.Text = user.Password;
            txtLoginName.Text = user.LogInName;
            txtName.Text = user.Name;
            txtConfirmPass.Text=user.Password;
            isEditForm = true;
            lblNullWarnning.Hide();
            passMatchWarning.Hide();
            formUser = user;
        }
        public UserForm()
        {
            InitializeComponent();
            lblNullWarnning.Hide();
            passMatchWarning.Hide();
            passMatchWarning.Hide();
            isEditForm = false;
        }
    }
}