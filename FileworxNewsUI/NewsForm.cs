using System.Windows.Forms;
using FileworxNewsBusiness;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
namespace FileworxsNewsUI;
public partial class NewsForm :Form
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

        try
        {
            formObjectItem = RetrieveFormData();
            formObjectItem.Update();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception _ex)
        {
            MessageBox.Show($"An unexpected error occurred: {_ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.DialogResult = DialogResult.None;
        }

    }
    public NewsForm(AppUser _user) : this(null, _user) { }
    public NewsForm(News _editNew, AppUser _user)
    {
        InitializeComponent();
        InitializeForm(_editNew);
        CurrentUser = _user;
    }
    public void InitializeForm(News item)
    {
        if (item == null)
        {
            formObjectItem =new News();
            isEditForm = false;
            return;
        }
        formObjectItem = item;
        isEditForm = true;
        InitializeSpecificFormFields(item);
    }
    private bool isEditForm;
    private News formObjectItem;
    private AppUser CurrentUser;
    protected  void InitializeSpecificFormFields(News _newItem)
    {
        lblTitle.Text = "Edit New"; // Edit New Form
        this.Text = "Edit New";

        txtTitleField.Text = _newItem.Name;
        txtDescriptionField.Text = _newItem.Description;
        categoryList.Text = _newItem.Category;
        txtBodyField.Text = _newItem.Body;
    }
    public  News RetrieveFormData()
    {
        formObjectItem.LastModificationDate = DateTime.Now;
        formObjectItem.LastModifierId = CurrentUser.Id;
        formObjectItem.Name = txtTitleField.Text;
        formObjectItem.Description = txtDescriptionField.Text;
        formObjectItem.Category = categoryList.Text;
        formObjectItem.Body = txtBodyField.Text;
        formObjectItem.CreatorId= CurrentUser.Id;
        return formObjectItem;
     
    }
    private bool ValidateFields()
    {
        bool isValid = true;

        if (string.IsNullOrWhiteSpace(txtTitleField.Text))
        {
            lblNullTitle.Visible = true;
            isValid = false;
        }
        else
        {
            lblNullTitle.Visible = false;
        }

        if (string.IsNullOrWhiteSpace(txtDescriptionField.Text))
        {
            lblNullDescription.Visible = true;
            isValid = false;
        }
        else
        {
            lblNullDescription.Visible = false;
        }

        if (categoryList.SelectedItem == null)
        {
            lblNullCategory.Visible = true;
            isValid = false;
        }
        else
        {
            lblNullCategory.Visible = false;
        }

        if (string.IsNullOrWhiteSpace(txtBodyField.Text))
        {
            lblNullBody.Visible = true;
            isValid = false;
        }
        else
        {
            lblNullBody.Visible = false;
        }

        return isValid;
    }
}