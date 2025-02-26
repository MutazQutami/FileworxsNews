using FileworxNewsBusiness;
namespace FileworxsNewsUI;
public partial class UsersListForm : Form
{
    private void OnAddUserButtonClick(object sender, EventArgs e)
    {
        UserForm newUserForm = new UserForm();

        if (newUserForm.ShowDialog() == DialogResult.OK)
        {
            AppUser _newUser = newUserForm.RetrieveFormData();
            ListHandler.AddListItem(userList, _newUser);
        }
    }
    private void OnUserListMouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            if (userList.SelectedItems.Count > 0)
            {
                ListViewItem _selectedListItem = userList.FocusedItem;
                var _selectedObject = (AppUser)_selectedListItem.Tag;

                if (e.Button == MouseButtons.Right) // right click
                {
                    CommonActions.HandleDeleteOperation(_selectedObject, _selectedListItem, userList);
                }
            }
        }
    }
    private void OnUserListDoubleClick(object sender, EventArgs e)
    {
        if (userList.SelectedItems.Count > 0)
        {
            ListViewItem _selectedListItem = userList.SelectedItems[0];
            EditUserLIstItem(_selectedListItem); 
        }
    }
    public UsersListForm()
    {
        InitializeComponent();
        RetrieveUsers();
    }
    private void RetrieveUsers()
    {
        userList.Items.Clear();
        var _users = BaseOperations<AppUser>.RetrieveAll();

        foreach (AppUser _user in _users)
        {
            ListHandler.AddListItem(userList , _user);
        }
    }
    private void EditUserLIstItem(ListViewItem _selectedListItem)
    {
        var _objectGuid = (AppUser)_selectedListItem.Tag; 

        AppUser _updatedUser = BaseOperations<AppUser>.Retrieve(_objectGuid.Id);
            
        UserForm _updateUserForm = new UserForm(_updatedUser);
        _updateUserForm.ShowDialog();

        if (_updateUserForm.DialogResult == DialogResult.OK)
        {
            _updatedUser = _updateUserForm.RetrieveFormData();
            ListHandler.UpdateListItem(userList, _selectedListItem, _updatedUser);
        }
        
    }
    private void OnCancelButtonClick(object sender, EventArgs e)
    {
        this.Close();
    }
    
}