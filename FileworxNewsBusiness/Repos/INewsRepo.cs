using FileworxNews.Business.Models;

namespace FileworxNews.Business.Repos
{
    public interface INewsRepo
    {
        Task Update(News news);

        Task Delete(News news);

        Task<News> Read(News news);

        Task<List<News>> ReadAll();
    }
}
