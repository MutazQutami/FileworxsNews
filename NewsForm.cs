using System.DirectoryServices.ActiveDirectory;

namespace FileworxsNews
{
    public partial class NewsForm : Form
    {

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTitleField.Text) || string.IsNullOrEmpty(txtDescriptionField.Text) // nullField Validations
                || string.IsNullOrEmpty(categoryList.Text) || string.IsNullOrEmpty(txtBodyField.Text))
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

                _formNew.Title = txtTitleField.Text;
                _formNew.Description = txtDescriptionField.Text;
                _formNew.Category = categoryList.Text;
                _formNew.Body = txtBodyField.Text;


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

        public  New _formNew;

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
            this.txtTitleField.Text = _new.Title;
            this.txtDescriptionField.Text = _new.Description;
            this.categoryList.Text = _new.Category;
            this.txtBodyField.Text = _new.Body;

            _formNew = _new;
            EditForm = true;

            nullFieldsWarnning.Hide();
        }



      
    }
}
