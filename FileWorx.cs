namespace FileworxsNews
{
    public partial class FileWorx : Form
    {

        private void ContentList_MouseClick(object sender, MouseEventArgs e)
        {
            if (contentList.SelectedItems.Count > 0)
            {
                ListViewItem _selectedItem = contentList.SelectedItems[0];
                object _selectedObject = _selectedItem.Tag;

                if (e.Button == MouseButtons.Right) // right click , delete object
                {

                    FileHandler.DeleteObject((IFileWorxEntity)_selectedObject);
                    InisializeForm();
                    return;

                }


                if (_selectedObject is Photo _selectedPhoto)   // normal click , show preview
                {
                    categoryField.Hide();
                    titleField.Text = _selectedPhoto.Title;
                    creationDateField.Text = _selectedPhoto.Date.ToString();
                    categoryField.Text = _selectedPhoto.photoPath;



                    label3.Hide();
                    categoryField.Hide();

                    previewContent.Text = _selectedPhoto.Body;
                    if (!tabPreview.TabPages.Contains(tabPage2))
                    {
                        tabPreview.TabPages.Add(tabPage2);
                    }

                    string _sourcePath = _selectedPhoto.photoPath;


                    if (!string.IsNullOrEmpty(_selectedPhoto.photoPath))
                    {



                        string _fileName = Path.GetFileName(_sourcePath);


                        if (!string.IsNullOrEmpty(_fileName))
                        {
                            pictureBox1.ImageLocation = _sourcePath;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = null;
                        }


                    }
                    else
                    {
                        pictureBox1.Image = pictureBox1.InitialImage;
                    }


                }
                else if (_selectedObject is New _selectedNews)
                {
                    titleField.Text = _selectedNews.Title;
                    creationDateField.Text = _selectedNews.Date.ToString();
                    categoryField.Text = _selectedNews.Category;

                    previewContent.Text = _selectedNews.Body;

                    label3.Show();
                    categoryField.Show();

                    categoryField.Text = _selectedNews.Category;
                    if (tabPreview.TabPages.Contains(tabPage2))
                    {
                        tabPreview.TabPages.Remove(tabPage2);
                    }





                }





            }
        }


        private void ContentList_MouseDoubleClick(object sender, MouseEventArgs e) // double click , edit object
        {


            if (contentList.SelectedItems.Count > 0)
            {
                ListViewItem _selectedItem = contentList.SelectedItems[0];

                object _selectedObject = _selectedItem.Tag;

                if (_selectedObject is New _selectedNews)
                {

                    NewsForm _newsForm = new NewsForm(_selectedNews);



                    _newsForm.Text = "Edit New";
                    _newsForm.ShowDialog();

                    _newsForm.FormClosed += delegate
                    {
                        InisializeForm();
                    };



                }
                else if (_selectedObject is Photo _selectedPhoto)
                {
                    PhotoForm _photoForm = new PhotoForm(_selectedPhoto);

                    _photoForm.Text = "Edit Photo";
                    _photoForm.ShowDialog();

                    _photoForm.FormClosed += delegate
                    {
                        InisializeForm();
                    };



                }


            }
        }


        private void ContentList_Resize(object sender, EventArgs e)
        {
            ResizeObjects();
        }




        public FileWorx()
        {

            InitializeComponent();
            InisializeForm();
            ResizeObjects();

        }

        private void InisializeForm()
        {

            // retrieving photos and news

            contentList.Items.Clear();
            if (tabPreview.TabPages.Contains(tabPage2))
            {
                tabPreview.TabPages.Remove(tabPage2);
            }

            List<Photo> _photoList = FileHandler.JsonDeserializationObjects(new Photo()).Cast<Photo>().ToList();

            List<New> _newsList = FileHandler.JsonDeserializationObjects(new New()).Cast<New>().ToList();




            foreach (var item in _photoList)
            {
                ListViewItem _listItem = new ListViewItem(item.Title);


                _listItem.SubItems.Add(item.Date.ToString());
                _listItem.SubItems.Add(item.Description);
                _listItem.SubItems.Add(item.photoPath);
                _listItem.SubItems.Add(item.GuidValue.ToString());
                _listItem.SubItems.Add(item.Body);

                _listItem.Tag = item;
                contentList.Items.Add(_listItem);


            }


            foreach (var item in _newsList)
            {
                ListViewItem _listItem = new ListViewItem(item.Title);


                _listItem.SubItems.Add(item.Date.ToString());
                _listItem.SubItems.Add(item.Description);
                _listItem.SubItems.Add(item.Category);
                _listItem.SubItems.Add(item.GuidValue.ToString());
                _listItem.SubItems.Add(item.Category);
                _listItem.Tag = item;
                contentList.Items.Add(_listItem);


            }




        }

        private void ResizeObjects()
        {

            //Full view Form
            this.WindowState = FormWindowState.Maximized;
            AutoScroll = true;

         



            if (contentList.Columns.Count == 3)
            {
                int _columnWidth = contentList.Width;

                contentList.Columns[0].Width = (int)(_columnWidth * 0.25);
                contentList.Columns[1].Width = (int)(_columnWidth * 0.25);
                contentList.Columns[2].Width = contentList.Width - (contentList.Columns[0].Width + contentList.Columns[1].Width);

                tabPreviewContainer.SplitterDistance = this.Height / 3;  // the preview with third of the screen height 


                lowerPart.Width = upperPart.Width - 2;
             

                lowerPart.Height = (int)(this.Height / 1.8);



            }
        }

      
    }
}
