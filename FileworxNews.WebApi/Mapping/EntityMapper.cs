using FileworxNews.Business.Models;
using FileworxNews.Shared.Dtos;

namespace FileworxNews.WebApi.Mapping
{
    public static class EntityMapper
    {
        public static FileWorxEntity ToBusiness(EntityDto fileworxEntity)
        {
            return new FileWorxEntity()
            {
                Id = fileworxEntity.Id,
                CreatorId = fileworxEntity.CreatorId,
                LastModifierId = fileworxEntity.LastModifierId,
                LastModificationDate = fileworxEntity.LastModificationDate,
                CreationDate = fileworxEntity.CreationDate,
                Name = fileworxEntity.Name,
            };
        }

        public static EntityDto ToEntity(FileWorxEntity businessEntity)
        {
            return new EntityDto()
            {
                Id = businessEntity.Id,
                CreatorId = businessEntity.CreatorId,
                LastModifierId = businessEntity.LastModifierId,
                LastModificationDate = businessEntity.LastModificationDate,
                CreationDate = businessEntity.CreationDate,
                Name = businessEntity.Name,
            };
        }
    }
}
