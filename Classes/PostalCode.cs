using System.ComponentModel.DataAnnotations;

namespace GrusSidan.Classes
{
    public class PostalCode
    {
        [Key]
        public int PostalCodeId { get; set; }

        public string Code { get; set; }
        public string Location { get; set; }

        // Navigation property for customers
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
