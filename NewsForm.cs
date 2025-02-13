namespace FileworxsNews
{
    public partial class NewsForm : Form
    {


        public static Guid GuidValue;

        public static DateTime Date;

        public static bool editForm = false;
        public NewsForm()
        {
            InitializeComponent();
            nullFieldsWarnning.Hide();

        }
        public NewsForm(News n)
        {

            InitializeComponent();
            this.titleField.Text = n.Title;
            this.descriptionField.Text = n.Description;
            this.categoryList.Text = n.Category;
            this.bodyField.Text = n.Body;

            GuidValue = n.GuidValue;
            Date = n.Date;
            editForm = true;

            nullFieldsWarnning.Hide();
        }



        private void saveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(titleField.Text) || string.IsNullOrEmpty(descriptionField.Text)
                || string.IsNullOrEmpty(categoryList.Text) || string.IsNullOrEmpty(bodyField.Text))
            {


                nullFieldsWarnning.Show();
            }
            else
            {
                nullFieldsWarnning.Hide();

                News n = new News();
                n.Title = titleField.Text;
                n.Description = descriptionField.Text;
                n.Category = categoryList.Text;
                n.Body = bodyField.Text;

                if (editForm)
                {
                    n.GuidValue = GuidValue;
                    n.Date = Date;
                }



                try
                {
                    FileHandler.JsonSerialization(n);
                }
                catch (Exception)
                {

                    return;
                }

                this.Close();
            }

        }


        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
