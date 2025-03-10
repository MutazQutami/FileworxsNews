using FileworxNews.Business.Models;

namespace FileworxNews.Business.Repos
{
    public interface IPhotoQueryRepo
    {
        public List<Photo> Run(PhotoQuery queryObject);
    }
}
