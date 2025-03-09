using FileworxNews.Shared;

namespace FileworxNews.WebApi.Mapping
{
    public class DtoUserMapping
    {

        public Business.Models.User map(UserDto dto)
        {
            return new Business.Models.User()
            {
                Id = new Guid(),
                Name = dto.Name,
                LogInName = dto.LogInName,
                Password = dto.Password,
                IsAdmin = dto.IsAdmin,
                LastModificationDate = DateTime.Now,
                LastModifierId = new Guid(),
                CreatorId = new Guid(),
            };
        }

    }
}
