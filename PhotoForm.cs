using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileworxsNews
{
    public partial class PhotoForm : Form
    {

        public static Guid GuidValue;

        public static DateTime Date;

        public static bool editForm = false;

        public PhotoForm()
        {
            InitializeComponent();
            nullFieldsWarnning.Hide();
            checkUploadPhotoWarning.Hide();



        }

        public PhotoForm(Photo ph)
        {
            InitializeComponent();
            this.titleField.Text = ph.Title;
            this.descriptionField.Text = ph.Description;
            this.bodyField.Text = ph.Body;
            this.pictureBox1.ImageLocation = ph.photoPath;
            this.filePath.Text += ph.photoPath;
            this.photoPath = ph.photoPath;

            GuidValue = ph.GuidValue;
            Date = ph.Date;
            editForm = true;

            nullFieldsWarnning.Hide();
            checkUploadPhotoWarning.Hide();

        }

        public string photoPath;

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(titleField.Text) || string.IsNullOrEmpty(descriptionField.Text) || string.IsNullOrEmpty(bodyField.Text))
            {
                checkUploadPhotoWarning.Hide();
                nullFieldsWarnning.Show();
            }
            else if
             (!string.IsNullOrEmpty(photoPath))
            {



                Photo ph = new Photo();
                ph.Title = titleField.Text;
                ph.Description = descriptionField.Text;
                ph.Body = bodyField.Text;
                ph.photoPath = photoPath;


                if (editForm)
                {
                    ph.GuidValue = GuidValue;
                    ph.Date = Date;
                }



                FileHandler.JsonSerialization(ph);
                this.Close();
                return;
            }
            else
            {
                nullFieldsWarnning.Hide();

                checkUploadPhotoWarning.Show();

            }




        }

        private void browsePhoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(sourcePath);

                photoPath = sourcePath;

                pictureBox1.ImageLocation = sourcePath;
                filePath.Text += sourcePath;
                filePath.Show();


            }

        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}