using FileworxNewsBusiness;
namespace FileworxsNewsUI;
public static class ListHandler
{
    public static void AddListItem(ListView targetList, FileWorxEntity entity, int index = 0)
    {
        ListViewItem listItem = new ListViewItem();

        if (entity is AppUser entityUppUser)   //Users List 
        {
            AddUserListItem(listItem, entityUppUser);
        }
        else if (entity is Content contentEntity) // Content List
        {
            AddContentListItem(listItem, contentEntity);
        }

        targetList.Items.Insert(index, listItem);
    }
    public static void RemoveListItem(ListView targetList, ListViewItem selectedListItem)
    {
        targetList.Items.Remove(selectedListItem);
    }
    public static void UpdateListItem(ListView targetList, ListViewItem selectedListItem, FileWorxEntity entity)
    {
        int index = selectedListItem.Index;
        ListViewItem _newListItem = new ListViewItem();

        selectedListItem.SubItems.Clear();
        RemoveListItem(targetList, selectedListItem); // Removing the old one form list 
        AddListItem(targetList, entity, index);     //  Adding the new one with the same index
    }
    private static void AddUserListItem(ListViewItem listItem, AppUser entity)
    {
        try
        {
            var userQuery = new AppUserQuery();
            userQuery.QId = entity.LastModifierId;         // the last modifier name
            var result = userQuery.Run().FirstOrDefault();

            var lastModifier = result.Name;
            listItem.Text = entity.Name;
            listItem.SubItems.Add(entity.LogInName.ToString());
            listItem.SubItems.Add(entity.CreationDate.ToString("yyyy-MM-dd HH:mm:ss"));
            listItem.SubItems.Add(lastModifier);
            listItem.Tag = entity;   
        }
        catch (Exception)
        {

            return;
        }
    }
    private static void AddContentListItem(ListViewItem listItem, Content contentEntity)
    {
  
        listItem.Text = contentEntity.Name;
        listItem.SubItems.Add(contentEntity.CreationDate.ToString());
        listItem.SubItems.Add(contentEntity.Description);
        listItem.Tag = contentEntity;
    }
}
