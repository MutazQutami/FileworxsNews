namespace FileworxsNews
{
    public partial class NewsForm : Form
    {


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

                 New _new = new New();
                _new.Title = titleField.Text;
                _new.Description = descriptionField.Text;
                _new.Category = categoryList.Text;
                _new.Body = bodyField.Text;

                if (EditForm)
                {
                    _new.GuidValue = GuidValue;
                    _new.Date = Date;
                }



                try
                {
                    FileHandler.JsonSerialization(_new);
                }
                catch (Exception _ex)
                {

                    MessageBox.Show($"An unexpected error occurred: {_ex.Message}");
                }

                this.Close();
            }

        }


        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        public static Guid GuidValue;

        public static DateTime Date;

        public static bool EditForm = false;

        public NewsForm()
        {
            InitializeComponent();
            nullFieldsWarnning.Hide();

        }
        public NewsForm(New _new)
        {

            InitializeComponent();
            this.titleField.Text = _new.Title;
            this.descriptionField.Text = _new.Description;
            this.categoryList.Text = _new.Category;
            this.bodyField.Text = _new.Body;

            GuidValue = _new.GuidValue;
            Date = _new.Date;
            EditForm = true;

            nullFieldsWarnning.Hide();
        }



      
    }
}
