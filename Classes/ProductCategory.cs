using System.ComponentModel.DataAnnotations;

namespace GrusSidan.Classes
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryID { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }

        // Navigationsegenskaper
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
