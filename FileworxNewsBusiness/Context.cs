using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
namespace  FileworxNewsBusiness
{
    public class Context : DbContext
    {
        public DbSet<FileWorxEntity> Entities { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<AppUser> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MUTAZ-Q;Initial Catalog=Test1;Integrated Security=True;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPT mapping
            modelBuilder.Entity<FileWorxEntity>().UseTptMappingStrategy();

            modelBuilder.Entity<AppUser>()
            .HasIndex(u => u.LogInName)
             .IsUnique();

            modelBuilder.Entity<AppUser>()
            .HasIndex(u => u.LastModifier)
            .IsUnique(false);

            modelBuilder.Entity<Content>()
            .HasIndex(u=>u.CreatorId).IsUnique(false);
            
            modelBuilder.Entity<Content>()
            .HasIndex(u=>u.LastModifierId).IsUnique(false);


            //TPC MAPPING
            //modelBuilder.Entity<FileWorxEntity>().UseTpcMappingStrategy();
        }
    }
}
