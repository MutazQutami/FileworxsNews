using System.Windows.Forms.VisualStyles;
using FileworxNewsBusiness;
namespace FileworxsNewsUI;
public partial class FileWorx : Form
{

    private void ContentListMouseClick(object sender, MouseEventArgs e)
    {
        if (contentList.SelectedItems.Count > 0)
        {
            ListViewItem selectedItem = contentList.SelectedItems[0];
            var selectedObject = (Content)selectedItem.Tag;

            if (e.Button == MouseButtons.Right)// right click , Delete Object
            {
                if (e.Button == MouseButtons.Right)
                {
                    SharedClass.HandleDeleteOperation(selectedObject, selectedItem, contentList);
                    ClearPreviewContent();
                }
            }
            else
            {
                ShowPreviewContent(selectedObject); // normal click, show preview
            }
        }
    }

    private void ContentListMouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (contentList.SelectedItems.Count > 0)
        {
            ListViewItem selectedItem = contentList.SelectedItems[0];

            Content selectedObject = (Content)selectedItem.Tag;

            EditContent(selectedObject, selectedItem);
        }
    }

    private void FileWorxLoad(object sender, EventArgs e)
    {
        mainSplitContainer.SplitterDistance = this.Height * 2 / 3;
    }

    private void OnAddPhotoButtonClick(object sender, EventArgs e)
    {
        PhotoForm photoForm = new PhotoForm();

        if (photoForm.ShowDialog() == DialogResult.OK)
        {
            Photo _photoItem = photoForm.RetrieveFormData();
            ListHandler.AddListItem(contentList, _photoItem);
            return;
        }
    }

    private void OnAddNewsButtonClick(object sender, EventArgs e)
    {
        NewsForm _newsForm = new NewsForm();

        if (_newsForm.ShowDialog() == DialogResult.OK)
        {
            News _newItem = _newsForm.RetrieveFormData();
            ListHandler.AddListItem(contentList, _newItem);
            return;
        }
    }

    private void OnUsersListMouseClick(object sender, EventArgs e)
    {
        var listForm = new UsersListForm();
        listForm.ShowDialog();
    }

    public FileWorx()
    {

        InitializeComponent();
        InitializeContentList();
        if (SharedClass.CurrentUser.IsAdmin)
        {
            usersListToolStripMenuItem.Visible = true;
        }
    }

    private void InitializeContentList()
    {
        contentList.Items.Clear();

        if (pnltabPreview.TabPages.Contains(imageTabPage2))
        {
            pnltabPreview.TabPages.Remove(imageTabPage2);
        }

        var contentQuery = new ContentQuery();
        var listItems = contentQuery.Run();

        listItems = listItems.OrderByDescending(item => item.CreationDate).ToList();

        foreach (var _item in listItems)
        {
            ListHandler.AddListItem(contentList, _item);
        }
    }

    private void EditContent(FileWorxEntity selectedObject, ListViewItem selectedItem)
    {
        if (selectedObject is News _selectedNews)
        {
            NewsForm _newsForm = new NewsForm(_selectedNews);

            _newsForm.Text = "Edit News";
            _newsForm.ShowDialog();

            if (_newsForm.DialogResult == DialogResult.OK)
            {
                News _newItem = _newsForm.RetrieveFormData();
                ListHandler.UpdateListItem(contentList, selectedItem, _newItem);
            }
        }
        else if (selectedObject is Photo _selectedPhoto)
        {
            PhotoForm _photoForm = new PhotoForm(_selectedPhoto);

            _photoForm.Text = "Edit Photo";
            _photoForm.ShowDialog();

            if (_photoForm.DialogResult == DialogResult.OK)
            {
                Photo _photoItem = _photoForm.RetrieveFormData();
                ListHandler.UpdateListItem(contentList, selectedItem, _photoItem);
            }
        }
    }

    private void ShowPreviewContent(Content selectedObject)
    {
        //Common Fields
        txtTitleField.Text = selectedObject.Name;
        txtCreationDateField.Text = selectedObject.CreationDate.ToString();
        pnlPreviewContent.Text = selectedObject.Body;

        if (selectedObject is Photo _selectedPhoto)
        {
            ShowPreviewPhoto(_selectedPhoto);
        }
        else if (selectedObject is News _selectedNews)
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

    private void ShowPreviewNew(News _selectedNews)
    {
        lblCategory.Show();
        txtCategoryField.Show();

        txtCategoryField.Text = _selectedNews.Category.ToString();

        if (pnltabPreview.TabPages.Contains(imageTabPage2))
        {
            pnltabPreview.TabPages.Remove(imageTabPage2);
        }
    }
    private void OnAddFiltersButtonClick(object sender, EventArgs e)
    {
        var filterForm = new FilterForm();

        if (filterForm.ShowDialog() == DialogResult.OK)
        {
            var contentQuery = filterForm.CheckFilters();
            ApplyFilter(contentQuery);
        }
    }
    private void ApplyFilter(ContentQuery contentQuery)
    {
        contentList.Items.Clear();

        if (pnltabPreview.TabPages.Contains(imageTabPage2))
        {
            pnltabPreview.TabPages.Remove(imageTabPage2);
        }

        var listItems = contentQuery.Run();

        listItems = listItems.OrderByDescending(item => item.CreationDate).ToList();

        foreach (var _item in listItems)
        {
            ListHandler.AddListItem(contentList, _item);
        }
    }

    private void OnClearFiltersButtonClick(object sender, EventArgs e)
    {
        InitializeContentList();

    }

    private void OnApplyButtonClick(object sender, EventArgs e)
    {

    }
    public ContentQuery CheckFilters()
    {
        var ContentQuery = new ContentQuery();

        //if (comBoxDate.SelectedItem != null && )
        //{
        //    var type = (DateFilter.DateFilterType)comBoxDate.SelectedIndex;

        //    ContentQuery.QCreationDate = new DateFilter()
        //    {
        //        FilterType = type,
        //        Value = datePickerValue.Value.Date,
        //        EndDate = datePickerToValue.Value.Date
        //    };

        //}

        if (comBoxTitle.SelectedItem != null
            && !string.IsNullOrEmpty(txtTitle.Text))
        {
            var type = (StringFilter.StringFilterType)comBoxTitle.SelectedIndex;

            ContentQuery.QName = new StringFilter()
            {
                FilterType = type,
                Value = txtTitle.Text,
            };

        }

        if (comBoxDescription.SelectedItem != null
           && !string.IsNullOrEmpty(txtDescription.Text))
        {
            var type = (StringFilter.StringFilterType)comBoxDescription.SelectedIndex;

            ContentQuery.QDescription = new StringFilter()
            {
                FilterType = type,
                Value = txtDescription.Text,
            };

        }

        if (comboxCreator.SelectedItem != null)
        {
            if (Guid.TryParse(comboxCreator.SelectedValue.ToString(), out Guid creatorId))
            {
                ContentQuery.QCreatorId = creatorId;
            }
        }

        if (comboxLastMod.SelectedItem != null)
        {
            if (Guid.TryParse(comboxLastMod.SelectedValue.ToString(), out Guid creatorId))
            {
                ContentQuery.QLastModifierId = creatorId;
            }
        }

        return ContentQuery;
    }
}


