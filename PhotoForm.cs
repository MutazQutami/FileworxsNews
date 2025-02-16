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

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(titleField.Text) || string.IsNullOrEmpty(descriptionField.Text) || string.IsNullOrEmpty(bodyField.Text))
            {
                checkUploadPhotoWarning.Hide();
                nullFieldsWarnning.Show();
            }
            else if
             (!string.IsNullOrEmpty(photoPath))
            {



                if (!editForm)
                {
                    formPhoto = new Photo();

                }

                formPhoto.Title = titleField.Text;
                formPhoto.Description = descriptionField.Text;
                formPhoto.Body = bodyField.Text;
                formPhoto.photoPath = photoPath;






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

        private void BrowsePhoto_Click(object sender, EventArgs e)
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

                photoPath = _sourcePath;

                pictureBox1.ImageLocation = _sourcePath;
                filePath.Text += _sourcePath;
                filePath.Show();


            }

        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        public static Guid GuidValue;

        public static DateTime Date;

        public static bool EditForm = false;

        public string photoPath;

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
            this.titleField.Text = _photo.Title;
            this.descriptionField.Text = _photo.Description;
            this.bodyField.Text = _photo.Body;
            this.pictureBox1.ImageLocation = _photo.photoPath;
            this.filePath.Text += _photo.photoPath;
            this.photoPath = _photo.photoPath;

            formPhoto = _photo;


            GuidValue = _photo.GuidValue;
            Date = _photo.Date;
            EditForm = true;

            nullFieldsWarnning.Hide();
            checkUploadPhotoWarning.Hide();
            editForm = true;

        }

        private void cancleButton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}