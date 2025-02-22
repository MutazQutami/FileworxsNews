using FileworxNewsBusiness;

namespace FileworxsNewsUI;
internal class CommonActions
{
    public static bool AreFieldsValid(params Control[] fields)
    {
        return fields.All(field => !string.IsNullOrWhiteSpace(field.Text));
    }
    public static void Visibility(Label showLabel, Label hideLabel)
    {
        showLabel.Show();
        hideLabel.Hide();
    }
    public static void HandleDeleteOperation(object selectedObject, ListViewItem selectedItem, ListView listView)
    {
        DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (result == DialogResult.Yes)
        {
            // Handle deletion based on the type of object
            if (selectedObject is Photo photoObject)
            {
                BaseOperations<Photo>.Delete(new Photo() { GuidValue = photoObject.GuidValue });
            }
            else if (selectedObject is New newObject)
            {
                BaseOperations<New>.Delete(new New() { GuidValue = newObject.GuidValue });
            }
            else if (selectedObject is AppUser userObject)
            {
                var _userGuidValue = userObject.GuidValue;
                BaseOperations<AppUser>.Delete(new AppUser() { GuidValue = _userGuidValue });
            }

            ListHandler.RemoveListItem(listView, selectedItem); // delete from list
        }
    }
}
