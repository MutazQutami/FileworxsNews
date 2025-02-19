using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxNewsBusiness
{
    public static class PhotoServices
    {
        public static void AddPhoto(Photo _photoItem)
        {
             BaseServices.Add(_photoItem);
        }
        public static void UpdatePhoto(Photo _photoItem)
        {
             BaseServices.Update(_photoItem);
        }
        public static void DeletePhoto(Guid _guidValue)
        {
             BaseServices.Delete(
                new Photo 
                { 
                    GuidValue = _guidValue 
                }
                );
        }
        public static Photo RetrievePhoto(Guid _guidValue)
        {
            Photo _photoItem = (Photo)BaseServices.Retrieve(new Photo { GuidValue = _guidValue } );    
            return _photoItem;
        }
        public static  List<Photo> RetrievePhotos()
        {
            return BaseServices.RetrieveObjects(new Photo()).Cast<Photo>().ToList();
        }
    }
}
