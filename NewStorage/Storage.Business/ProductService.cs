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
            if (product != null) {
                _productRepository.Save(product);
                return "Ok, product successfully added";
            }
            else
            {
                return "unsuccessfully";
            }
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
