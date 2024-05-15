using System.ComponentModel.DataAnnotations;

namespace GrusSidan.Classes
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }

        // Navigationsegenskaper
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
