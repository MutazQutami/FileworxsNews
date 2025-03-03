using System.Windows.Forms;
using FileworxNewsBusiness;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static FileworxNewsBusiness.News;
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
            if (!isEditForm)
            {
                formObjectItem.CreatorId = SharedClass.CurrentUser.Id;
            }
          

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

    private bool isEditForm;

    private News formObjectItem;
   
    public NewsForm() : this(null)
    {

    }
   
    public NewsForm(News _editNews)
    {
        InitializeComponent();
        InitializeForm(_editNews);
    }

    private void InitializeForm(News item)
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

    private  void InitializeSpecificFormFields(News _newItem)
    {
        this.Text = "Edit News";

        txtTitleField.Text = _newItem.Name;
        txtDescriptionField.Text = _newItem.Description;
        categoryList.Text = _newItem.Category.ToString();
        txtBodyField.Text = _newItem.Body;
    }

    public  News RetrieveFormData()
    {
        formObjectItem.LastModificationDate = DateTime.Now;
        formObjectItem.Name = txtTitleField.Text;
        formObjectItem.Description = txtDescriptionField.Text;
        formObjectItem.Category = (CategoryTypes)categoryList.SelectedIndex;
        formObjectItem.Body = txtBodyField.Text;
        formObjectItem.LastModifierId = SharedClass.CurrentUser.Id;
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