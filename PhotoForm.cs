using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileworxsNews
{
    public partial class PhotoForm : Form
    {

        public Photo formPhoto;
        public bool editForm;

        private void OnSaveButtonClick(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTitleField.Text) || string.IsNullOrEmpty(txtDescriptionField.Text) || string.IsNullOrEmpty(txtBodyField.Text))
            {
                checkUploadPhotoWarning.Hide();
                nullFieldsWarnning.Show();
            }
            else if
             (!string.IsNullOrEmpty(lblFilePath.Text))
            {



                if (!editForm)
                {
                    formPhoto = new Photo();

                }

                formPhoto.Title = txtTitleField.Text;
                formPhoto.Description = txtDescriptionField.Text;
                formPhoto.Body = txtBodyField.Text;
                formPhoto.photoPath = lblFilePath.Text;






                FileHandler.JsonSerialization(formPhoto);

                this.DialogResult = DialogResult.OK;


                this.Close();
                return;
            }
            else
            {
                nullFieldsWarnning.Hide();

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
                string _fileName = Path.GetFileName(_sourcePath);

                lblFilePath.Text = _sourcePath;

                pictureView.ImageLocation = _sourcePath;
                lblFilePath.Text += _sourcePath;
                lblFilePath.Show();


            }

        }

        private void OnCancleButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }




        public static bool EditForm = false;

        public PhotoForm()
        {
            InitializeComponent();
            nullFieldsWarnning.Hide();
            checkUploadPhotoWarning.Hide();
            editForm = false;


        }

        public PhotoForm(Photo _photo)
        {
            InitializeComponent();
            this.txtTitleField.Text = _photo.Title;
            this.txtDescriptionField.Text = _photo.Description;
            this.txtBodyField.Text = _photo.Body;
            this.pictureView.ImageLocation = _photo.photoPath;
            this.lblFilePath.Text += _photo.photoPath;


            formPhoto = _photo;

            EditForm = true;

            nullFieldsWarnning.Hide();
            checkUploadPhotoWarning.Hide();
            editForm = true;

        }

      

       
    }
}