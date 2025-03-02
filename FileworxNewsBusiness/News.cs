using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace FileworxNewsBusiness;
public class News : Content
{
    public enum CategoryTypes
    {
        General,
        Sports,
        Health,
        Politics
    }
    public CategoryTypes Category  { get; set; }  

    public override void Update()
    {
        Validate();

        using (var context = new Context())
        {
            try
            {
                if (Id==Guid.Empty)
                {
                    Id = Guid.NewGuid();
                    context.News.Add(this);
                }
                else
                {
                    context.Entry(this).State = EntityState.Modified;
                    context.Entry(this).CurrentValues.SetValues(this);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating news.", ex);
            }
        }
    }   
    
    public override void Delete()
    {
        using (var context = new Context())
        {
            try
            {
                context.News.Remove(this);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting news.", ex);
            }
        }
    }

    public override News Read()
    {
        using (var context = new Context())
        {
            return context.News.SingleOrDefault(x => x.Id == this.Id);
        }
    }

    private void Validate()
    {
        if (Category.Equals(null))
            throw new ValidationException("Category cannot be empty.");
    }
}
