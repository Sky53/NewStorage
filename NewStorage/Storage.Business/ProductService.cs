using Storage.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Business
{
    public class ProductService : IProductService
    {
        private ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void AddProduct(string name, string price)
        {
            _productRepository.Save(name, price);
            throw new NotImplementedException();
        }
    }
}
