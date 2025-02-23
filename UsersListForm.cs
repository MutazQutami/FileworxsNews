using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FileworxsNews
{
    public partial class UsersListForm : Form
    {
        private void UsersListResize(object sender, EventArgs e)
        {
            //ResizeUsersTable();
        }
        private void OnAddUserButtonClick(object sender, EventArgs e)
        {
            UserForm newUserForm = new UserForm();

            if (newUserForm.ShowDialog() == DialogResult.OK)
            {
                User newUser = newUserForm.formUser;
                ListViewItem listItem = new ListViewItem(newUser.Name)
                {
                    Tag = newUser
                };

                listItem.SubItems.Add(newUser.LogInName);
                listItem.SubItems.Add(newUser.Date.ToString());
                listItem.SubItems.Add(newUser.Password);
                listItem.SubItems.Add(newUser.LastModifier);
                listItem.SubItems.Add(newUser.GuidValue.ToString());
                userList.Items.Insert(0,listItem);

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
                ListViewItem listItem = new ListViewItem(user.Name)
                {
                    Tag = user
                };

                listItem.SubItems.Add(user.LogInName);
                listItem.SubItems.Add(user.Date.ToString());
                listItem.SubItems.Add(user.Password);
                listItem.SubItems.Add(user.LastModifier);
                listItem.Tag = user;
                userList.Items.Add(listItem);
            }
        }
        private void userList_DoubleClick(object sender, EventArgs e)
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
    }
}