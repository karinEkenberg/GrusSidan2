using System;

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


