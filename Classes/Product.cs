using System.ComponentModel.DataAnnotations;

namespace GrusSidan.Classes
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int TonsToPurchase { get; set; }
        public string ImageUrl { get; set; }

        // Navigationsegenskaper
        public ICollection<ProductCategory> ProductCategories { get; set; }
        // Navigation property for orders
        public virtual ICollection<Order> Orders { get; set; }
    }
}
