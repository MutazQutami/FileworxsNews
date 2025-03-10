using FileworxNews.DataAccess.Entities;
using BusinessCls = FileworxNews.Business.Models;
namespace FileworxNews.DataAccess.Mapping
{
    public class ContentMapper
    {
        public static BusinessCls.Content ToBusiness(Content content)
        {
            return new BusinessCls.Content()
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

        public static Content ToEntity(BusinessCls.Content businessContent)
        {
            return new Content()
            {
                Id = businessContent.Id,
                CreatorId = businessContent.CreatorId,
                LastModifierId = businessContent.LastModifierId,
                LastModificationDate = businessContent.LastModificationDate,
                CreationDate = businessContent.CreationDate,
                Name = businessContent.Name,
                Description = businessContent.Description,
                Body = businessContent.Body
            };
        }

        public static List<BusinessCls.Content> ToBusinessList(List<Content> contents)
        {
            return contents.Select(content => ToBusiness(content)).ToList();
        }

        public static List<Content> ToEntityList(List<BusinessCls.Content> businessContents)
        {
            return businessContents.Select(businessContent => ToEntity(businessContent)).ToList();
        }
    }
}
