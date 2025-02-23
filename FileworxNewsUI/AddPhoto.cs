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
       if (!CommonActions.AreFieldsValid(txtTitleField, txtDescriptionField, txtBodyField))
        {
            CommonActions.Visibility(nullFieldsWarning, checkUploadPhotoWarning);
            return;
        }
        if (!string.IsNullOrEmpty(lblFilePath.Text))
        {
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
        else
        {
            CommonActions.Visibility(checkUploadPhotoWarning, nullFieldsWarning);
        }
    }
    private bool isEditForm;
    private Photo formObjectItem;
    public void InitializeForm(Photo item)
    {
        if (item == null)
        {
            formObjectItem = new Photo();
            isEditForm = false;
            return;
        }
        formObjectItem = item;
        isEditForm = true;
        InitializeSpecificFormFields(item);
    }
    public PhotoForm() : this(null) { }
    public PhotoForm(Photo _photoItem)
    {
        InitializeComponent();
        InitializeForm(_photoItem);
    }
    private  void InitializeSpecificFormFields(Photo _photoItem)
    {
        txtTitleField.Text = _photoItem.Title;
        txtDescriptionField.Text = _photoItem.Description;
        txtBodyField.Text = _photoItem.Body;
        pictureView.ImageLocation = _photoItem.PhotoPath;
        lblFilePath.Text = _photoItem.PhotoPath;
        lblFilePathText.Show();
    }
    public  Photo RetrieveFormData()
    {
        return new Photo
        {
            Title = txtTitleField.Text,
            Description = txtDescriptionField.Text,
            Body = txtBodyField.Text,
            PhotoPath = lblFilePath.Text,
            PhotoName = Path.GetFileName(lblFilePath.Text),
            //PhotoData =pictureView
            GuidValue = formObjectItem.GuidValue,
            Date = formObjectItem.Date
        };
    }
}
