using FileworxNews.Business.Models;

namespace FileworxNews.Business.Repos
{
    public interface IPhotoRepo
    {
        Task Update(Photo photo);

        Task Delete(Photo photo);

        Task<Photo> Read(Photo photo);

        Task<List<Photo>> ReadAll();
    }
}
