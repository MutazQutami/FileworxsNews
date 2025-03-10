using FileworxNews.DataAccess.Entities;
using BusinessCls = FileworxNews.Business.Models;
namespace FileworxNews.DataAccess.Mapping
{
    public class NewsMapper
    {
        public static BusinessCls.News ToBusiness(News news)
        {
            return new BusinessCls.News()
            {
                Id = news.Id,
                CreatorId = news.CreatorId,
                LastModifierId = news.LastModifierId,
                LastModificationDate = news.LastModificationDate,
                CreationDate = news.CreationDate,
                Name = news.Name,
                Category = (BusinessCls.CategoryTypes)((int)(news.Category)),
            };
        }

        public static News ToEntity(BusinessCls.News businessNews)
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

        public static List<BusinessCls.News> ToBusinessList(List<News> newsList)
        {
            return newsList.Select(news => ToBusiness(news)).ToList();
        }

        public static List<News> ToEntityList(List<BusinessCls.News> businessNewsList)
        {
            return businessNewsList.Select(businessNews => ToEntity(businessNews)).ToList();
        }
    }
}
