using FileworxNews.Business.Models;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace FileworxNews.DataAccess.Repos
{
    public class UserRepo : IUserRepo
    {
        private FileworxDbContext _context;
    
        public UserRepo(FileworxDbContext context)
        {
            _context = context;
        }
      
        public async Task Delete(User user)
        {
            if (user.LastModifierId != null)
            {
                user.LastModifierId = null;
                user.CreatorId = null;
                await Update(user);
            }

            try
            {
                _context.User.Remove(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting User.", ex);
            }
        
        }

        public async Task<User> Read(User user)
        {
            try
            {
                return await _context.User.FindAsync(user.Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading User.", ex);
            }
        }

        public async Task<List<User>> ReadAll()
        {
            try
            {
                return await _context.User.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all Users.", ex);
            }
        }

        public async Task Update(User user)
        {
            try
            {
                if (_context.User.Any(x => x.LogInName == user.LogInName && x.Id != user.Id)) // Duplicate Login name
                {
                    throw new Exception("Invalid Login Name");
                }
                if (user.Id == Guid.Empty)
                {
                    InitializeNewUser(user);

                    await _context.User.AddAsync(user);
                    await _context.SaveChangesAsync(); // to avoid circular  reference 

                    user.LastModifierId = user.Id;
                    user.CreatorId=user.Id;
                    _context.User.Update(user);
                }
                else
                {
                    user.LastModificationDate = DateTime.Now;
                    _context.Entry(user).State = EntityState.Modified;
                    _context.Entry(user).CurrentValues.SetValues(user);

                }
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void InitializeNewUser(User user)
        {
            user.Id = Guid.NewGuid();
            user.CreatorId = null;
            user.LastModifierId = null;
            user.CreationDate = DateTime.Now;
            user.LastModificationDate = DateTime.Now;
        }
     
    }
}
