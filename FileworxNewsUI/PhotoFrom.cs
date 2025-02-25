using FileworxNewsBusiness;
namespace FileworxsNewsUI;
public partial class PhotoForm :Form
{
    public virtual void OnCancelButtonClick(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
    private void OnBrowsePhotoClick(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Title = "Select an Image",
            Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
            Multiselect = false
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string _sourcePath = openFileDialog.FileName;

            lblFilePath.Text = _sourcePath;
            pictureView.ImageLocation = _sourcePath;
            lblFilePathText.Show();
        }
    }
    private void OnSaveButtonClick(object sender, EventArgs e)
    {
        if (!ValidateFields())
        {
            return; // Stop execution if validation fails
        }

        try
        {
            formObjectItem = RetrieveFormData();
            if (isEditForm)
            {
                BaseOperations<Photo>.Update(formObjectItem);
            }
            else
            {
                BaseOperations<Photo>.Add(formObjectItem);

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
    private bool isEditForm;
    private Photo formObjectItem;
    private Guid CurrentUser;
    public PhotoForm(Guid guidValue) : this(null, guidValue)
    {
    }
    public PhotoForm(Photo _photoItem, Guid guidValue)
    {
        InitializeComponent();
        InitializeForm(_photoItem);
        CurrentUser = guidValue;
    }
    public void InitializeForm(Photo item)
    {
        if (item == null)
        {
            formObjectItem = new Photo();
            isEditForm = false;
            lblFilePathText.Hide();
            return;
        }
        formObjectItem = item;
        isEditForm = true;
        InitializeSpecificFormFields(item);
    }
    private  void InitializeSpecificFormFields(Photo _photoItem)
    {
        txtTitleField.Text = _photoItem.Title;
        txtDescriptionField.Text = _photoItem.Description;
        txtBodyField.Text = _photoItem.Body;
        pictureView.ImageLocation = _photoItem.PhotoPath;
        lblFilePath.Text = _photoItem.PhotoPath;
        lblFilePathText.Show();
        lblFilePath.Show();
    }
    public Photo RetrieveFormData()
    {
        return new Photo
        {
            Title = txtTitleField.Text,
            Description = txtDescriptionField.Text,
            Body = txtBodyField.Text,
            PhotoPath = lblFilePath.Text,
            PhotoName = Path.GetFileName(lblFilePath.Text),
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

        if (string.IsNullOrWhiteSpace(txtBodyField.Text))
        {
            lblNullBody.Visible = true;
            isValid = false;
        }
        else
        {
            lblNullBody.Visible = false;
        }

        if (string.IsNullOrWhiteSpace(lblFilePath.Text))
        {
            lblNullPhoto.Visible = true;
            isValid = false;
            tabsPreview.SelectedIndex = 1; // open photo review
        }
        else
        {
            lblNullPhoto.Visible = false;
        }

        return isValid;
    }
}
