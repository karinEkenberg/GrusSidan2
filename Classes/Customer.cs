using GrusSidan.Classes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrusSidan.Classes
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string AlternativeAddress { get; set; }
        public int PostalCodeID { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        // Navigation property
        [ForeignKey("PostalCodeID")]
        public virtual PostalCode PostalCode { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
