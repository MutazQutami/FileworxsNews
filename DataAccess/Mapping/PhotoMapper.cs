using FileworxNews.DataAccess.Entities;
using BusinessCls = FileworxNews.Business.Models;
namespace FileworxNews.DataAccess.Mapping
{
    public class PhotoMapper
    {
        public static Photo ToEntity(BusinessCls.Photo photo)
        {
            return new Photo()
            {
                Id = photo.Id,
                CreatorId = photo.CreatorId,
                LastModifierId = photo.LastModifierId,
                LastModificationDate = photo.LastModificationDate,
                CreationDate = photo.CreationDate,
                Name = photo.Name,
                Description = photo.Description,
                Body = photo.Body,
                PhotoPath = photo.PhotoPath,
            };
        }

        public static BusinessCls.Photo ToBusiness(Photo photo)
        {
            return new BusinessCls.Photo()
            {
                Id = photo.Id,
                CreatorId = photo.CreatorId,
                LastModifierId = photo.LastModifierId,
                LastModificationDate = photo.LastModificationDate,
                CreationDate = photo.CreationDate,
                Name = photo.Name,
                Description = photo.Description,
                Body = photo.Body,
                PhotoPath = photo.PhotoPath,
            };
        }

        public static List<BusinessCls.Photo> ToBusinessList(List<Photo> photos)
        {
            return photos.Select(photo => ToBusiness(photo)).ToList();
        }

        public static List<Photo> ToEntityList(List<BusinessCls.Photo> businessPhotos)
        {
            return businessPhotos.Select(businessPhoto => ToEntity(businessPhoto)).ToList();
        }
    }
}
