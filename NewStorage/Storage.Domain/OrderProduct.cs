using System;

namespace Storage.Domain
{
    public class OrderProduct
    {
        public int OrderNumber { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
