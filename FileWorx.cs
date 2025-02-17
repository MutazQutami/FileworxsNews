namespace FileworxsNews
{


    public partial class FileWorx : Form
    {

        private void ContentListMouseClick(object sender, MouseEventArgs e)
        {
            if (contentList.SelectedItems.Count > 0)
            {
                ListViewItem _selectedItem = contentList.SelectedItems[0];

                FileWorxEntity _selectedObject = (FileWorxEntity)_selectedItem.Tag;


                if (e.Button == MouseButtons.Right) // right click
                {
                    DeleteContent(_selectedObject);
                    return;
                }


                ShowPreviewContent(_selectedObject); // normal click , show preview







            }
        }

        private void ContentListMouseDoubleClick(object sender, MouseEventArgs e) // double click , edit object
        {


            if (contentList.SelectedItems.Count > 0)
            {
                ListViewItem _selectedItem = contentList.SelectedItems[0];

                FileWorxEntity _selectedObject = (FileWorxEntity)_selectedItem.Tag;

                EditContent(_selectedObject, _selectedItem);



            }
        }

        private void FileWorxLoad(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            mainSplitContainer.SplitterDistance = this.Height * 2 / 3;

            ContentFormat();

        }

        private void FileWorxResize(object sender, EventArgs e)
        {
            ContentFormat();
        }

        private void OnAddPhotoButtonClick(object sender, EventArgs e)
        {

            PhotoForm photoForm = new PhotoForm();

            if (photoForm.ShowDialog() == DialogResult.OK)
            {
                Photo ph1 = photoForm.formPhoto;
                ListViewItem _listItem = new ListViewItem(ph1.Title);


                _listItem.SubItems.Add(ph1.Date.ToString());
                _listItem.SubItems.Add(ph1.Description);
                _listItem.SubItems.Add(ph1.photoPath);
                _listItem.SubItems.Add(ph1.GuidValue.ToString());
                _listItem.SubItems.Add(ph1.Body);
                _listItem.Tag = ph1;
                contentList.Items.Add(_listItem);

                return;
            }


        }

        private void OnAddNewButtonClick(object sender, EventArgs e)
        {

            NewsForm new1 = new NewsForm();

            if (new1.ShowDialog() == DialogResult.OK)
            {
                New new2 = new1._formNew;
                ListViewItem _listItem = new ListViewItem(new2.Title);


                _listItem.SubItems.Add(new2.Date.ToString());
                _listItem.SubItems.Add(new2.Description);
                _listItem.SubItems.Add(new2.Category);
                _listItem.SubItems.Add(new2.GuidValue.ToString());
                _listItem.SubItems.Add(new2.Category);
                _listItem.Tag = new2;

                contentList.Items.Insert(0, _listItem);


                return;
            }

        }


        public FileWorx()
        {

            InitializeComponent();
            InitializeContentList();
            ContentFormat();

        }

        private void InitializeContentList()
        {

            // retrieving photos and news

            contentList.Items.Clear();
            if (pnltabPreview.TabPages.Contains(imageTabPage2))
            {
                pnltabPreview.TabPages.Remove(imageTabPage2);
            }

            List<Photo> _photoList = FileHandler.JsonDeserializationObjects(new Photo()).Cast<Photo>().ToList();

            List<New> _newsList = FileHandler.JsonDeserializationObjects(new New()).Cast<New>().ToList();


            List<Content> mergedList = new List<Content>();
            mergedList.AddRange(_photoList);
            mergedList.AddRange(_newsList);

            // Sort by Date in descending order
            mergedList = mergedList.OrderByDescending(item => item.Date).ToList();

            // Add sorted items to contentList
            foreach (var item in mergedList)
            {
                ListViewItem _listItem = new ListViewItem(item.Title);
                _listItem.SubItems.Add(item.Date.ToString());
                _listItem.SubItems.Add(item.Description);

                if (item is Photo photo)
                {
                    _listItem.SubItems.Add(photo.photoPath);
                    _listItem.SubItems.Add(photo.GuidValue.ToString());
                    _listItem.SubItems.Add(photo.Body);
                }
                else if (item is New news)
                {
                    _listItem.SubItems.Add(news.Category);
                    _listItem.SubItems.Add(news.GuidValue.ToString());
                    _listItem.SubItems.Add(news.Category);
                }

                _listItem.Tag = item;
                contentList.Items.Add(_listItem);
            }




        }

        private void ContentFormat()
        {



            titleLabel.Left = (this.ClientSize.Width - titleLabel.Width) / 2;  // center the title label


            if (contentList.Columns.Count == 3) // format column Titles
            {

                int _columnWidth = contentList.Width;

                contentList.Columns[0].Width = (int)(_columnWidth * 0.25);
                contentList.Columns[1].Width = (int)(_columnWidth * 0.25);
                contentList.Columns[2].Width = (int)(_columnWidth * 0.50);
            }
        }

        private void DeleteContent(FileWorxEntity _selectedObject)
        {
            if (contentList.FocusedItem != null)
            {
                // Get selected object (assuming it's stored in Tag property)
                _selectedObject = (FileWorxEntity)contentList.FocusedItem.Tag;

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the object
                    FileHandler.DeleteObject(_selectedObject);

                    // Remove it from the ListView
                    contentList.Items.Remove(contentList.FocusedItem);
                }
            }
        }

        private void ShowPreviewContent(FileWorxEntity _selectedObject)
        {
            if (_selectedObject is Photo _selectedPhoto)
            {
                txtCategoryField.Hide();


                txtTitleField.Text = _selectedPhoto.Title;
                txtCreationDateField.Text = _selectedPhoto.Date.ToString();
                txtCategoryField.Text = _selectedPhoto.photoPath;



                lblCategory.Hide();
                txtCategoryField.Hide();

                pnlPreviewContent.Text = _selectedPhoto.Body;


                if (!pnltabPreview.TabPages.Contains(imageTabPage2))
                {
                    pnltabPreview.TabPages.Add(imageTabPage2);
                }

                string _sourcePath = _selectedPhoto.photoPath;


                if (!string.IsNullOrEmpty(_selectedPhoto.photoPath))
                {



                    string _fileName = Path.GetFileName(_sourcePath);


                    if (!string.IsNullOrEmpty(_fileName))
                    {
                        imagePreview.ImageLocation = _sourcePath;
                    }
                    else
                    {
                        imagePreview.ImageLocation = null;
                    }


                }
                else
                {
                    imagePreview.Image = imagePreview.InitialImage;
                }


            }
            else if (_selectedObject is New _selectedNews)
            {
                txtTitleField.Text = _selectedNews.Title;
                txtCreationDateField.Text = _selectedNews.Date.ToString();
                txtCategoryField.Text = _selectedNews.Category;

                pnlPreviewContent.Text = _selectedNews.Body;

                lblCategory.Show();
                txtCategoryField.Show();

                txtCategoryField.Text = _selectedNews.Category;
                if (pnltabPreview.TabPages.Contains(imageTabPage2))
                {
                    pnltabPreview.TabPages.Remove(imageTabPage2);
                }





            }
        }
        private void EditContent(FileWorxEntity _selectedObject, ListViewItem _selectedItem)
        {
            if (_selectedObject is New _selectedNews)
            {

                NewsForm _newsForm = new NewsForm(_selectedNews);



                _newsForm.Text = "Edit New";
                _newsForm.ShowDialog();

                if (_newsForm.DialogResult == DialogResult.OK)       // The Save button was clicked
                {
                    New new1 = new New();

                    new1 = _newsForm._formNew;

                    _selectedItem.Text = new1.Title;  // Update the first column
                    _selectedItem.SubItems[1].Text = new1.Date.ToString();
                    _selectedItem.SubItems[2].Text = new1.Description;
                    _selectedItem.SubItems[3].Text = new1.GuidValue.ToString();
                    _selectedItem.SubItems[4].Text = new1.Body;

                    _selectedItem.Tag = new1;


                }


            }



            else if (_selectedObject is Photo _selectedPhoto)
            {
                PhotoForm _photoForm = new PhotoForm(_selectedPhoto);

                _photoForm.Text = "Edit Photo";
                _photoForm.ShowDialog();

                if (_photoForm.DialogResult == DialogResult.OK)
                {



                    Photo photo1 = _photoForm.formPhoto;

                    _selectedItem.Text = photo1.Title;  // Update the first column
                    _selectedItem.SubItems[1].Text = photo1.Date.ToString();
                    _selectedItem.SubItems[2].Text = photo1.Description;
                    _selectedItem.SubItems[3].Text = photo1.GuidValue.ToString();
                    _selectedItem.SubItems[4].Text = photo1.Body;

                    _selectedItem.Tag = photo1;
                }


            }
        }
    }
}

