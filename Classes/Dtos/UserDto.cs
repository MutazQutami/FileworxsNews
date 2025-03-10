namespace FileworxNews.Shared.Dtos
{
    public class UserDto:EntityDto
    {
        public string LogInName { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
