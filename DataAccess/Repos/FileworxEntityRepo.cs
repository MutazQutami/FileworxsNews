using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using FileworxNews.DataAccess.Mapping;
using Microsoft.EntityFrameworkCore;
using BusinessCls = FileworxNews.Business.Models;

namespace FileworxNews.DataAccess.Repos
{
    public class FileworxEntityRepo : IFileworxEntityRepo
    {
        private readonly FileworxDbContext _context;

        public FileworxEntityRepo(FileworxDbContext context)
        {
            _context = context;
        }

        public async Task Update(BusinessCls.FileWorxEntity entity)
        {
            try
            {
                entity.LastModificationDate = DateTime.UtcNow;

                var entityToUpdate = FileworxEntityMapper.ToEntity(entity);

                if (entityToUpdate.Id == Guid.Empty)
                {
                    entityToUpdate.Id = Guid.NewGuid();
                    entityToUpdate.CreationDate = DateTime.UtcNow;
                    await _context.Entity.AddAsync(entityToUpdate);
                }
                else
                {
                    _context.Entry(entityToUpdate).State = EntityState.Modified;
                    _context.Entry(entityToUpdate).CurrentValues.SetValues(entityToUpdate);
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating entity.", ex);
            }
        }

        public async Task Delete(BusinessCls.FileWorxEntity entity)
        {
            try
            {
                var entityToDelete = FileworxEntityMapper.ToEntity(entity);
                _context.Entity.Remove(entityToDelete);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting entity.", ex);
            }
        }

        public async Task<BusinessCls.FileWorxEntity> Read(BusinessCls.FileWorxEntity entity)
        {
            try
            {
                var foundEntity = await _context.Entity.FindAsync(entity.Id);
                if (foundEntity != null)
                {
                    return FileworxEntityMapper.ToBusiness(foundEntity);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading entity.", ex);
            }
        }

        public IQueryable<BusinessCls.FileWorxEntity> ReadAll()
        {
            try
            {
                var entities = _context.Entity.AsQueryable();
                return entities.Select(e => FileworxEntityMapper.ToBusiness(e));
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all entities.", ex);
            }
        }
    }
}
