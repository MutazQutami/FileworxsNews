namespace FileworxsNews
{
    public partial class FileWorx : Form
    {
        public FileWorx()
        {


            InitializeComponent();

            // Fill the form with content
            inisializeForm();

            // resize the form view

            this.WindowState = FormWindowState.Maximized;
            //contentList.Dock = DockStyle.Fill;
            ResizeObjects();





        }

        private void ResizeObjects()
        {
            if (contentList.Columns.Count == 3)
            {
                int columnWidth = contentList.Width;

                contentList.Columns[0].Width = (int)(columnWidth * 0.25);
                contentList.Columns[1].Width = (int)(columnWidth * 0.25);
                contentList.Columns[2].Width = contentList.Width - (contentList.Columns[0].Width + contentList.Columns[1].Width);

                tabPreviewContainer.SplitterDistance = this.Height / 3;  // the preview with third of the screen height 





            }
        }

        public void inisializeForm()
        {
            contentList.Items.Clear();
            if (tabPreview.TabPages.Contains(tabPage2))
            {
                tabPreview.TabPages.Remove(tabPage2);
            }



            List<Photo> photoList;
            List<News> newsList;
            (photoList, newsList) = FileHandler.JsonDeserialization();


            //List<content> contentList = photoList.Cast<content>().Concat(newsList.Cast<content>()).ToList();


            foreach (var item in photoList)
            {
                ListViewItem listItem = new ListViewItem(item.Title);


                listItem.SubItems.Add(item.Date.ToString());
                listItem.SubItems.Add(item.Description);
                listItem.SubItems.Add(item.photoPath);
                listItem.SubItems.Add(item.GuidValue.ToString());
                listItem.SubItems.Add(item.Body);

                listItem.Tag = item;
                contentList.Items.Add(listItem);


            }


            foreach (var item in newsList)
            {
                ListViewItem listItem = new ListViewItem(item.Title);


                listItem.SubItems.Add(item.Date.ToString());
                listItem.SubItems.Add(item.Description);
                listItem.SubItems.Add(item.Category);
                listItem.SubItems.Add(item.GuidValue.ToString());
                listItem.SubItems.Add(item.Category);
                listItem.Tag = item;
                contentList.Items.Add(listItem);


            }




        }


        private void contentList_MouseClick(object sender, MouseEventArgs e)
        {
            if (contentList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = contentList.SelectedItems[0];
                object selectedObject = selectedItem.Tag;

                if (e.Button == MouseButtons.Right)
                {

                    FileHandler.deleteObject((FileWorxEntity)selectedObject);
                    inisializeForm();
                    return;

                }


                if (selectedObject is Photo selectedPhoto)
                {
                    categoryField.Hide();
                    titleField.Text = selectedPhoto.Title;
                    creationDateField.Text = selectedPhoto.Date.ToString();
                    categoryField.Text = selectedPhoto.photoPath;



                    label3.Hide();
                    categoryField.Hide();

                    previewContent.Text = selectedPhoto.Body;
                    if (!tabPreview.TabPages.Contains(tabPage2))
                    {
                        tabPreview.TabPages.Add(tabPage2);
                    }

                    string sourcePath = selectedPhoto.photoPath;


                    if (!string.IsNullOrEmpty(selectedPhoto.photoPath))
                    {



                        string fileName = Path.GetFileName(sourcePath);


                        if (!string.IsNullOrEmpty(fileName))
                        {
                            pictureBox1.ImageLocation = sourcePath;
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
                else if (selectedObject is News selectedNews)
                {
                    titleField.Text = selectedNews.Title;
                    creationDateField.Text = selectedNews.Date.ToString();
                    categoryField.Text = selectedNews.Category;

                    previewContent.Text = selectedNews.Body;

                    label3.Show();
                    categoryField.Show();

                    categoryField.Text = selectedNews.Category;
                    if (tabPreview.TabPages.Contains(tabPage2))
                    {
                        tabPreview.TabPages.Remove(tabPage2);
                    }





                }





            }
        }


        private void contentList_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            if (contentList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = contentList.SelectedItems[0];

                object selectedObject = selectedItem.Tag;

                if (selectedObject is News selectedNews)
                {

                    NewsForm n = new NewsForm(selectedNews);



                    n.FormClosed += delegate
                    {
                        inisializeForm();
                    };

                    n.ShowDialog();
                    n.Text = "Edit New";


                }
                else if (selectedObject is Photo selectedPhoto)
                {
                    PhotoForm ph = new PhotoForm(selectedPhoto);


                    ph.FormClosed += delegate
                    {
                        inisializeForm();
                    };

                    ph.ShowDialog();
                    ph.Text = "Edit Photo";
                }


            }
        }


        private void addPhoto_Click(object sender, EventArgs e)
        {
            PhotoForm n = new PhotoForm();

            n.FormClosed += delegate
            {
                inisializeForm();
            };

            n.ShowDialog();



        }


        private void addNews_Click(object sender, EventArgs e)
        {
            NewsForm n = new NewsForm();
            n.FormClosed += delegate
            {
                inisializeForm();
            };
            n.ShowDialog();
        }

        private void contentList_Resize(object sender, EventArgs e)
        {
            ResizeObjects();
        }




    }
}
