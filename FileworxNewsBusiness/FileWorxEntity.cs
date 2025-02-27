using System.ComponentModel.DataAnnotations;


namespace FileworxNewsBusiness
{
    public class FileWorxEntity
    {
        // 
        public Guid Id { get; protected set; }

        public DateTime CreationDate { get; protected set; }

        public Guid? LastModifierId { get; set; }

        public DateTime LastModificationDate { get; set; }

        public Guid? CreatorId { get; set; }

        public string Name { get; set; }

        public AppUser LastModifier { get; set; }
        public AppUser Creator { get; set; }

        public FileWorxEntity()
        {
            //Id = Guid.NewGuid();
            //Date = DateTime.Now;
        }

        public FileWorxEntity(Guid guidValue)
        {
            this.Id = guidValue;
        }

        public virtual void Update()
        {
                using (var context = new Context())
                {
                    try
                    {
                        if (Id==Guid.Empty)
                        {
                            Id = new Guid();
                            context.Entity.Add(this);
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

        public virtual void Delete()
        {
            using (var context = new Context())
            {
                try
                {
                    context.Entity.Remove(this);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting entity.", ex);
                }
            }
        }

        public  virtual FileWorxEntity Read()
        {
            using (var context = new Context())
            {
                return context.Entity.SingleOrDefault(x => x.Id == this.Id);
            }
        }
    }
}
