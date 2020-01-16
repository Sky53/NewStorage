using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Domain
{
    public class OrderProduct
    {
        public int OrderNumber { get; set; }
        public Order Order { get; set; }

        public string ProductSKU { get; set; }
        public Product Product { get; set; }
    }
}
