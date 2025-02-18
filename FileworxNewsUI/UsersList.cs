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
                AppUser newUser = newUserForm.FormUserInfo();
                ListHandler.AddLisItem(userList, newUser);
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
                    FileHandler.DeleteObject(_object); // delete from database
                }
            }
        }
        private void OnUserListDoublClick(object sender, EventArgs e)
        {
            if (userList.SelectedItems.Count > 0)
            {
                ListViewItem _selectedListItem = userList.SelectedItems[0];
                EditUserLIstItem(_selectedListItem); //
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
            List<AppUser> users = FileHandler.JsonDeserializationObjects(new AppUser())
            .Cast<AppUser>().ToList();

            foreach (AppUser user in users)
            {
                ListHandler.AddLisItem(userList , user);
            }
        }
        private void EditUserLIstItem(ListViewItem _selectedListItem)
        {
            var _selectedObject = _selectedListItem.Tag;

            if (_selectedObject is AppUser _selectedUser)
            {
                UserForm _updateUserForm = new UserForm(_selectedUser);
                _updateUserForm.ShowDialog();

                if (_updateUserForm.DialogResult == DialogResult.OK)
                {
                    AppUser _updatedUser = _updateUserForm.FormUserInfo();

                    _updatedUser.GuidValue = _selectedUser.GuidValue; 
                    _updatedUser.Date = _selectedUser.Date;

                    ListHandler.UpdateListItem(userList, _selectedListItem, _updatedUser);
                }
            }
        }
    }
}