using FileworxNewsBusiness;
using Microsoft.EntityFrameworkCore;

namespace FilworxNewsDataAccess
{
    public class FileWorxContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<AppUser> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\MSSQLLocalDB;Initial catalog=FileworxNews");
          
        }
    }
}
