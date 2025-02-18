using FileworxNewsBusiness;

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
                    FileHandler.DeleteObject(_selectedObject);
                    ListHandler.RemoveListItem(contentList, _selectedItem);
                    return;
                }

                ShowPreviewContent(_selectedObject); // normal click , show preview
            }
        } // normal click 
        private void ContentListMouseDoubleClick(object sender, MouseEventArgs e) 
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
            mainSplitContainer.SplitterDistance = this.Height * 2 / 3;
        }
        private void OnAddPhotoButtonClick(object sender, EventArgs e){
            PhotoForm photoForm = new PhotoForm();

            if (photoForm.ShowDialog() == DialogResult.OK)
            {
                Photo _photoItem = photoForm.FormPhotoInfo();
                ListHandler.AddLisItem(contentList, _photoItem);
                return;
            }

        }
        private void OnAddNewButtonClick(object sender, EventArgs e)
        {
            NewsForm _newsForm = new NewsForm();

            if (_newsForm.ShowDialog() == DialogResult.OK)
            {
                New _newItem = _newsForm.FormNewInfo();
                //ListHandler.AddLisItem(contentList, _newItem);
                ListHandler.AddLisItem(contentList, _newItem);
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
            foreach (var _item in _mergedList)
            {
                ListHandler.AddLisItem(contentList, _item);

            }
        }
        private void ShowPreviewContent(FileWorxEntity _selectedObject)
        {
            if (_selectedObject is Photo _selectedPhoto)
            {
                txtCategoryField.Hide();

                txtTitleField.Text = _selectedPhoto.Title;
                txtCreationDateField.Text = _selectedPhoto.Date.ToString();
                txtCategoryField.Text = _selectedPhoto.PhotoPath;

                lblCategory.Hide();
                txtCategoryField.Hide();

                pnlPreviewContent.Text = _selectedPhoto.Body;

                if (!pnltabPreview.TabPages.Contains(imageTabPage2))
                {
                    pnltabPreview.TabPages.Add(imageTabPage2);
                }

                string _sourcePath = _selectedPhoto.PhotoPath;

                if (!string.IsNullOrEmpty(_selectedPhoto.PhotoPath))
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

                if (_newsForm.DialogResult == DialogResult.OK)       
                {
                    New _newItem = _newsForm.FormNewInfo();
                    ListHandler.UpdateListItem(contentList , _selectedItem ,_newItem);
                }
            }
            else if (_selectedObject is Photo _selectedPhoto)
            {
                PhotoForm _photoForm = new PhotoForm(_selectedPhoto);

                _photoForm.Text = "Edit Photo";
                _photoForm.ShowDialog();

                if (_photoForm.DialogResult == DialogResult.OK)
                {
                    Photo _photoItem = _photoForm.FormPhotoInfo();
                    ListHandler.UpdateListItem(contentList, _selectedItem, _photoItem);
                }
            }
        }
    }
}

