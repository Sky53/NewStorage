using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Storage.Domain
{
    public class Product
    {
        [Key]
        public Guid id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<OrderProduct> OrderProduct { get; set; }
        public bool IsDeleted { get; set; }
    }
}
