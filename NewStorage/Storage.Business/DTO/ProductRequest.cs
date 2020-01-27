
using System.ComponentModel.DataAnnotations;

namespace Storage.Business.DTO
{
    public class ProductRequest
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
