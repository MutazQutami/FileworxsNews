namespace FileworxsNews
{
    public partial class UserForm : Form
    {



        private void SaveButton_Click(object sender, EventArgs e)
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
                User _user = new User();


               _user.Name = nameField.Text;
               _user.LogInName = loginNameField.Text;
               _user.Password = passwordField.Text;

                FileHandler.JsonSerialization(_user);

                MessageBox.Show("The User Added Successfully!");


                this.Close();

            }
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        public UserForm()
        {
            InitializeComponent();

            //hide warning masseges
            passMatchWarning.Hide();
            nullFieldsWarnning.Hide();
        }

       
    }
}







