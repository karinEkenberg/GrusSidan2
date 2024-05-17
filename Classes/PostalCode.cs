using GrusSidan.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
} // Här finns den stängande kringlan som avslutar definitionen av PostalCode-klassen
