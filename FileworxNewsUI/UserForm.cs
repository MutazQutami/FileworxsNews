using FileworxNewsBusiness;
namespace FileworxsNewsUI;
public partial class UserForm : Form
{
    public virtual void OnCancelButtonClick(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
    private void OnSaveButtonClick(object sender, EventArgs e)
    {
        if (!ValidateFields())
        {
            return;
        }
        if (!ArePasswordsEqual())
        {
            lblPassMatchWarning.Show();
            return;
        }

        lblPassMatchWarning.Hide();

        string _message = string.Empty;
        bool _condition;
        formObjectItem = RetrieveFormData();
        try
        {

            if (isEditForm)
            {
                (_condition, _message) = UserServices.UpdateUser(formObjectItem);
                if (_condition)
                {
                    CompletedRegistration(_message);
                }
                else
                {
                    InCompleteRegistration(_message);
                }
                return;
            }

            (_condition, _message) = UserServices.SignUp((AppUser)formObjectItem);
            if (_condition) // New user , Sign up
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
    private bool isEditForm;
    private AppUser formObjectItem;
    public UserForm() : this(null)
    {
    }
    public UserForm(AppUser _editUser)
    {
        InitializeComponent();
        InitializeForm(_editUser);
    }
    public void InitializeForm(AppUser item)
    {
        if (item == null)
        {
            formObjectItem = new AppUser();
            isEditForm = false;
            return;
        }
        formObjectItem = item;
        isEditForm = true;
        InitializeSpecificFormFields(item);
    }
    public  void InitializeSpecificFormFields(AppUser _userItem)
    {
        this.Text = "Edit User";

        txtPassword.Text = _userItem.Password;
        txtLoginName.Text = _userItem.LogInName;
        txtName.Text = _userItem.Name;
        txtConfirmPass.Text = _userItem.Password;
    }
    public  AppUser RetrieveFormData()
    {
        return new AppUser
        {
            Name = txtName.Text,
            LogInName = txtLoginName.Text,
            Password = txtPassword.Text,
            GuidValue = formObjectItem.GuidValue,
            Date = formObjectItem.Date,
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
    private bool ValidateFields()
    {
        bool isValid = true;

        if (string.IsNullOrWhiteSpace(txtConfirmPass.Text))
        {
            lblNullConfirmPassword.Visible = true;
            isValid = false;
        }
        else
        {
            lblNullConfirmPassword.Visible = false;
        }

        if (string.IsNullOrWhiteSpace(txtLoginName.Text))
        {
            lblNullLoginName.Visible = true;
            isValid = false;
        }
        else
        {
            lblNullLoginName.Visible = false;
        }

        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            lblNullName.Visible = true;
            isValid = false;
        }
        else
        {
            lblNullName.Visible = false;
        }

        if (string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            lblPassMatchWarning.Visible = true;
            isValid = false;
        }
        else
        {
            lblPassMatchWarning.Visible = false;
        }

        return isValid;
    }

}