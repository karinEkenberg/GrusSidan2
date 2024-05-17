using GrusSidan.Classes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CartItem
{
    [Key]
    public int CartItemID { get; set; }
    public int CartID { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }

    // Navigation property
    [ForeignKey("CartID")]
    public virtual Cart Cart { get; set; }
    [ForeignKey("ProductID")]
    public virtual Product Product { get; set; }
}