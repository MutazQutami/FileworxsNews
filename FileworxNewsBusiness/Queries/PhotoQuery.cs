using FileworxNews.Business.Models;
using FileworxNews.Business.Queries;
using FileworxNews.Business.Repos;

namespace FileworxNews.Business.Repos
{
    public class PhotoQuery : ContentQuery
    {
        public StringFilter QPhotoPath = new StringFilter();

        private readonly IPhotoQueryRepo _repo;

        public PhotoQuery(IPhotoQueryRepo repo)
        {
            _repo = repo;
        }

        public List<Photo> Run()
        {
          return _repo.Run(this);
        }
    }
}
