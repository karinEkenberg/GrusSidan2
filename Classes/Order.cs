using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrusSidan.Classes
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        // Foreign keys
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        // Navigation properties
        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
