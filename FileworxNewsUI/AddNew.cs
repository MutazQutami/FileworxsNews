using System.Windows.Forms;
using FileworxNewsBusiness;
namespace FileworxsNewsUI;
public partial class NewsForm : BaseFormOperations<New>
{
    private void OnSaveButtonClick(object sender, EventArgs e)
    {
        // Null Fields Input Validations
        if (!(CommonActions.AreFieldsValid(txtTitleField, txtDescriptionField, categoryList, txtBodyField)))
        {
            CommonActions.Visibility(nullFieldsWarning, new Label());
            return;
        }

        CommonActions.Visibility(new Label(), nullFieldsWarning);
        
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
    public NewsForm() : this(null) { }
    public NewsForm(New _editNew)
    {
        InitializeComponent();
        InitializeForm(_editNew);
    }
    protected override void InitializeSpecificFormFields(New _newItem)
    {
        lblTitle.Text = "Edit New"; // Edit New Form
        this.Text = "Edit New";

        txtTitleField.Text = _newItem.Title;
        txtDescriptionField.Text = _newItem.Description;
        categoryList.Text = _newItem.Category;
        txtBodyField.Text = _newItem.Body;
    }
    public override New RetrieveFormData()
    {
        return new New
        {
            Title = txtTitleField.Text,
            Description = txtDescriptionField.Text,
            Category = categoryList.Text,
            Body = txtBodyField.Text,
            GuidValue = formObjectItem.GuidValue,
            Date = formObjectItem.Date
        };
    }
}