using Microsoft.EntityFrameworkCore;

namespace GrusSidan.Classes
{
    public class GrusDbContext : DbContext
    {
        //public GrusDbContext(DbContextOptions<GrusDbContext> options) : base(options)
        //{


        //public DbSet<Product> Products { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<ProductCategory> ProductCategories { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> Items { get; set; }
        //public DbSet<Customer> customers { get; set; }
        //public DbSet<PostalCode> PostalCode { get; set; }

    

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Definiera förmedlingstabellens primärnycklar
        //    modelBuilder.Entity<ProductCategory>()
        //        .HasKey(pc => new { pc.ProductID, pc.CategoryID });

        //    // Konfigurera relationen mellan Product och ProductCategory
        //    modelBuilder.Entity<ProductCategory>()
        //        .HasOne(pc => pc.Product)
        //        .WithMany(p => p.ProductCategories)
        //        .HasForeignKey(pc => pc.ProductID);

        //    // Konfigurera relationen mellan Category och ProductCategory
        //    modelBuilder.Entity<ProductCategory>()
        //        .HasOne(pc => pc.Category)
        //        .WithMany(c => c.ProductCategories)
        //        .HasForeignKey(pc => pc.CategoryID);
        //}
    }

    
}
