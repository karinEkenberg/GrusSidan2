using GrusSidan.Classes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cart
{
    [Key]
    public int CartID { get; set; }
    public int CustomerID { get; set; }

    // Navigation property
    [ForeignKey("CustomerID")]
    public virtual Customer Customer { get; set; }
    public virtual ICollection<CartItem> CartItems { get; set; }
}


