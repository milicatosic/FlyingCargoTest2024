using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = null!;
        public DbSet<Category> Category { get; set; } = null!;
        public DbSet<ProductCategories> ProductCategories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategories>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId });
        }
    }
}
