using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FileworxNewsBusiness;
namespace FileworxsNewsUI
{
    public partial class UsersListForm : Form
    {
        private void OnAddUserButtonClick(object sender, EventArgs e)
        {
            UserForm newUserForm = new UserForm();

            if (newUserForm.ShowDialog() == DialogResult.OK)
            {
                AppUser newUser = UserServices.RetrieveUser(newUserForm.FormGuidValue);
                ListHandler.AddListItem(userList, newUser);
            }
        }
        private void OnUserListMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && userList.FocusedItem != null)
            {
                ListViewItem _selectedListItem = userList.FocusedItem;

                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ListHandler.RemoveListItem(userList,_selectedListItem); // delete from list

                    var _object = _selectedListItem.Tag as AppUser;
                    UserServices.DeleteUser(_object.GuidValue); // delete from database
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
            List<AppUser> users = UserServices.RetrieveUsers();

            foreach (AppUser user in users)
            {
                ListHandler.AddListItem(userList , user);
            }
        }
        private void EditUserLIstItem(ListViewItem _selectedListItem)
        {
            Guid _objectGuid = (Guid)_selectedListItem.Tag; 
            AppUser _user = UserServices.RetrieveUser(_objectGuid);
                
            UserForm _updateUserForm = new UserForm(_objectGuid);
            _updateUserForm.ShowDialog();

            if (_updateUserForm.DialogResult == DialogResult.OK)
            {
                AppUser _updatedUser = UserServices.RetrieveUser(_updateUserForm.FormGuidValue);
                ListHandler.UpdateListItem(userList, _selectedListItem, _updatedUser);
            }
            
        }
    }
}