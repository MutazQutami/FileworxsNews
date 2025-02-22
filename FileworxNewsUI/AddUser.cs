using FileworxNewsBusiness;
namespace FileworxsNewsUI;
public partial class UserForm : BaseFormOperations<AppUser>
{
    private void OnSaveButtonClick(object sender, EventArgs e)
    {
        if (!CommonActions.AreFieldsValid
             ([txtName, txtLoginName, txtPassword, txtConfirmPass])
           )
        {
            CommonActions.Visibility(lblNullwarning, passMatchWarning);
            return;
        }
        if (!ArePasswordsEqual())
        {
            CommonActions.Visibility(passMatchWarning, lblNullwarning);
            return;
        }

        string _message = string.Empty;

        try
        {
            formObjectItem = RetrieveFormData();
            if (isEditForm)
            {
                if (UserServices.UpdateUser(formObjectItem, out _message))
                {
                    CompletedRegistration(_message);
                }
                else
                {
                    InCompleteRegistration(_message);
                }
            }
            else if (UserServices.SignUp((AppUser)formObjectItem, out _message)) // New user , Sign up
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
    public UserForm() : this(null)
    {
    }
    public UserForm(AppUser _editUser)
    {
        InitializeComponent();
        InitializeForm(_editUser);
    }
    protected override void InitializeSpecificFormFields(AppUser _userItem)
    {
        lblTitle.Text = "Edit User"; // Edit User Form
        this.Text = "Edit User";

        txtPassword.Text = _userItem.Password;
        txtLoginName.Text = _userItem.LogInName;
        txtName.Text = _userItem.Name;
        txtConfirmPass.Text = _userItem.Password;
    }
    public override AppUser RetrieveFormData()
    {
        return new AppUser
        {
            Name = txtName.Text,
            LogInName = txtLoginName.Text,
            Password = txtPassword.Text,
            GuidValue = formObjectItem.GuidValue,
            Date = formObjectItem.Date
        };
    }
    private bool ArePasswordsEqual()
    {
        return txtPassword.Text.Equals(txtConfirmPass.Text);
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