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

                    FileHandler.DeleteObject((FileWorxEntity)_selectedObject);
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

                    pnlPreviewContent.Text = _selectedPhoto.Body;
                    if (!pnltabPreview.TabPages.Contains(tabPage2))
                    {
                        pnltabPreview.TabPages.Add(tabPage2);
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

                    pnlPreviewContent.Text = _selectedNews.Body;

                    label3.Show();
                    categoryField.Show();

                    categoryField.Text = _selectedNews.Category;
                    if (pnltabPreview.TabPages.Contains(tabPage2))
                    {
                        pnltabPreview.TabPages.Remove(tabPage2);
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
            if (pnltabPreview.TabPages.Contains(tabPage2))
            {
                pnltabPreview.TabPages.Remove(tabPage2);
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


            if (contentList.Columns.Count == 3)
            {

                int _columnWidth = contentList.Width;

                contentList.Columns[0].Width = (int)(_columnWidth * 0.25);
                contentList.Columns[1].Width = (int)(_columnWidth * 0.25);
                contentList.Columns[2].Width = (int)(_columnWidth * 0.50);
            }
        }

        private void FileWorx_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //contentList.Height = (int)(this.Height * 2/3);
            mainSplitContainer.SplitterDistance = this.Height * 2 / 3;
            ResizeObjects();
        }

        private void FileWorx_Resize(object sender, EventArgs e)
        {
            ResizeObjects();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnAddNew_Click(object sender, EventArgs e)
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
    }
}

