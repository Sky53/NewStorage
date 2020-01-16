using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }
        public bool IsDeleted { get; set; }
    }
}
