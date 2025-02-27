﻿using FileworxNewsBusiness;
namespace FileworxsNewsUI;
public partial class FileWorx : Form
{
    private void ContentListMouseClick(object sender, MouseEventArgs e)
    {
        if (contentList.SelectedItems.Count > 0)
        {
            ListViewItem _selectedItem = contentList.FocusedItem;
            Content _selectedObject = (Content)_selectedItem.Tag;

            if (e.Button == MouseButtons.Right)
            {
                if (e.Button == MouseButtons.Right) // right click , delte
                {
                    CommonActions.HandleDeleteOperation(_selectedObject, _selectedItem, contentList);
                    ClearPreviewContent();
                }
            }
            else
            {
                ShowPreviewContent(_selectedObject); // normal click, show preview
            }
        }
    }

    private void ContentListMouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (contentList.SelectedItems.Count > 0)
        {
            ListViewItem _selectedItem = contentList.SelectedItems[0];

            Content _selectedObject = (Content)_selectedItem.Tag;

            EditContent(_selectedObject, _selectedItem);
        }
    }

    private void FileWorxLoad(object sender, EventArgs e)
    {
        mainSplitContainer.SplitterDistance = this.Height * 2 / 3;
    }

    private void OnAddPhotoButtonClick(object sender, EventArgs e)
    {
        PhotoForm photoForm = new PhotoForm(CurrentUser);

        if (photoForm.ShowDialog() == DialogResult.OK)
        {
            Photo _photoItem = photoForm.RetrieveFormData();
            ListHandler.AddListItem(contentList, _photoItem);
            return;
        }
    }

    private void OnAddNewsButtonClick(object sender, EventArgs e)
    {
        NewsForm _newsForm = new NewsForm(CurrentUser);

        if (_newsForm.ShowDialog() == DialogResult.OK)
        {
            News _newItem = _newsForm.RetrieveFormData();
            ListHandler.AddListItem(contentList, _newItem);
            return;
        }
    }
    private void OnUsersListMouseClick(object sender, EventArgs e)
    {
        var listForm = new UsersListForm(CurrentUser);
        listForm.ShowDialog();
    }

    private AppUser CurrentUser;

    public FileWorx(AppUser _user)
    {
        CurrentUser = _user;
        InitializeComponent();
        InitializeContentList();
        if (IsAdmin())
        {
            usersListToolStripMenuItem.Visible = true;
        }
    }

    private void InitializeContentList()
    {
        // retrieving photos and news
        contentList.Items.Clear();

        if (pnltabPreview.TabPages.Contains(imageTabPage2))
        {
            pnltabPreview.TabPages.Remove(imageTabPage2);
        }

        var _photoList = BaseOperations<Photo>.RetrieveAll();
        List<News> _newsList = BaseOperations<News>.RetrieveAll();

        List<Content> _mergedList = new List<Content>();
        _mergedList.AddRange(_photoList);
        _mergedList.AddRange(_newsList);

        // Sort by Date in descending order
        _mergedList = _mergedList.OrderByDescending(item => item.CreationDate).ToList();

        // Add sorted items to contentList
        foreach (var _item in _mergedList)
        {
            ListHandler.AddListItem(contentList, _item);
        }
    }

    private void EditContent(FileWorxEntity _selectedObject, ListViewItem _selectedItem)
    {
        if (_selectedObject is News _selectedNews)
        {
            NewsForm _newsForm = new NewsForm(_selectedNews, CurrentUser);

            _newsForm.Text = "Edit New";
            _newsForm.ShowDialog();

            if (_newsForm.DialogResult == DialogResult.OK)
            {
                News _newItem = _newsForm.RetrieveFormData();
                ListHandler.UpdateListItem(contentList, _selectedItem, _newItem);
            }
        }
        else if (_selectedObject is Photo _selectedPhoto)
        {
            PhotoForm _photoForm = new PhotoForm(_selectedPhoto, CurrentUser);

            _photoForm.Text = "Edit Photo";
            _photoForm.ShowDialog();

            if (_photoForm.DialogResult == DialogResult.OK)
            {
                Photo _photoItem = _photoForm.RetrieveFormData();
                ListHandler.UpdateListItem(contentList, _selectedItem, _photoItem);
            }
        }
    }

    private void ShowPreviewContent(Content _selectedObject)
    {
        //Common Fields
        txtTitleField.Text = _selectedObject.Name;
        txtCreationDateField.Text = _selectedObject.CreationDate.ToString();
        pnlPreviewContent.Text = _selectedObject.Body;

        if (_selectedObject is Photo _selectedPhoto)
        {
            ShowPreviewPhoto(_selectedPhoto);
        }
        else if (_selectedObject is News _selectedNews)
        {
            ShowPreviewNew(_selectedNews);
        }
    }

    private void ClearPreviewContent()
    {
        txtTitleField.Clear();
        txtCreationDateField.Clear();
        txtCategoryField.Hide();
        pnlPreviewContent.Clear();
        imagePreview.Image = null;
        pnltabPreview.TabPages.Remove(imageTabPage2);
    }

    private void ShowPhoto(Photo _selectedPhoto)
    {
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

    private void ShowPreviewPhoto(Photo _selectedPhoto)
    {
        txtCategoryField.Hide();
        lblCategory.Hide();

        txtCategoryField.Text = _selectedPhoto.PhotoPath;

        if (!pnltabPreview.TabPages.Contains(imageTabPage2))
        {
            pnltabPreview.TabPages.Add(imageTabPage2);
        }

        ShowPhoto(_selectedPhoto);
    }

    private void ShowPreviewNew(News _selectedNews)
    {
        lblCategory.Show();
        txtCategoryField.Show();

        txtCategoryField.Text = _selectedNews.Category;

        if (pnltabPreview.TabPages.Contains(imageTabPage2))
        {
            pnltabPreview.TabPages.Remove(imageTabPage2);
        }
    }

    private bool IsAdmin()
    {
        return CurrentUser.IsAdmin;
    }

}

    
