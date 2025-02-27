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
            lblNullPhoto.Hide();
            lblFilePath.Text = _sourcePath;
            pictureView.ImageLocation = _sourcePath;
            lblFilePathText.Show();
        }
    }

    private void OnSaveButtonClick(object sender, EventArgs e)
    {
        if (!ValidateFields())
        {
            return; 
        }

        try
        {
            if (!isEditForm)
            {
                formObjectItem.CreatorId = CurrentUser.Id;
            }
            SaveFormInfo();
            formObjectItem.Update();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception _ex)
        {
            MessageBox.Show(_ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.DialogResult = DialogResult.None;
        }
    }

    private bool isEditForm;

    private Photo formObjectItem;

    private AppUser CurrentUser;

    public PhotoForm(AppUser _user) : this(null, _user)
    {
    }

    public PhotoForm(Photo _photoItem, AppUser _user)
    {
        InitializeComponent();
        InitializeForm(_photoItem);
        CurrentUser = _user;
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
        txtTitleField.Text = _photoItem.Name;
        txtDescriptionField.Text = _photoItem.Description;
        txtBodyField.Text = _photoItem.Body;
        pictureView.ImageLocation = _photoItem.PhotoPath;
        lblFilePath.Text = _photoItem.PhotoPath;
        lblFilePathText.Show();
        lblFilePath.Show();
    }

    public Photo RetrieveFormData()
    {
        SaveFormInfo();
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

    private void SaveFormInfo()
    {
        formObjectItem.Name = txtTitleField.Text;
        formObjectItem.Description = txtDescriptionField.Text;
        formObjectItem.Body = txtBodyField.Text;
        formObjectItem.PhotoPath = lblFilePath.Text;
        formObjectItem.LastModificationDate = DateTime.Now;
        formObjectItem.LastModifierId = CurrentUser.Id;
    }
}
