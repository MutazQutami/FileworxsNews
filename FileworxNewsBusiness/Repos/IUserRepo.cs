using FileworxNews.Business.Models;

namespace FileworxNews.Business.Repos
{
    public interface IUserRepo
    {
        Task Update(User user);

        Task Delete(User user);

        Task<User> Read(User user);

        Task<List<User>> ReadAll();
    }
}
