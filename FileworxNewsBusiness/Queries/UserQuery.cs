using FileworxNews.Business.Models;
using FileworxNews.Business.Repos;

namespace FileworxNews.Business.Queries
{
    public class UserQuery :FileworxEntityQuery
    {
        private IUserQueryRepo _repo;

        public StringFilter QLogInName = new StringFilter();

        public StringFilter QPassword = new StringFilter();

        public bool? QIsAdmin;

        public UserQuery(IUserQueryRepo repo)
        {
            _repo = repo;
        }

        public List<User> Run()
        {
            return _repo.Run(this);
        }
    }
}