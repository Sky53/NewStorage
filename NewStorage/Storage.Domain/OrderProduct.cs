using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Domain
{
    public class OrderProduct
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
