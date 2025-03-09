namespace FileworxNews.Shared.Models
{
    public class FileWorxEntityDto
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }

        public Guid? LastModifierId { get; set; }

        public DateTime LastModificationDate { get; set; }

        public Guid? CreatorId { get; set; }

        public string Name { get; set; }

    }
}




