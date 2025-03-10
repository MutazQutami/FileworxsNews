using FileworxNews.Business.Models;
using FileworxNews.Shared.Dtos;

namespace FileworxNews.WebApi.Mapping
{
    public class ContentMapper
    {
        public static ContentDto ToDto(Content content)
        {
            return new ContentDto()
            {
                Id = content.Id,
                CreatorId = content.CreatorId,
                LastModifierId = content.LastModifierId,
                LastModificationDate = content.LastModificationDate,
                CreationDate = content.CreationDate,
                Name = content.Name,
                Description = content.Description,
                Body = content.Body,
            };
        }

        public static Content ToEntity(ContentDto contentDto)
        {
            return new Content()
            {
                Id = contentDto.Id,
                CreatorId = contentDto.CreatorId,
                LastModifierId = contentDto.LastModifierId,
                LastModificationDate = contentDto.LastModificationDate,
                CreationDate = contentDto.CreationDate,
                Name = contentDto.Name,
                Description = contentDto.Description,
                Body = contentDto.Body,
                
            };
        }
    }
}
