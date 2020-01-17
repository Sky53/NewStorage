using Storage.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Business
{
   public class ProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
