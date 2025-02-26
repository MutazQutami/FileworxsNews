using System.ComponentModel.DataAnnotations;


namespace FileworxNewsBusiness
{
    public class FileWorxEntity
    {
        [Key]
        public Guid Id { get; private set; }
        public DateTime Date { get; private set; }
        public Guid LastModifierId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid CreatorId { get; set; }
        public FileWorxEntity()
        {
            Id = Guid.NewGuid();
            Date = DateTime.Now;
        }
        public FileWorxEntity(Guid guidValue)
        {
            this.Id = guidValue;
        }
        public void Update()
        {
            using (var context = new Context())
            {
                try
                {
                    var entity = context.Entities.SingleOrDefault(x => x.Id == this.Id);
                    if (entity == null)
                    {
                        context.Entities.Add(this);
                    }
                    else
                    {
                        context.Entry(entity).CurrentValues.SetValues(this);
                    }

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating entity.", ex);
                }
            }
        }
        public void Delete()
        {
            using (var context = new Context())
            {
                try
                {
                    var entity = context.Entities.SingleOrDefault(x => x.Id == this.Id);

                    if (entity != null)
                    {
                        context.Entities.Remove(entity);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Entity not found for deletion.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting entity.", ex);
                }
            }
        }
        public FileWorxEntity Read()
        {
            using (var context = new Context())
            {
                return context.Entities.SingleOrDefault(x => x.Id == this.Id);
            }
        }
    }
}
