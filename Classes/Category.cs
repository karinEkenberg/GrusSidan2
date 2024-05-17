using System.ComponentModel.DataAnnotations;

namespace GrusSidan.Classes
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        // Navigation property
        public virtual ICollection<Product> Products { get; set; }
    }
}
