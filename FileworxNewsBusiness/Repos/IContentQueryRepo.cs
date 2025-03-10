using FileworxNews.Business.Models;
using FileworxNews.Business.Queries;

namespace FileworxNews.Business.Repos
{
    public interface IContentQueryRepo 
    {
        public List<Content> Run(ContentQuery queryObject);
    }
}
