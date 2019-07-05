using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web
{
    public class BookHubDbContext : DbContext
    {
        public DbSet<Literature> LiteratureSet { get; set; }
        public BookHubDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Literature>().HasKey(k => k.Id);
            modelBuilder.Entity<LiteratureCategory>().HasKey(k => k.Id);
            modelBuilder.Entity<Publication>().HasKey(k => k.Id);
        }
    }
}