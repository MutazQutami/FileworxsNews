using System;
using System.Collections.Generic;
using BusinessCls = FileworxNews.Business.Models;
using FileworxNews.Business.Models;
using FileworxNews.Business.Queries;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;

namespace FileworxNews.DataAccess.Repos
{
    public class NewsQueryRepo : ContentQueryRepo, INewsQueryRepo
    {
        private readonly FileworxDbContext _context;
        
        private NewsQuery _queryObj;

        public NewsQueryRepo(FileworxDbContext context)
            : base(context) => _context = context;

        public List<BusinessCls.News> Run(NewsQuery queryObject)
        {
            throw new NotImplementedException();
        }
    }
}
