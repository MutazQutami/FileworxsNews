using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxNewsBusiness
{
    public class PhotoServices
    {
        public bool AddPhoto(string title , string description, 
                             string body , string photoName , string photoPath)
        {
            return BaseServices.Add(
                new Photo
                {
                    Title = title,
                    Description = description,
                    Body = body,
                    PhotoName = photoName,
                    PhotoPath = photoPath
                }
            );
        }
        public bool UpdatePhoto(string title, string description, string body, 
                                string photoName, string photoPath , Guid guidValue)
        {
            return BaseServices.Update(
                 new Photo
                 {
                     Title = title,
                     Description = description,
                     Body = body,
                     PhotoName = photoName,
                     PhotoPath = photoPath,
                     GuidValue = guidValue
                 }
             );
        }
        public bool DeletePhoto(Guid guidValue)
        {
            return BaseServices.Delete(
                new Photo 
                { 
                    GuidValue = guidValue 
                }
                );
        }
        public bool RetrievePhoto(Guid guidValue)
        {
            return true;
        }
        public bool RetrievePhotos()
        {
            return true;
        }
    }
}
