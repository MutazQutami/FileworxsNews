using System.ComponentModel.DataAnnotations;

namespace FileworxNewsBusiness;

public class Photo : Content
{
    public string PhotoPath { get; set; }

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
                    context.Photo.Add(this);
                }
                else
                {
                    context.Entry(this).CurrentValues.SetValues(this);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public override void Delete()
    {
        using (var context = new Context())
        {
            try
            {
                context.Photo.Remove(this);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting photo.", ex);
            }
        }
    }

    public override Photo Read()
    {
        using (var context = new Context())
        {
            return context.Photo.SingleOrDefault(x => x.Id == this.Id);
        }
    }

    private void Validate()
    { 
        if (string.IsNullOrEmpty(PhotoPath))
            throw new ValidationException("PhotoPath cannot be empty.");
    }
}
