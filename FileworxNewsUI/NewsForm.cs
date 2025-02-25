using System.Windows.Forms;
using FileworxNewsBusiness;
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
            if (isEditForm)
            {
                BaseOperations<New>.Update(formObjectItem);
            }
            else
            {
                BaseOperations<New>.Add(formObjectItem);

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception _ex)
        {
            MessageBox.Show($"An unexpected error occurred: {_ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.DialogResult = DialogResult.None;
        }

    }
    public NewsForm(Guid guidValue) : this(null, guidValue) { }
    public NewsForm(New _editNew, Guid guidValue)
    {
        InitializeComponent();
        InitializeForm(_editNew);
        CurrentUser = guidValue;
    }
    public void InitializeForm(New item)
    {
        if (item == null)
        {
            formObjectItem = Activator.CreateInstance<New>();
            isEditForm = false;
            return;
        }
        formObjectItem = item;
        isEditForm = true;
        InitializeSpecificFormFields(item);
    }
    private bool isEditForm;
    private New formObjectItem;
    private Guid CurrentUser;
    protected  void InitializeSpecificFormFields(New _newItem)
    {
        lblTitle.Text = "Edit New"; // Edit New Form
        this.Text = "Edit New";

        txtTitleField.Text = _newItem.Title;
        txtDescriptionField.Text = _newItem.Description;
        categoryList.Text = _newItem.Category;
        txtBodyField.Text = _newItem.Body;
    }
    public  New RetrieveFormData()
    {
        return new New
        {
            Title = txtTitleField.Text,
            Description = txtDescriptionField.Text,
            Category = categoryList.Text,
            Body = txtBodyField.Text,
            GuidValue = formObjectItem.GuidValue,
            Date = formObjectItem.Date,
            LastmodificationDate = DateTime.Now,
            LastModifierId = CurrentUser,
            CreatorId = CurrentUser
        };
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