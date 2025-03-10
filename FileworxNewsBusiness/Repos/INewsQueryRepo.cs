using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileworxNews.Business.Models;
using FileworxNews.Business.Queries;

namespace FileworxNews.Business.Repos
{
    public interface INewsQueryRepo
    {
        public List<News> Run(NewsQuery queryObject);
    }
   
}
