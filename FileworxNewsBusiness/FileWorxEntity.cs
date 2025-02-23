using System.ComponentModel.DataAnnotations;


namespace FileworxNewsBusiness
{
    public class FileWorxEntity
    {
        [Key]
        public Guid GuidValue { get; set; }
        public DateTime Date { get; set; }
        public FileWorxEntity()
        {
            GuidValue = Guid.NewGuid();
            Date = DateTime.Now;
        }
    }
}
