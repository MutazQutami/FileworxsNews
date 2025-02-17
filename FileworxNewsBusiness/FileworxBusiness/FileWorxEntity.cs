namespace FileworxBusiness
{
    public class FileWorxEntity
    {
        public Guid GuidValue { get; set; }
        public DateTime Date { get; set; }
        public FileWorxEntity()
        {
            GuidValue = Guid.NewGuid();
            Date = DateTime.Now;
        }
    }
}
