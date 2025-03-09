using Microsoft.EntityFrameworkCore.Diagnostics;
using FileworxNews.Business.Models;
namespace FileworxNews.Business.Repos
{
    public interface IFileworxEntityRepo
    {
        Task Update(FileWorxEntity entity);
        
        Task Delete(FileWorxEntity entity);
        
        Task <FileWorxEntity> Read(FileWorxEntity entity);
        
        IQueryable<FileWorxEntity> ReadAll();
    }
}
