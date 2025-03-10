using FileworxNews.Business.Models;
using FileworxNews.Business.Queries;

namespace FileworxNews.Business.Repos
{
    public interface IUserQueryRepo
    {
        public List<User> Run(UserQuery queryObject);
    }
}
