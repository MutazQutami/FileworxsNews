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
        private FileWorxEntity _relatedFormEntity;
        public NewsForm() : this(null) { }
        public NewsForm(New _newItem)
        {
            InitializeComponent();

            nullFieldsWarning.Hide();

            _newItem = _newItem ?? new New();
            InitializeForm(_newItem);
        }
        private void InitializeForm(New _newItem)
        {
            MessageBox.Show(_newItem.GuidValue.ToString());
            txtTitleField.Text = _newItem.Title;
            txtDescriptionField.Text = _newItem.Description;
            categoryList.Text = _newItem.Category;
            txtBodyField.Text = _newItem.Body;
            _relatedFormEntity = new FileWorxEntity
            {
                Date = _newItem.Date,
                GuidValue = _newItem.GuidValue
            };
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
                GuidValue = _relatedFormEntity is null ? Guid.NewGuid() : _relatedFormEntity.GuidValue,
                Date = _relatedFormEntity is null ? DateTime.Now : _relatedFormEntity.Date
           };
        }
        private bool AreFieldsValid()
        {
           return !string.IsNullOrEmpty(txtTitleField.Text) &&
           !string.IsNullOrEmpty(txtDescriptionField.Text) &&
           !string.IsNullOrEmpty(categoryList.Text) &&
           !string.IsNullOrEmpty(txtBodyField.Text);
        }
    }
}