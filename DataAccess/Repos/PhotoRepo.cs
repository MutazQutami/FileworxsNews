using BusinessCls = FileworxNews.Business.Models;
using FileworxNews.Business.Models;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using FileworxNews.DataAccess.Mapping;

namespace FileworxNews.DataAccess.Repos
{
    public class PhotoRepo : IPhotoRepo
    {
        private readonly FileworxDbContext _context;

        public PhotoRepo(FileworxDbContext context)
        {
            _context = context;
        }

        public async Task Delete(BusinessCls.Photo photo)
        {
            try
            {
                var photoEntity = PhotoMapper.ToEntity(photo);
                _context.Photo.Remove(photoEntity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting the photo.", ex);
            }
        }

        public async Task<BusinessCls.Photo> Read(BusinessCls.Photo photo)
        {
            try
            {
                var photoEntity = await _context.Photo.FindAsync(photo.Id);
                if (photoEntity == null)
                {
                    throw new Exception("Photo not found.");
                }
                return PhotoMapper.ToBusiness(photoEntity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading the photo.", ex);
            }
        }

        public async Task<List<BusinessCls.Photo>> ReadAll()
        {
            try
            {
                var photoEntities = await _context.Photo.ToListAsync();
                return PhotoMapper.ToBusinessList(photoEntities);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all photos.", ex);
            }
        }

        public async Task Update(BusinessCls.Photo photo)
        {
            try
            {
                var photoEntity = PhotoMapper.ToEntity(photo);

                if (photo.Id == Guid.Empty)
                {
                    photo.Id = Guid.NewGuid();
                    await _context.Photo.AddAsync(photoEntity);
                }
                else
                {
                    _context.Entry(photoEntity).State = EntityState.Modified;
                    _context.Entry(photoEntity).CurrentValues.SetValues(photoEntity);
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating the photo.", ex);
            }
        }
    }
}

