using System.ComponentModel.DataAnnotations;

namespace FileworxNewsBusiness;
public class Content : FileWorxEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Body { get; set; }
    public new void Update()
    {
        Validate();

        using (var context = new Context())
        {
            try
            {
                var content = context.Contents.SingleOrDefault(x => x.Id == this.Id);

                if (content == null)
                {
                    context.Contents.Add(this);
                }
                else
                {
                    context.Entry(content).CurrentValues.SetValues(this);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating content: {ex.Message}");
                throw new Exception("Error updating content.", ex); // Rethrow the exception
            }
        }
    }
    public new void Delete()
    {
        using (var context = new Context())
        {
            try
            {
                var content = context.Contents.SingleOrDefault(x => x.Id == this.Id);
                if (content != null)
                {
                    context.Contents.Remove(content);
                    context.Entities.Remove(content);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Content not found for deletion.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting content: {ex.Message}");
                throw new Exception("Error deleting content.", ex); // Rethrow the exception
            }
        }
    }
    public new Content Read()
    {
        using (var context = new Context())
        {
            return context.Contents.SingleOrDefault(x => x.Id == this.Id);
        }
    }
    private void Validate()
    {
        if (string.IsNullOrEmpty(Name))
            throw new ValidationException("Title cannot be empty.");

        if (string.IsNullOrEmpty(Description))
            throw new ValidationException("Description cannot be empty.");

        if (string.IsNullOrEmpty(Body))
            throw new ValidationException("Body cannot be empty.");
    }
}
