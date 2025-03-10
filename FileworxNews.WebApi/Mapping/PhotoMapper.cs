using FileworxNews.Business.Models;
using FileworxNews.Shared.Dtos;

namespace FileworxNews.WebApi.Mapping
{
    namespace FileworxNews.Shared.Mappers
    {
        public static class PhotoMapper
        {
            public static Photo ToEntity(Photo photoDto)
            {
                return new Photo()
                {
                    Id = photoDto.Id,
                    CreatorId = photoDto.CreatorId,
                    LastModifierId = photoDto.LastModifierId,
                    LastModificationDate = photoDto.LastModificationDate,
                    CreationDate = photoDto.CreationDate,
                    Name = photoDto.Name,
                    Description = photoDto.Description,
                    Body = photoDto.Body,
                    PhotoPath = photoDto.PhotoPath,
                };
            }

            public static PhotoDto ToDto(Photo photoEntity)
            {
                return new PhotoDto()
                {
                    Id = photoEntity.Id,
                    CreatorId = photoEntity.CreatorId,
                    LastModifierId = photoEntity.LastModifierId,
                    LastModificationDate = photoEntity.LastModificationDate,
                    CreationDate = photoEntity.CreationDate,
                    Name = photoEntity.Name,
                    Description = photoEntity.Description,
                    Body = photoEntity.Body,
                    PhotoPath = photoEntity.PhotoPath,
                };
            }
        }
    }
}
