using System;
using System.IO;
using System.Windows.Forms;
using FileworxNewsBusiness;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FileworxsNewsUI
{
    public partial class PhotoForm : Form
    {
        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            if (!AreFieldsValid())
            {
                checkUploadPhotoWarning.Hide();
                nullFieldsWarning.Show();
                return;
            }
            if (!string.IsNullOrEmpty(lblFilePath.Text))
            {
                Photo _photoItem = FormPhotoInfo();

                try
                {
                    PhotoServices.AddPhoto(_photoItem);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception _ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {_ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                nullFieldsWarning.Hide();
                checkUploadPhotoWarning.Show();
            }
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
                lblFilePath.Text =_sourcePath;
                pictureView.ImageLocation =_sourcePath;
                lblFilePathText.Show();
            }
        }
        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public Guid FormGuidValue;
        public PhotoForm() : this(Guid.NewGuid()) { }
        public PhotoForm(Guid _guidValue)
        {
            InitializeComponent();

            FormGuidValue = _guidValue;

            Photo _photoItem = PhotoServices.RetrievePhoto(_guidValue);

            InitializeForm(_photoItem);

            nullFieldsWarning .Hide();
            checkUploadPhotoWarning.Hide();
        }
        public Photo FormPhotoInfo()
        {
            return new Photo
            {
                Title = txtTitleField.Text,
                Description = txtDescriptionField.Text,
                Body = txtBodyField.Text,
                PhotoPath = lblFilePath.Text,
                GuidValue = FormGuidValue,
            };
        }
        private void InitializeForm(Photo _photoItem)
        {
            _photoItem = _photoItem ?? new Photo();

            txtTitleField.Text = _photoItem.Title;
            txtDescriptionField.Text = _photoItem.Description;
            txtBodyField.Text = _photoItem.Body;
            pictureView.ImageLocation = _photoItem.PhotoPath;
            lblFilePath.Text = _photoItem.PhotoPath;

            if (lblFilePath.Text != string.Empty)
            {
                lblFilePathText.Show();
            }
        }
        private bool AreFieldsValid()
        {
            return !string.IsNullOrWhiteSpace(txtTitleField.Text) &&
            !string.IsNullOrWhiteSpace(txtDescriptionField.Text) &&
            !string.IsNullOrWhiteSpace(txtBodyField.Text);
        }
    }
}
