using FileworxBusiness;

namespace FileworxsNewsUI
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
            //this.WindowState = FormWindowState.Maximized;

            mainSplitContainer.SplitterDistance = this.Height * 2 / 3;

            
        }

       

        private void OnAddPhotoButtonClick(object sender, EventArgs e){
            PhotoForm photoForm = new PhotoForm();

            if (photoForm.ShowDialog() == DialogResult.OK)
            {
                Photo _photo = photoForm.formPhoto;
                ListViewItem _listItem = new ListViewItem(_photo.Title);

                _listItem.SubItems.Add(_photo.Date.ToString());
                _listItem.SubItems.Add(_photo.Description);
                _listItem.SubItems.Add(_photo.photoPath);
                _listItem.SubItems.Add(_photo.GuidValue.ToString());
                _listItem.SubItems.Add(_photo.Body);
                _listItem.Tag = _photo;
                contentList.Items.Add(_listItem);

                return;
            }

        }

        private void OnAddNewButtonClick(object sender, EventArgs e)
        {
            NewsForm _newsForm = new NewsForm();

            if (_newsForm.ShowDialog() == DialogResult.OK)
            {
                New _new = _newsForm._formNew;
                ListViewItem _listItem = new ListViewItem(_new.Title);


                _listItem.SubItems.Add(_new.Date.ToString());
                _listItem.SubItems.Add(_new.Description);
                _listItem.SubItems.Add(_new.Category);
                _listItem.SubItems.Add(_new.GuidValue.ToString());
                _listItem.SubItems.Add(_new.Category);
                _listItem.Tag = _new;

                contentList.Items.Insert(0, _listItem);

                 return;
            }

        }
        public FileWorx()
        {
            InitializeComponent();
            InitializeContentList();
      
        }

        private void InitializeContentList()
        {
            // retrieving photos and news
            contentList.Items.Clear();
            if (pnltabPreview.TabPages.Contains(imageTabPage2))
            {
                pnltabPreview.TabPages.Remove(imageTabPage2);
            }

            List<Photo> _photoList = FileHandler.JsonDeserializationObjects(new Photo())
            .Cast<Photo>().ToList();
            List<New> _newsList = FileHandler.JsonDeserializationObjects(new New())
            .Cast<New>().ToList();

            //Merge the two lists together
            List<Content> _mergedList = new List<Content>();
            _mergedList.AddRange(_photoList);
            _mergedList.AddRange(_newsList);

            // Sort by Date in descending order
            _mergedList = _mergedList.OrderByDescending(item => item.Date).ToList();

            // Add sorted items to contentList
            foreach (var item in _mergedList)
            {
                ListViewItem _listItem = new ListViewItem(item.Title);
                _listItem.SubItems.Add(item.Date.ToString());
                _listItem.SubItems.Add(item.Description);

                if (item is Photo _photo)
                {
                    _listItem.SubItems.Add(_photo.photoPath);
                    _listItem.SubItems.Add(_photo.GuidValue.ToString());
                    _listItem.SubItems.Add(_photo.Body);
                }
                else if (item is New _newItem)
                {
                    _listItem.SubItems.Add(_newItem.Category);
                    _listItem.SubItems.Add(_newItem.GuidValue.ToString());
                    _listItem.SubItems.Add(_newItem.Category);
                }

                _listItem.Tag = item;
                contentList.Items.Add(_listItem);
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
                    New _new = new New();

                    _new = _newsForm._formNew;

                    _selectedItem.Text = _new.Title;  // Update the first column
                    _selectedItem.SubItems[1].Text = _new.Date.ToString();
                    _selectedItem.SubItems[2].Text = _new.Description;
                    _selectedItem.SubItems[3].Text = _new.GuidValue.ToString();
                    _selectedItem.SubItems[4].Text = _new.Body;

                    _selectedItem.Tag = _new;

                }


            }
            else if (_selectedObject is Photo _selectedPhoto)
            {
                PhotoForm _photoForm = new PhotoForm(_selectedPhoto);

                _photoForm.Text = "Edit Photo";
                _photoForm.ShowDialog();

                if (_photoForm.DialogResult == DialogResult.OK)
                {
                    Photo _photo = _photoForm.formPhoto;

                    _selectedItem.Text = _photo.Title;  // Update the first column
                    _selectedItem.SubItems[1].Text = _photo.Date.ToString();
                    _selectedItem.SubItems[2].Text = _photo.Description;
                    _selectedItem.SubItems[3].Text = _photo.GuidValue.ToString();
                    _selectedItem.SubItems[4].Text = _photo.Body;

                    _selectedItem.Tag = _photo;
                }


            }
        }
    }
}

