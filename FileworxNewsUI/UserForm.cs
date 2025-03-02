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
            lblpassMatchWarning.Show();
            return;
        }

        lblpassMatchWarning.Hide();

        string _message = string.Empty;
        SaveFormInfo();
        try
        {
            
            formObjectItem.Update();
            if (isEditForm)
            {
                _message = "User Updated Successfully";
            }
            else
            {
                _message = "User Created Successfully";

            }
            CompletedRegistration(_message);
        }
        catch (Exception _ex)
        {
            _message = _ex.Message;

            InCompleteRegistration(_message);
            this.DialogResult = DialogResult.None;
        }
    }

    private static bool isEditForm;
    private AppUser formObjectItem;

    public UserForm() : this(null) { }
    public UserForm(AppUser _editUser)
    {
        InitializeComponent();
        InitializeForm(_editUser);
    }

    public void InitializeForm(AppUser item)
    {
        if (SharedClass.CurrentUser != null && SharedClass.CurrentUser.IsAdmin)
        {
            checkBoxIsAdmin.Visible = true;
        }

        if (item == null)
        {
            formObjectItem = new AppUser();
            isEditForm = false;
            return;
        }

        if (item.IsAdmin)
        {
            checkBoxIsAdmin.Checked = true;
        }

        formObjectItem = item;
        isEditForm = true;
        InitializeSpecificFormFields(item);
        
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
            lblPass.Visible = true;
            isValid = false;
        }
        else
        {
            lblPass.Visible = false;
        }

        return isValid;
    }

    private void SaveFormInfo()
    {
        formObjectItem.Name = txtName.Text;
        formObjectItem.LogInName = txtLoginName.Text;
        formObjectItem.Password = txtPassword.Text;
        formObjectItem.IsAdmin = checkBoxIsAdmin.Checked;
    }

    public void InitializeSpecificFormFields(AppUser _userItem)
    {
        this.Text = "Edit User";

        txtPassword.Text = _userItem.Password;
        txtLoginName.Text = _userItem.LogInName;
        txtName.Text = _userItem.Name;
        txtConfirmPass.Text = _userItem.Password;
    }

    public  AppUser RetrieveFormData()
    {
        SaveFormInfo();
        return formObjectItem;
    }

}