using FileworxNews.DataAccess.Entities;
using BusinessCls = FileworxNews.Business.Models;
namespace FileworxNews.DataAccess.Mapping
{
    public class FileworxEntityMapper
    {
        public static BusinessCls.FileWorxEntity ToBusiness(FileworxEntity fileworxEntity)
        {
            return new BusinessCls.FileWorxEntity()
            {
                Id = fileworxEntity.Id,
                CreatorId = fileworxEntity.CreatorId,
                LastModifierId = fileworxEntity.LastModifierId,
                LastModificationDate = fileworxEntity.LastModificationDate,
                CreationDate = fileworxEntity.CreationDate,
                Name = fileworxEntity.Name,
            };
        }

        public static FileworxEntity ToEntity(BusinessCls.FileWorxEntity businessEntity)
        {
            return new FileworxEntity()
            {
                Id = businessEntity.Id,
                CreatorId = businessEntity.CreatorId,
                LastModifierId = businessEntity.LastModifierId,
                LastModificationDate = businessEntity.LastModificationDate,
                CreationDate = businessEntity.CreationDate,
                Name = businessEntity.Name,
            };
        }

        public static List<BusinessCls.FileWorxEntity> ToBusinessList(List<FileworxEntity> fileworxEntities)
        {
            return fileworxEntities.Select(entity => ToBusiness(entity)).ToList();
        }

        public static List<FileworxEntity> ToEntityList(List<BusinessCls.FileWorxEntity> businessEntities)
        {
            return businessEntities.Select(businessEntity => ToEntity(businessEntity)).ToList();
        }
    }
}
