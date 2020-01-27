using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Storage.Business.DTO
{
    public class ProductResponse
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
