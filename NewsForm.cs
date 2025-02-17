using System.DirectoryServices.ActiveDirectory;

namespace FileworxsNews
{
    public partial class NewsForm : Form
    {
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Null field validations
            if (string.IsNullOrEmpty(txtTitleField.Text) ||
                string.IsNullOrEmpty(txtDescriptionField.Text) ||
                string.IsNullOrEmpty(categoryList.Text) ||
                string.IsNullOrEmpty(txtBodyField.Text))
            {
                nullFieldsWarnning.Show();
            }
            else
            {
                nullFieldsWarnning.Hide();

                if (!_editForm)
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

        public New _formNew;
        public static bool _editForm = false;

        public NewsForm()
        {
            InitializeComponent();
            nullFieldsWarnning.Hide();
            _editForm = false;
        }

        public NewsForm(New _new)
        {
            InitializeComponent();
            txtTitleField.Text = _new.Title;
            txtDescriptionField.Text = _new.Description;
            categoryList.Text = _new.Category;
            txtBodyField.Text = _new.Body;

            _formNew = _new;
            _editForm = true;

            nullFieldsWarnning.Hide();
        }
    }
}