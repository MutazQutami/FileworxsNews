using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FileworxNewsBusiness;

namespace FileworxsNewsUI
{
    public static class ListHandler
    {
        public static void AddListItem(ListView _targetList , FileWorxEntity _entity , int _index=0)
        {
            ListViewItem _listItem = new ListViewItem();
            
            if(_entity is AppUser)   // user item
            {
                AddUserListItem( _listItem, _entity);
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
            RemoveListItem(_targetList , _selectedListItem); // Removing the old one 
            AddListItem(_targetList, _entity , _index);     //  Adding the new one
        }
        private static void AddUserListItem(ListViewItem _listItem , FileWorxEntity _entity)
        {
            AppUser _userItem= UserServices.RetrieveUser(_entity.GuidValue);
            _listItem.Text = _userItem.Name;
            _listItem.SubItems.Add(_userItem.LogInName.ToString());
            _listItem.SubItems.Add(_userItem.Date.ToString());
            _listItem.SubItems.Add(_userItem.Password);
            _listItem.Tag = _entity.GuidValue;    // guid value tag to distinguish between users
        }
        private static void AddContentListItem(ListViewItem _listItem , FileWorxEntity _entity)
        {
            Content _contentItem;

            if (_entity is Photo _photoItem)
            {
                _contentItem = PhotoServices.RetrievePhoto(_entity.GuidValue);
               
            }
            else
            {
                _contentItem = NewServices.RetrieveNew(_entity.GuidValue);
            }

            _listItem.Tag = (_contentItem);
            _listItem.Text = _contentItem.Title;
            _listItem.SubItems.Add(_contentItem.Date.ToString());
            _listItem.SubItems.Add(_contentItem.Description);
        }
    }
}
