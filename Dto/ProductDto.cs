using System.ComponentModel.DataAnnotations;

namespace Warehouse.API.Models
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; } // COD
    }
}
