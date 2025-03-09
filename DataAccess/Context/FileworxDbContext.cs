using FileworxNews.Business.Models;
using Microsoft.EntityFrameworkCore;
namespace FileworxNews.DataAccess.Context
{
    public class FileworxDbContext :DbContext
    {
        public FileworxDbContext(DbContextOptions<FileworxDbContext> options) : base(options) { }
        public DbSet<FileWorxEntity> Entity { get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPT mapping
            modelBuilder.Entity<FileWorxEntity>().UseTptMappingStrategy();

            // Business Table
            FileWorxEntityTable(modelBuilder);

            // Content Table
            ContentTable(modelBuilder);

            // User Table 
            UserTable(modelBuilder);

            // Photo Table
            PhotoTable(modelBuilder);

            // News Table
            NewsTable(modelBuilder);
        }

        private void FileWorxEntityTable(ModelBuilder modelBuilder)
        {
            // Id Primary key column
            modelBuilder.Entity<FileWorxEntity>()
                .HasKey(u => u.Id);

            // Creation date column
            modelBuilder.Entity<FileWorxEntity>()
                .Property(u => u.CreationDate)
                .HasColumnType("DATETIME2")
                .HasDefaultValueSql("SYSDATETIME()");

            // LastModification Date column
            modelBuilder.Entity<FileWorxEntity>()
                .Property(u => u.LastModificationDate)
                .HasColumnType("DATETIME2")
                .HasDefaultValueSql("SYSDATETIME()");

            // Creator id column 
            modelBuilder.Entity<FileWorxEntity>()
                .Property(u => u.CreatorId)
                .HasColumnType("uniqueidentifier")
                .IsRequired(false);
                

            // Last Modifier Id column
            modelBuilder.Entity<FileWorxEntity>()
                .Property(u => u.LastModifierId)
                .HasColumnType("uniqueidentifier")
                .IsRequired(false);

            // Creator Id Foreign key
            modelBuilder.Entity<FileWorxEntity>()
                .HasOne(u => u.Creator)
                .WithMany()
                .HasForeignKey(f => f.CreatorId)
                .OnDelete(DeleteBehavior.NoAction);

            //  Modifier Id Foreign key
            modelBuilder.Entity<FileWorxEntity>()
                .HasOne(f => f.LastModifier)
                .WithMany()
                .HasForeignKey(f => f.LastModifierId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        private void ContentTable(ModelBuilder modelBuilder)
        {
            // Description Column
            modelBuilder.Entity<Content>()
                .Property(u => u.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(255);

            // Body Column
            modelBuilder.Entity<Content>()
                .Property(u => u.Body)
                .HasColumnType("nvarchar(Max)");
        }

        private void UserTable(ModelBuilder modelBuilder)
        {
            // Inheriting FileWorxEntity's Id
            modelBuilder.Entity<User>()
                .HasBaseType<FileWorxEntity>();

            // Foreign key for created entities
            modelBuilder.Entity<User>()
                .HasMany(u => u.CreatedEntities)
                .WithOne(f => f.Creator)
                .HasForeignKey(f => f.CreatorId)
                .OnDelete(DeleteBehavior.NoAction);

            // Foreign key for modified entities
            modelBuilder.Entity<User>()
                .HasMany(u => u.ModifiedEntities)
                .WithOne(f => f.LastModifier)
                .HasForeignKey(f => f.LastModifierId)
                .OnDelete(DeleteBehavior.NoAction);

            // Login Name column
            modelBuilder.Entity<User>()
                .Property(u => u.LogInName)
                .HasMaxLength(255)
                .IsRequired();

            // Unique constraint for Login Name
            modelBuilder.Entity<User>()
                .HasIndex(u => u.LogInName)
                .IsUnique();

            // Password Column
            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .HasMaxLength(255)
                .IsRequired();

            // IsAdmin Column
            modelBuilder.Entity<User>()
                .Property(u => u.IsAdmin)
                .HasDefaultValue(false);
        }

        private void NewsTable(ModelBuilder modelBuilder)
        {

            // Category Column
            modelBuilder.Entity<News>()
                .Property(u => u.Category)
                .HasConversion<int>()
                .IsRequired();
        }

        private void PhotoTable(ModelBuilder modelBuilder)
        {

            // Photo Path Column
            modelBuilder.Entity<Photo>()
                .Property(u => u.PhotoPath)
                .HasColumnType("nvarchar(max)")
                .IsRequired();
        }
    }


}


