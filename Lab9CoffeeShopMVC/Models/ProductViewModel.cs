using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab9CoffeeShopMVC.Models
{
    public class ProductViewModel
    {
        [DisplayName("Product ID")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Product Name")]
        public string? Name { get; set; }

        [MaxLength(100)]
        [DisplayName("Product Description")]
        public string? Description { get; set; }

        [Required]
        [DisplayName("Price")]
        [DataType(DataType.Currency)]
        public double? Price { get; set; }

        [MaxLength(50)]
        [DisplayName("Category")]
        public string? Category { get; set; }
    }
}
