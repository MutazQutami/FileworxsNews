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

            if (String.IsNullOrEmpty(txtName.Text) ||
                String.IsNullOrEmpty(txtLoginName.Text) ||
                String.IsNullOrEmpty(txtPassword.Text))
            {

                lblNullWarnning.Show();
                return;
            }

            else
            {
                lblNullWarnning.Hide();

                if (!IsEditform)
                {

                    formUser = new User();

                }





                formUser.Name = txtName.Text;
                formUser.LogInName = txtLoginName.Text;
                formUser.Password = txtPassword.Text;


                FileHandler.JsonSerialization(formUser);

                if (!IsEditform)
                {

                    MessageBox.Show("The User Added Successfully!");

                }

                this.DialogResult = DialogResult.OK;

                this.Close();
                return;

            }
        }


        public User formUser;
        private bool IsEditform;
      

        public UserForm(User user)
        {
            InitializeComponent();
            this.txtPassword.Text=user.Password; 
            this.txtLoginName.Text = user.LogInName;
            this.txtName.Text = user.Name;
            IsEditform = true;
            lblNullWarnning.Hide();
            formUser = user;


        }
        public UserForm() {
            InitializeComponent();

            // Hide password match warning and null value warning

            lblNullWarnning.Hide();
                IsEditform = false;

         }

    }
}
