namespace FileworxNewsBusiness;
public class Content : FileWorxEntity
{
    public Guid LastModifierId { get; set; }
    public DateTime LastmodificationDate { get; set; }
    public Guid CreatorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Body { get; set; }
}
