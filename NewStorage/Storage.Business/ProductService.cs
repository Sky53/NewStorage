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

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public string AddProduct(Product product)
        {
            return _productRepository.Save(product);
        }

        public Product GetProduct()
        {
            Product product = new Product();
            product.Name = "MyName";
            product.Price = 92.67m;
            return product;
        }

        public List<Product> GetProducts()
        {
            return new List<Product>(); 
        }
    }
}
