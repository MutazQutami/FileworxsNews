using System.ComponentModel.DataAnnotations;

namespace FileworxNewsBusiness;
public class News : Content
{
    public string Category { get; set; }
    public new void Update()
    {
        Validate();

        using (var context = new Context())
        {
            try
            {
                var news = context.News.SingleOrDefault(x => x.Id == this.Id);
                if (news == null)
                {
                    context.News.Add(this);
                }
                else
                {
                    context.Entry(news).CurrentValues.SetValues(this);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating news.", ex); // Rethrow the exception
            }
        }
    }
    public new void Delete()
    {
        using (var context = new Context())
        {
            try
            {
                var news = context.News.SingleOrDefault(x => x.Id == this.Id);
                if (news != null)
                {
                    context.News.Remove(news);
                    context.Contents.Remove(news);
                    context.Entities.Remove(news);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("News not found for deletion.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting news.", ex);
            }
        }
    }
    public new News Read()
    {
        using (var context = new Context())
        {
            return context.News.SingleOrDefault(x => x.Id == this.Id);
        }
    }
    private void Validate()
    {

        if (string.IsNullOrEmpty(Category))
            throw new ValidationException("Category cannot be empty.");
    }
}