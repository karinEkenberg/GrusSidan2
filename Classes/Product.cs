using System.ComponentModel.DataAnnotations;

namespace GrusSidan.Classes
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int TonsToPurchase { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }

        // Navigation property
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
