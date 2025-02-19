using FileworxNewsBusiness;

namespace FileworxsNewsUI
{
    public partial class NewsForm : Form
    {
        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            // Null Fields Input Validations

            if (!AreFieldsValid())
            {
                nullFieldsWarning.Show();
                return;
            }
           
            nullFieldsWarning.Hide();

            New _newItem = FormNewInfo();

            try
            {
                NewServices.AddNew(_newItem);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception _ex)
            {
                MessageBox.Show($"An unexpected error occurred: {_ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            } 
        }
        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public Guid FormGuidValue;
        public NewsForm() : this(Guid.NewGuid()) { }
        public NewsForm(Guid _guidValue)
        {
            InitializeComponent();
            nullFieldsWarning.Hide();

            FormGuidValue = _guidValue;
            New _newItem = NewServices.RetrieveNew(_guidValue);
            InitializeForm(_newItem);
        }
        private void InitializeForm(New _newItem)
        {
            _newItem = _newItem ?? new New();

            txtTitleField.Text = _newItem.Title;
            txtDescriptionField.Text = _newItem.Description;
            categoryList.Text = _newItem.Category;
            txtBodyField.Text = _newItem.Body;
            
            nullFieldsWarning.Hide();
        }
        public New FormNewInfo()
        {
           return new New
            {
                Title = txtTitleField.Text,
                Description = txtDescriptionField.Text,
                Category = categoryList.Text,
                Body = txtBodyField.Text,
                GuidValue = FormGuidValue,
           };
        }
        private bool AreFieldsValid()
        {
           return !string.IsNullOrWhiteSpace(txtTitleField.Text) &&
           !string.IsNullOrWhiteSpace(txtDescriptionField.Text) &&
           !string.IsNullOrWhiteSpace(categoryList.Text) &&
           !string.IsNullOrWhiteSpace(txtBodyField.Text);
        }
    }
}