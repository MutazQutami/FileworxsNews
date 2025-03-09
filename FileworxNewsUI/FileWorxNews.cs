using System.Windows.Forms.VisualStyles;
using FileworxNews.Busniess.Models;
using FileworxNews.Busniess.Queries;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace FileworxsNewsUI;
public partial class FileWorx : Form
{

    // Content List Panel
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
        InitializeUsersList();
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

    //Preview Panel
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

    //Filters Panel
    private void OnApplyButtonClick(object sender, EventArgs e)
    {
        ContentQuery contentQuery = CheckFilters();
        ApplyFilter(contentQuery);
    }

    private void OnClearFiltersButtonClick(object sender, EventArgs e)
    {
        ClearFilters();
        ClearPreviewContent();
        InitializeContentList();
    }
   
    private void ApplyFilter(ContentQuery contentQuery)
    {
        var listItems = contentQuery.Run();

        listItems = listItems.OrderByDescending(item => item.CreationDate).ToList();
        UpdateContentList(listItems);
    }

    public ContentQuery CheckFilters()
    {
        var contentQuery = new ContentQuery();

        CheckDateFilters(contentQuery);

        CheckStringFilters(contentQuery);

        CheckUsersFiters(contentQuery);

        return contentQuery;
    }

    private void ClearFilters()
    {
        comBoxDate.SelectedItem = null;
        comBoxLastModDate.SelectedItem = null;
        comboxLastMod.SelectedItem = null;
        comboxCreator.SelectedItem = null;
        comBoxTitle.SelectedItem = null;
        comBoxDescription.SelectedItem = null;

        lblLMDate.Hide();
        lblToLMDate.Hide();
        datePickerLMFromDate.Hide();
        datePickerLMToDate.Hide();

        lblCToDateText.Hide();
        lblCDateText.Hide();
        datePickerCFromDate.Hide();
        datePickerCToDate.Hide();

        txtTitle.Clear();
        txtDescription.Clear();
    }

    private void CheckDateFilters( ContentQuery contentQuery)
    {
        if (comBoxDate.SelectedItem != null)
        {
            var type = (DateFilter.DateFilterType)comBoxDate.SelectedIndex - 1;

            contentQuery.QCreationDate = new DateFilter()
            {
                FilterType = type,
                Value = datePickerCFromDate.Value.Date,
                EndDate = datePickerCToDate.Value.Date
            };

        }

        if (comBoxLastModDate.SelectedItem != null)
        {
            var type = (DateFilter.DateFilterType)comBoxLastModDate.SelectedIndex - 1;

            contentQuery.QLastModificationDate = new DateFilter()
            {
                FilterType = type,
                Value = datePickerLMFromDate.Value.Date,
                EndDate = datePickerLMToDate.Value.Date
            };
        }
    }

    private void CheckStringFilters(ContentQuery contentQuery)
    {
        if (comBoxTitle.SelectedItem != null
           && !string.IsNullOrEmpty(txtTitle.Text))
        {
            var type = (StringFilter.StringFilterType)comBoxTitle.SelectedIndex - 1;

            contentQuery.QName = new StringFilter()
            {
                FilterType = type,
                Value = txtTitle.Text,
            };

        }

        if (comBoxDescription.SelectedItem != null
           && !string.IsNullOrEmpty(txtDescription.Text))
        {
            var type = (StringFilter.StringFilterType)comBoxDescription.SelectedIndex - 1;

            contentQuery.QDescription = new StringFilter()
            {
                FilterType = type,
                Value = txtDescription.Text,
            };

        }
    }

    private void CheckUsersFiters(ContentQuery contentQuery)
    {

        if (comboxCreator.SelectedIndex != 0 && comboxCreator.SelectedItem != null)
        {
            if (Guid.TryParse(comboxCreator.SelectedValue.ToString(), out Guid creatorId))
            {
                contentQuery.QCreatorId = creatorId;
            }
        }

        if (comboxLastMod.SelectedIndex != 0 && comboxLastMod.SelectedItem != null)
        {
            if (Guid.TryParse(comboxLastMod.SelectedValue.ToString(), out Guid creatorId))
            {
                contentQuery.QLastModifierId = creatorId;
            }
        }
    }
   
    private void InitializeUsersList()
    {
        var userQuery = new AppUserQuery();
        var usresListCreator = userQuery.Run();
        var userListLastMod = userQuery.Run();

        var def = new User()
        {
            Name = "All Users"
        };

        usresListCreator.Insert(0, def);
        userListLastMod.Insert(0, def);

        comboxCreator.DataSource = usresListCreator;
        comboxCreator.DisplayMember = "Name";
        comboxCreator.ValueMember = "Id";
        comboxCreator.SelectedItem = null;

        comboxLastMod.DataSource = userListLastMod;
        comboxLastMod.DisplayMember = "Name";
        comboxLastMod.ValueMember = "Id";
        comboxLastMod.SelectedItem = null;
    }

    private void ComBoxDateSelect(object sender, EventArgs e)
    {
        if (comBoxDate.SelectedItem != null)
        {
            if (comBoxDate.SelectedItem.ToString() == "Today" || comBoxDate.SelectedIndex == 0)
            {
                lblCDateText.Hide();
                datePickerCFromDate.Hide();
                lblCToDateText.Visible = false;
                datePickerCToDate.Visible = false;
                return;
            }

            lblCDateText.Show();
            datePickerCFromDate.Show();

            if (comBoxDate.SelectedItem.ToString() == "Date Range")
            {
                lblCDateText.Text = "From";
                lblCToDateText.Visible = true;
                datePickerCToDate.Visible = true;
            }
            else
            {
                lblCDateText.Text = "Date";
                lblCToDateText.Visible = false;
                datePickerCToDate.Visible = false;
            }

        }

        if (comBoxLastModDate.SelectedItem != null)
        {
            if (comBoxLastModDate.SelectedItem.ToString() == "Today" || comBoxLastModDate.SelectedIndex == 0)
            {
                lblToLMDate.Hide();
                datePickerLMToDate.Visible = false;
                lblLMDate.Hide();
                datePickerLMFromDate.Hide();
                return;
            }

            lblLMDate.Show();
            datePickerLMFromDate.Show();

            if (comBoxLastModDate.SelectedItem.ToString() == "Date Range")
            {
                lblLMDate.Text = "From";
                lblToLMDate.Visible = true;
                datePickerLMToDate.Visible = true;
            }
            else
            {
                lblLMDate.Text = "Date";
                lblToLMDate.Visible = false;
                datePickerLMToDate.Visible = false;
            }
        }
    }

    private void UpdateContentList( List <Content> listItems)
    {
        contentList.Items.Clear();

        if (pnltabPreview.TabPages.Contains(imageTabPage2))
        {
            pnltabPreview.TabPages.Remove(imageTabPage2);
        }

        foreach (var _item in listItems)
        {
            ListHandler.AddListItem(contentList, _item);
        }
    }
}


