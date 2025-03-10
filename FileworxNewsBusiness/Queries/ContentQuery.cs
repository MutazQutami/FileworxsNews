using FileworxNews.Business.Models;
using FileworxNews.Business.Repos;



namespace FileworxNews.Business.Queries
{
    public class ContentQuery : FileworxEntityQuery
    {
        private IContentQueryRepo _repo;

        public ContentQuery() { }

        public ContentQuery(IContentQueryRepo repo) 
        {
           _repo = repo;
        }
       
        public StringFilter QDescription = new StringFilter();

        public StringFilter QBody = new StringFilter();
        
        public virtual List<Content> Run()
        {
            return _repo.Run(this);
        }
    }
}
