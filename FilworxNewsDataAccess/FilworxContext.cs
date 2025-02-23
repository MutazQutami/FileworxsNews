using FileworxNewsBusiness;
using Microsoft.EntityFrameworkCore;

namespace FilworxNewsDataAccess
{
    public class FilworxContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<AppUser> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MUTAZ-Q;Database=FileworxNews;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
