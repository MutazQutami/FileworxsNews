namespace FileworxNews.DataAccess.Entities
{
    public class FileworxEntity
    {
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid? LastModifierId { get; set; }

        public DateTime LastModificationDate { get; set; }

        public Guid? CreatorId { get; set; }

        public string Name { get; set; }

        public User? LastModifier { get; set; }

        public User? Creator { get; set; }
    }
}
