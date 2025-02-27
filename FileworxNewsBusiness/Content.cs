using System.ComponentModel.DataAnnotations;

namespace FileworxNewsBusiness;
public class Content : FileWorxEntity
{
    public string Description { get; set; }

    public string Body { get; set; }

    public override void Update()
    {
        Validate();

        using (var context = new Context())
        {
            try
            {
                if (Id.Equals(null))
                {
                    Id = Guid.NewGuid();
                    context.Content.Add(this);
                }
                else
                {
                    context.Entry(this).CurrentValues.SetValues(this);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating entity.", ex);
            }
        }
    }

    public override void Delete()
    {
        using (var context = new Context())
        {
            try
            {
                context.Content.Remove(this);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting entity.", ex);
            }
        }
    }

    public override Content Read()
    {
        using (var context = new Context())
        {
            return context.Content.SingleOrDefault(x => x.Id == this.Id);
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

