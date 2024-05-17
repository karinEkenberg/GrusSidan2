using System.ComponentModel.DataAnnotations;

namespace GrusSidan.Classes
{
    public class PostalCode
    {
        [Key]
        public int PostalCodeID { get; set; }
        public string Location { get; set; }
        public int Code { get; set; }

        // Navigation property
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
}
