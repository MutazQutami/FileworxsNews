using FileworxNewsBusiness;
namespace FileworxsNewsUI;
public static class ListHandler
{
    public static void AddListItem(ListView _targetList , FileWorxEntity _entity , int _index=0)
    {
        ListViewItem _listItem = new ListViewItem();
        
        if(_entity is AppUser _entityUppUser)   // user item
        {
            AddUserListItem( _listItem, _entityUppUser);
        }
        else                   // photo , new items
        {
            AddContentListItem( _listItem , _entity);
        }
        _targetList.Items.Insert(_index, _listItem);
    }
    public static void RemoveListItem(ListView _targetList , ListViewItem _selectedListItem)
    {
        _targetList.Items.Remove(_selectedListItem);
    }
    public static void UpdateListItem(ListView _targetList , ListViewItem _selectedListItem , FileWorxEntity _entity)
    {
        int _index = _selectedListItem.Index;
        ListViewItem _newListItem = new ListViewItem();

        _selectedListItem.SubItems.Clear();
        RemoveListItem(_targetList, _selectedListItem); // Removing the old one 
        AddListItem(_targetList, _entity, _index);     //  Adding the new one with the same index
    }
    private static void AddUserListItem(ListViewItem _listItem , AppUser _entity)
    {
        var _userItem= BaseOperations<AppUser>.Retrieve(_entity.GuidValue);
        _listItem.Text = _entity.Name;
        _listItem.SubItems.Add(_entity.LogInName.ToString());
        _listItem.SubItems.Add(_entity.Date.ToString());
        _listItem.SubItems.Add(_entity.Password);
        _listItem.Tag = _entity.GuidValue;    // guid value tag to distinguish between users
    }
    private static void AddContentListItem(ListViewItem _listItem , FileWorxEntity _entity)
    {
        Content _contentItem;

        if (_entity is Photo _photoItem)
        {
            _contentItem = BaseOperations<Photo>.Retrieve(_entity.GuidValue);
        }
        else
        {
            _contentItem = BaseOperations<New>.Retrieve(_entity.GuidValue);
        }

        _listItem.Tag = _contentItem;
        _listItem.Text = _contentItem.Title;
        _listItem.SubItems.Add(_contentItem.Date.ToString());
        _listItem.SubItems.Add(_contentItem.Description);
    }
}
