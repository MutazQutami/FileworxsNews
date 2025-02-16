using System.DirectoryServices.ActiveDirectory;

namespace FileworxsNews
{
    public partial class NewsForm : Form
    {

        public  New _formNew;



        private void saveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(titleField.Text) || string.IsNullOrEmpty(descriptionField.Text) // nullField Validations
                || string.IsNullOrEmpty(categoryList.Text) || string.IsNullOrEmpty(bodyField.Text))
            {


                nullFieldsWarnning.Show();
            }
            else
            {
                nullFieldsWarnning.Hide();


                if (!EditForm)
                {
                    _formNew = new New();
                }
                
                _formNew.Title = titleField.Text;
                _formNew.Description = descriptionField.Text;
                _formNew.Category = categoryList.Text;
                _formNew.Body = bodyField.Text;

              
                try
                {
                    FileHandler.JsonSerialization(_formNew);
                }
                catch (Exception _ex)
                {

                    MessageBox.Show($"An unexpected error occurred: {_ex.Message}");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            

        }


        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        public static Guid GuidValue;

        public static DateTime Date;

        public static bool EditForm = false;

        public NewsForm()
        {
            InitializeComponent();
            nullFieldsWarnning.Hide();
            EditForm = false;

        }
        public NewsForm(New _new)
        {
            

            InitializeComponent();
            this.titleField.Text = _new.Title;
            this.descriptionField.Text = _new.Description;
            this.categoryList.Text = _new.Category;
            this.bodyField.Text = _new.Body;

            _formNew = _new;
            GuidValue = _new.GuidValue;
            Date = _new.Date;
            EditForm = true;

            nullFieldsWarnning.Hide();
        }



      
    }
}
