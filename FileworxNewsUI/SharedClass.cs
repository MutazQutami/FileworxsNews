﻿using FileworxNewsBusiness;

namespace FileworxsNewsUI
{
    public static class SharedClass
    {
     
        public static AppUser CurrentUser= new AppUser();
        public static void HandleDeleteOperation(FileWorxEntity selectedObject, ListViewItem selectedItem, ListView listView)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                selectedObject.Delete();
                ListHandler.RemoveListItem(listView, selectedItem); // delete from list
            }
        }

    }
}
