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
    public class NewsRepo : INewsRepo
    {
        private readonly FileworxDbContext _context;

        public NewsRepo(FileworxDbContext context)
        {
            _context = context;
        }

        public async Task Delete(News news)
        {
            try
            {
           
                _context.News.Remove(news);
                await _context.SaveChangesAsync(); 
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting the news.", ex);
            }
        }

        public async Task<News> Read(News news)
        {
            try
            {
                return await _context.News.FindAsync(news.Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading the news.", ex);
            }
        }

        public async Task<List<News>> ReadAll()
        {
            try
            {
               
                return await _context.News.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all news.", ex);
            }
        }

        public async Task Update(News news)
        {
            try
            {
            
                if (news.Id == Guid.Empty)
                {
                    news.Id = Guid.NewGuid(); 
                    await _context.News.AddAsync(news); 
                }
                else
                {
                    _context.Entry(news).State = EntityState.Modified;
                    _context.Entry(news).CurrentValues.SetValues(news); 
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

