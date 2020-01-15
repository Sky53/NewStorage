using System;

namespace EFFPOSTGRESS.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string SKU { get; set; }
        public string NameProduct { get; set; }
        public decimal Cost { get; set; }
        public Order Order { get; set; }
        public bool IsDeleted { get; set; }
    }
}