using FileworxNews.Business.Models;

namespace FileworxNews.WebApi.Mapping
{
    public class NewsMapper
    {
        public static News ToBusiness(News news)
        {
            return new News()
            {
                Id = news.Id,
                CreatorId = news.CreatorId,
                LastModifierId = news.LastModifierId,
                LastModificationDate = news.LastModificationDate,
                CreationDate = news.CreationDate,
                Name = news.Name,
                Category = (CategoryTypes)((int)(news.Category)),
            };
        }

        public static News ToEntity(News businessNews)
        {
            return new News()
            {
                Id = businessNews.Id,
                CreatorId = businessNews.CreatorId,
                LastModifierId = businessNews.LastModifierId,
                LastModificationDate = businessNews.LastModificationDate,
                CreationDate = businessNews.CreationDate,
                Name = businessNews.Name,
                Category = (CategoryTypes)((int)businessNews.Category),
            };
        }
    }
}
