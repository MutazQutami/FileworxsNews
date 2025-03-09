using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileworxNews.Business.Models;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace FileworxNews.DataAccess.Repos
{
    public class PhotoRepo : IPhotoRepo
    {
        private readonly FileworxDbContext _context;

        public PhotoRepo(FileworxDbContext context)
        {
            _context = context;
        }

        public async Task Delete(Photo photo)
        {
            try
            {
                _context.Photo.Remove(photo);
                await _context.SaveChangesAsync(); 
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting the photo.", ex);
            }
        }

        public async Task<Photo> Read(Photo photo)
        {
            try
            {

                return await _context.Photo.FindAsync(photo.Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading the photo.", ex);
            }
        }

        public async Task<List<Photo>> ReadAll()
        {
            try
            {
                return await _context.Photo.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all Photo.", ex);
            }
        }

        public async Task Update(Photo photo)
        {
            try
            {
                if (photo.Id == Guid.Empty)
                {
                    photo.Id = Guid.NewGuid(); 
                    await _context.Photo.AddAsync(photo); 
                }
                else
                {
                    _context.Entry(photo).State = EntityState.Modified;
                    _context.Entry(photo).CurrentValues.SetValues(photo); 
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
