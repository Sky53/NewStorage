using System;

namespace Storage.Domain
{
    public class OrderProduct
    {
        public int OrderNumber { get; set; }
        public Order Order { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
