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
                User newUser = newUserForm.formUser;
                AddUserListItem(newUser);
            }
        }
        private void OnUserListMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && userList.FocusedItem != null)
            {
                FileWorxEntity selectedObject = (FileWorxEntity)userList.FocusedItem.Tag;

                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    FileHandler.DeleteObject(selectedObject);
                    userList.Items.Remove(userList.FocusedItem);
                }
            }
        }
        public UsersListForm()
        {
            InitializeComponent();
            // ResizeUsersTable();
            RetrieveUsers();
        }
        private void RetrieveUsers()
        {
            userList.Items.Clear();
            List<User> users = FileHandler.JsonDeserializationObjects(new User())
            .Cast<User>().ToList();

            foreach (User user in users)
            {
                AddUserListItem (user);
            }
        }
        private void OnUserListDoublClick(object sender, EventArgs e)
        {

            if (userList.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = userList.SelectedItems[0];
                var selectedObject = selectedItem.Tag;

                if (selectedObject is User selectedUser)
                {

                    UserForm form = new UserForm(selectedUser);
                    form.ShowDialog();

                    if (form.DialogResult == DialogResult.OK)
                    {
                        User updatedUser = form.formUser;
                        selectedItem.Text = updatedUser.Name;  // Update the first column
                        selectedItem.SubItems[1].Text = updatedUser.LogInName;
                        selectedItem.SubItems[3].Text = updatedUser.Password;
                        selectedItem.SubItems[4].Text = updatedUser.LastModifier;


                    }
                }
            }
        }
        private void AddUserListItem(User _user)
        {
            ListViewItem listItem = new ListViewItem(_user.Name)
            {
                Tag = _user
            };

            listItem.SubItems.Add(_user.LogInName);
            listItem.SubItems.Add(_user.Date.ToString());
            listItem.SubItems.Add(_user.Password);
            listItem.SubItems.Add(_user.LastModifier);
            listItem.SubItems.Add(_user.GuidValue.ToString());
            userList.Items.Insert(0, listItem);
        }
    }
}