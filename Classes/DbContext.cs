using Microsoft.EntityFrameworkCore;

namespace GrusSidan.Classes
{
    public class DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Items { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<PostalCode> PostalCode { get; set; }
    }
}
