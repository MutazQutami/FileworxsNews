using BusinessCls =FileworxNews.Business.Models;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using FileworxNews.DataAccess.Mapping;
using Microsoft.EntityFrameworkCore;
using FileworxNews.DataAccess.Entities;

namespace FileworxNews.DataAccess.Repos
{
    public class NewsRepo : INewsRepo
    {
        private readonly FileworxDbContext _context;

        public NewsRepo(FileworxDbContext context)
        {
            _context = context;
        }

        public async Task Delete(BusinessCls.News news)
        {
            try
            {
                var newsEntity = NewsMapper.ToEntity(news);
                _context.News.Remove(newsEntity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting the news.", ex);
            }
        }

        public async Task<BusinessCls.News> Read(BusinessCls.News news)
        {
            try
            {
                var newsEntity = await _context.News.FindAsync(news.Id);

                if (newsEntity == null)
                {
                    throw new Exception("News not found.");
                }

                return NewsMapper.ToBusiness(newsEntity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading the news.", ex);
            }
        }

        public async Task<List<BusinessCls.News>> ReadAll()
        {
            try
            {
                var entityNewsList = await _context.News.ToListAsync();
                return NewsMapper.ToBusinessList(entityNewsList);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all news.", ex);
            }
        }

        public async Task Update(BusinessCls.News news)
        {
            try
            {
                var newsEntity = NewsMapper.ToEntity(news);

                if (news.Id == Guid.Empty)
                {
                    news.Id = Guid.NewGuid();
                    await _context.News.AddAsync(newsEntity);
                }
                else
                {
                    _context.Entry(newsEntity).State = EntityState.Modified;
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating the news.", ex);
            }
        }
    }

}

