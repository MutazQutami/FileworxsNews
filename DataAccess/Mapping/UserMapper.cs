using FileworxNews.DataAccess.Entities;
using BusinessCls = FileworxNews.Business.Models;

namespace FileworxNews.DataAccess.Mapping
{
    public class UserMapper
    {
        public static BusinessCls.User ToBusiness(User user)
        {
            return new BusinessCls.User()
            {
                Id = user.Id,
                CreatorId = user.CreatorId,
                LastModifierId = user.LastModifierId,
                LastModificationDate = user.LastModificationDate,
                CreationDate = user.CreationDate,
                Name = user.Name,
                LogInName=user.LogInName,
                Password = user.Password,
                IsAdmin = user.IsAdmin,
            };
        }
        public static User ToEntity(BusinessCls.User businessUser)
        {
            return new User()
            {
                Id = businessUser.Id,
                CreatorId = businessUser.CreatorId,
                LastModifierId = businessUser.LastModifierId,
                LastModificationDate = businessUser.LastModificationDate,
                CreationDate = businessUser.CreationDate,
                Name = businessUser.Name,
                LogInName = businessUser.LogInName,
                Password = businessUser.Password,
                IsAdmin = businessUser.IsAdmin,
            };
        }
        public static List<BusinessCls.User> ToBusinessList(List<User> users)
        {
            return users.Select(user => ToBusiness(user)).ToList();
        }
        public static List<User> ToEntityList(List<BusinessCls.User> businessUsers)
        {
            return businessUsers.Select(businessUser => ToEntity(businessUser)).ToList();
        }
    }
}
