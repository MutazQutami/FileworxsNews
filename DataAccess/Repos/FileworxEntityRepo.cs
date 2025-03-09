using FileworxNews.Business.Repos;
using FileworxNews.Business.Models;
using FileworxNews.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace FileworxNews.DataAccess.Repos
{
    public class FileworxEntityRepo : IFileworxEntityRepo
    {
        private readonly FileworxDbContext _context;

        public FileworxEntityRepo(FileworxDbContext context)
        {
            _context = context;
        }

        public async Task Update(FileWorxEntity entity)
        {
            try
            {
                entity.LastModificationDate = DateTime.UtcNow;

                if (entity.Id == Guid.Empty)
                {
                    entity.Id = Guid.NewGuid();
                    entity.CreationDate = DateTime.Now;
                    await _context.Entity.AddAsync(entity);
                }
                else
                {
                    _context.Entry(entity).State = EntityState.Modified;
                    _context.Entry(entity).CurrentValues.SetValues(entity);
                }

                  await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating entity.", ex);
            }

        }

        public async Task Delete(FileWorxEntity entity)
        {
            try
            {
                _context.Entity.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting photo.", ex);
            }
        }

        public async Task<FileWorxEntity> Read(FileWorxEntity entity)
        {

            var foundEntity = await _context.Entity.FindAsync(entity.Id);
            if (foundEntity != null)
            {
                return foundEntity;
            }
            else
            {
                return null;
            }

        }

        public IQueryable<FileWorxEntity> ReadAll()
        {
            return _context.Entity;
        }
    }
}