using FileworxNews.Business.Models;
using FileworxNews.Shared.Dtos;

namespace FileworxNews.WebApi.Mapping
{
    public class UserMapper
    {
        public static UserDto ToDto(User user)
        {
            return new UserDto()
            {
                Id = user.Id,
                CreatorId = user.CreatorId,
                LastModifierId = user.LastModifierId,
                LastModificationDate = user.LastModificationDate,
                CreationDate = user.CreationDate,
                Name = user.Name,
                LogInName = user.LogInName,
                Password = user.Password,
                IsAdmin = user.IsAdmin,
            };
        }

        public static User ToEntity(UserDto userDto)
        {
            return new User()
            {
                Id = userDto.Id,
                CreatorId = userDto.CreatorId,
                LastModifierId = userDto.LastModifierId,
                LastModificationDate = userDto.LastModificationDate,
                CreationDate = userDto.CreationDate,
                Name = userDto.Name,
                LogInName = userDto.LogInName,
                Password = userDto.Password,
                IsAdmin = userDto.IsAdmin,
            };
        }
    }
}
