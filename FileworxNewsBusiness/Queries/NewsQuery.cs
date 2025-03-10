using FileworxNews.Business.Models;
using FileworxNews.Business.Repos;

namespace FileworxNews.Business.Queries
{
    public class NewsQuery : ContentQuery
    {
        private readonly INewsQueryRepo _repo;
       
        public NewsQuery(INewsQueryRepo repo) => _repo = repo;
        
        //public  List<News> Run()
        //{
        //    _repo.Run(this);
        //} 

    }
}
