using System.ComponentModel.DataAnnotations;

namespace Storage.Business.Products.DTO
{
    public class ProductResponse
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string SKU { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
