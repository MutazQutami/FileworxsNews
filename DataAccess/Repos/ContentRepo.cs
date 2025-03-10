using BusinessCls = FileworxNews.Business.Models;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using FileworxNews.DataAccess.Mapping;
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

        public async Task Delete(BusinessCls.Content content)
        {
            try
            {
                var contentEntity = ContentMapper.ToEntity(content);
                _context.Content.Remove(contentEntity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting content.", ex);
            }
        }

        public async Task<BusinessCls.Content> Read(BusinessCls.Content content)
        {
            try
            {
                var contentEntity = await _context.Content.FindAsync(content.Id);
                if (contentEntity == null)
                {
                    throw new Exception("Content not found.");
                }
                return ContentMapper.ToBusiness(contentEntity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading content.", ex);
            }
        }

        public async Task<List<BusinessCls.Content>> ReadAll()
        {
            try
            {
                var contentEntities = await _context.Content.ToListAsync();
                return ContentMapper.ToBusinessList(contentEntities);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all content.", ex);
            }
        }

        public async Task Update(BusinessCls.Content content)
        {
            try
            {
                var contentEntity = ContentMapper.ToEntity(content);

                if (content.Id == Guid.Empty)
                {
                    contentEntity.Id = Guid.NewGuid();
                    await _context.Content.AddAsync(contentEntity);
                }
                else
                {
                    contentEntity.LastModificationDate = DateTime.Now;
                    _context.Entry(contentEntity).State = EntityState.Modified;
                    _context.Entry(contentEntity).CurrentValues.SetValues(contentEntity);
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
