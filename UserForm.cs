namespace FileworxsNews
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();

            //hide warning masseges
            passMatchWarning.Hide();
            nullFieldsWarnning.Hide();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            // Fields Validations

            if (String.IsNullOrEmpty(nameField.Text) || String.IsNullOrEmpty(loginNameField.Text)
                || String.IsNullOrEmpty(passwordField.Text) || String.IsNullOrEmpty(confirmPassField.Text))

            {
                passMatchWarning.Hide();
                nullFieldsWarnning.Show();
                return;
            }
            else if (!String.IsNullOrEmpty(passwordField.Text) &&
                     !String.IsNullOrEmpty(confirmPassField.Text) &&
                     !passwordField.Text.Equals(confirmPassField.Text))
            {

                nullFieldsWarnning.Hide();
                passMatchWarning.Show();

                return;

            }
            else
            {

                //Creation of new user
                User n = new User();


                n.Name = nameField.Text;
                n.LogInName = loginNameField.Text;
                n.Password = passwordField.Text;

                FileHandler.JsonSerialization(n);

                MessageBox.Show("Your Account Has Been Created Successfully");

                LogInForm loginForm = new LogInForm(); // return to login

                loginForm.Show();
                this.Hide();

            }
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            //return to login
            this.Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();
        }

       
    }
}







