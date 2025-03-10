using FileworxNews.Business.Models;
using FileworxNews.Business.Queries;

namespace FileworxNews.Business.Repos
{
    public interface IFileworxEntityQueryRepo
    {
        public List<FileWorxEntity> Run(FileworxEntityQuery queryObject);
    }
}
