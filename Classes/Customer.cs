using System.ComponentModel.DataAnnotations;

namespace GrusSidan.Classes
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string AlternateShippingAddress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // Navigation property for orders
        public virtual ICollection<Order> Orders { get; set; }
    }
}
