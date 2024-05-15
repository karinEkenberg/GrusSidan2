using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GrusSidan.Classes
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        // Foreign key
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        // Foreign key
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Navigation properties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
