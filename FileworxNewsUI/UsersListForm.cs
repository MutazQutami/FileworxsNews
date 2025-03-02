using System.Diagnostics.Eventing.Reader;
using FileworxNewsBusiness;
namespace FileworxsNewsUI;
public partial class UsersListForm : Form
{
    private void OnAddUserButtonClick(object sender, EventArgs e)
    {
        UserForm newUserForm = new UserForm();

        if (newUserForm.ShowDialog() == DialogResult.OK)
        {
            AppUser newUser = newUserForm.RetrieveFormData();
            ListHandler.AddListItem(userList, newUser);
        }
    }
    private void OnUserListMouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right) // Right Click , Delete User
        {
            if (userList.SelectedItems.Count > 0)
            {
                ListViewItem selectedListItem = userList.SelectedItems[0];
                var selectedObject = (AppUser)selectedListItem.Tag;

                    SharedClass.HandleDeleteOperation(selectedObject, selectedListItem, userList);
            }
        }
    }
    private void OnUserListDoubleClick(object sender, EventArgs e)
    {
        if (userList.SelectedItems.Count > 0)
        {
            ListViewItem selectedListItem = userList.SelectedItems[0];
            EditUserLIstItem(selectedListItem);
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
        var userQuery = new AppUserQuery();
        var users = userQuery.Run();

        foreach (AppUser user in users)
        {
            ListHandler.AddListItem(userList , user);
        }
    }
    private void EditUserLIstItem(ListViewItem selectedListItem)
    {
        var selectedUser = (AppUser)selectedListItem.Tag;

        UserForm updateUserForm = new UserForm(selectedUser);
        updateUserForm.ShowDialog();

        if (updateUserForm.DialogResult == DialogResult.OK)
        {
            selectedUser = updateUserForm.RetrieveFormData();
            ListHandler.UpdateListItem(userList, selectedListItem, selectedUser);
        }
        
    }
    private void OnCancelButtonClick(object sender, EventArgs e)
    {
        this.Close();
    }
    
}