using Storage.DAL.Repository;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Business
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void AddProduct(string name, string price)
        {
            _productRepository.Save(name, price);
        }

        public List<Product> GetProducts()
        {
            return null; 
        }
    }
}
