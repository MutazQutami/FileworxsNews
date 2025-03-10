namespace FileworxNews.DataAccess.Entities
{
    public class User :FileworxEntity
    {
        public string LogInName { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public ICollection<FileworxEntity> CreatedEntities { get; set; }

        public ICollection<FileworxEntity> ModifiedEntities { get; set; }
    }
}
