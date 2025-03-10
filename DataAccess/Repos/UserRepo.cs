using BusinessCls = FileworxNews.Business.Models;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using FileworxNews.DataAccess.Mapping;
using FileworxNews.DataAccess.Entities;

namespace FileworxNews.DataAccess.Repos
{
    public class UserRepo : IUserRepo
    {
        private FileworxDbContext _context;

        public UserRepo(FileworxDbContext context)
        {
            _context = context;
        }

        public async Task Delete(BusinessCls.User user)
        {
            if (user.LastModifierId != null)
            {
                user.LastModifierId = null;
                user.CreatorId = null;
                await Update(user);
            }

            try
            {
                var userEntity = UserMapper.ToEntity(user);
                _context.User.Remove(userEntity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting User.", ex);
            }
        }

        public async Task<BusinessCls.User> Read(BusinessCls.User user)
        {
            try
            {
                var userEntity = await _context.User.FindAsync(user.Id);
                if (userEntity == null)
                {
                    throw new Exception("User not found.");
                }
                return UserMapper.ToBusiness(userEntity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading User.", ex);
            }
        }

        public async Task<List<BusinessCls.User>> ReadAll()
        {
            try
            {
                var userEntities = await _context.User.ToListAsync();
                return UserMapper.ToBusinessList(userEntities);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all Users.", ex);
            }
        }

        public async Task Update(BusinessCls.User user)
        {
            try
            {
                if (_context.User.Any(x => x.LogInName == user.LogInName && x.Id != user.Id)) // Duplicate Login name
                {
                    throw new Exception("Invalid Login Name");
                }

                var userEntity = UserMapper.ToEntity(user);

                if (user.Id == Guid.Empty)
                {
                    InitializeNewUser(userEntity);
                    await _context.User.AddAsync(userEntity);
                    await _context.SaveChangesAsync(); // to avoid circular reference

                    userEntity.LastModifierId = userEntity.Id;
                    userEntity.CreatorId = userEntity.Id;
                    _context.User.Update(userEntity);
                }
                else
                {
                    userEntity.LastModificationDate = DateTime.Now;
                    _context.Entry(userEntity).State = EntityState.Modified;
                    _context.Entry(userEntity).CurrentValues.SetValues(userEntity);
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


