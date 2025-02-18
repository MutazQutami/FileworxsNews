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
        public static bool AddPhoto(Photo _photoItem)
        {
            return BaseServices.Add(_photoItem);
        }
        public static bool UpdatePhoto(Photo _photoItem)
        {
            return BaseServices.Update(_photoItem);
        }
        public static bool DeletePhoto(Guid _guidValue)
        {
            return BaseServices.Delete(
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
            return BaseServices.RetriveObjects(new Photo()).Cast<Photo>().ToList();
        }
    }
}
