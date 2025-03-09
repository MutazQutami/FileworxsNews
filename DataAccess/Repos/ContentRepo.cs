using FileworxNews.Business.Models;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace FileworxNews.DataAccess.Repos
{
    public class ContentRepo : IContentRepo
    {
        private readonly FileworxDbContext _context;

        public ContentRepo(FileworxDbContext context)
        {
            _context = context;
        }

        public async Task Delete(Content content)
        {
            try
            {
                _context.Content.Remove(content);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting content.", ex);
            }
        }

        public async Task<Content> Read(Content content)
        {
            try
            {
                return await _context.Content.FindAsync(content.Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading content.", ex);
            }
        }

        public async Task<List<Content>> ReadAll()
        {
            try
            {
                return await _context.Content.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all content.", ex);
            }
        }

        public async Task Update(Content content)
        {
            try
            {
                if (content.Id == Guid.Empty)
                {
                    content.Id = Guid.NewGuid();
                    await _context.Content.AddAsync(content);
                }
                else
                {
                    _context.Entry(content).State = EntityState.Modified;
                    _context.Entry(content).CurrentValues.SetValues(content);
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating content.", ex);
            }
        }
    }

}
