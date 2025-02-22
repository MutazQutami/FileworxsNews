using FileworxNewsBusiness;

namespace FileworxsNewsUI
{
    public abstract class BaseFormOperations<T> : Form
    {
        protected virtual void OnCancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        protected bool isEditForm;
        protected T formObjectItem;
        public void InitializeForm(T item)
        {
            if (item == null)
            {
                formObjectItem = Activator.CreateInstance<T>();
                isEditForm = false;
                return;
            }

            formObjectItem = item;
            isEditForm = true;

            InitializeSpecificFormFields(item);
        }
        protected abstract void InitializeSpecificFormFields(T item);
        public abstract T RetrieveFormData();
    }
}
