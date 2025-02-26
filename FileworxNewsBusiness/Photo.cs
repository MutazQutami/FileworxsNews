using System.ComponentModel.DataAnnotations;

namespace FileworxNewsBusiness;
public class Photo : Content
{
    public string PhotoPath { get; set; }
    public new void Update()
    {
        Validate();

        using (var context = new Context())
        {
            try
            {
                var photo = context.Photos.FirstOrDefault(x => x.Id == this.Id);
                if (photo == null)
                {
                    context.Photos.Add(this);
                }
                else
                {
                    context.Entry(photo).CurrentValues.SetValues(this);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating photo.", ex);
            }
        }
    }
    public new void Delete()
    {
        using (var context = new Context())
        {
            try
            {
                var photo = context.Photos.FirstOrDefault(x => x.Id == this.Id);
                if (photo != null)
                {
                    context.Photos.Remove(photo);
                    context.Contents.Remove(photo);
                    context.Entities.Remove(photo);

                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Photo not found for deletion.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting photo.", ex); // Rethrow the exception
            }
        }
    }
    public new Photo Read()
    {
        using (var context = new Context())
        {
            return context.Photos.FirstOrDefault(x => x.Id == this.Id);
        }
    }
    protected void Validate()
    {
        if (string.IsNullOrEmpty(PhotoPath))
            throw new ValidationException("PhotoPath cannot be empty.");
    }
}