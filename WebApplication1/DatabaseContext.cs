using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var book = modelBuilder.Entity<Book>();
            book.HasKey(_ => _.id);
            book.Property(_ => _.id).HasConversion(
                v => v.id,
                v => new BookId(v)
            );
        }

        public DbSet<Book> Books { get; [UsedImplicitly] private set; }
    }
}