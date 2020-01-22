using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Business
{
   public interface IProductService
    {
        public string AddProduct(Product product);
        public List<Product> GetProducts();
        public Product GetProduct();
    }
}
