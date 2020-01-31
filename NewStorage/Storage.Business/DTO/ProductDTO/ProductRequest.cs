using System.ComponentModel.DataAnnotations;

namespace Storage.Business.DTO.ProductDTO
{
    public class ProductRequest
    {
        [Required]
        public string SKU { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
