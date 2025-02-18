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
        public static void AddLisItem(ListView _targetList , FileWorxEntity _entity , int _index=0)
        {
            ListViewItem _listItem = new ListViewItem();
            
            if(_entity is AppUser _userItem)
            {
                AddUserListItem(_userItem, _listItem);
            }
            else if (_entity is Photo _photoItem)
            {
                AddPhotoListItem(_photoItem, _listItem);
            }
            else if (_entity is New _newItem)
            {
                AddNewListItem(_newItem, _listItem);
            }
            _targetList.Items.Insert(_index, _listItem);
        }
        public static void RemoveListItem(ListView _targetList , ListViewItem _selectedListItem)
        {
            var _selectedObject = (FileWorxEntity)_selectedListItem.Tag;
            _targetList.Items.Remove(_selectedListItem);
        }
        public static void UpdateListItem(ListView _targetList , ListViewItem _selectedListItem , FileWorxEntity _entity)
        {
            int _index = _selectedListItem.Index;
            ListViewItem _newListItem = new ListViewItem();

            _selectedListItem.SubItems.Clear();
            RemoveListItem(_targetList , _selectedListItem); // Romving the old one 
            AddLisItem(_targetList, _entity , _index);// adding the new one
        }
        private static void AddUserListItem(AppUser _userItem,ListViewItem _listItem)
        {
            _listItem.Text = _userItem.Name;
            _listItem.SubItems.Add(_userItem.LogInName.ToString());
            _listItem.SubItems.Add(_userItem.Date.ToString());
            _listItem.SubItems.Add(_userItem.Password);
            _listItem.SubItems.Add(_userItem.LastModifier);
            _listItem.SubItems.Add(_userItem.GuidValue.ToString());
            _listItem.Tag = _userItem;
        }
        private static void AddPhotoListItem(Photo _photoItem,ListViewItem _listItem)
        {
            _listItem.Text = _photoItem.Title;
            _listItem.SubItems.Add(_photoItem.Date.ToString());
            _listItem.SubItems.Add(_photoItem.Description);
            _listItem.SubItems.Add(_photoItem.PhotoPath);
            _listItem.SubItems.Add(_photoItem.GuidValue.ToString());
            _listItem.SubItems.Add(_photoItem.Body);
            _listItem.Tag = _photoItem;
        }
        private static void AddNewListItem(New _newItem,ListViewItem _listItem)
        {
            _listItem.Text = _newItem.Title;
            _listItem.SubItems.Add(_newItem.Date.ToString());
            _listItem.SubItems.Add(_newItem.Description);
            _listItem.SubItems.Add(_newItem.Category);
            _listItem.SubItems.Add(_newItem.GuidValue.ToString());
            _listItem.SubItems.Add(_newItem.Category);
            _listItem.SubItems.Add(_newItem.Body);
            _listItem.Tag = _newItem;
        }
    }
}
