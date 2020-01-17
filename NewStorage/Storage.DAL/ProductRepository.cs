using Microsoft.EntityFrameworkCore;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Storage.DAL
{

   public class ProductRepository : IProductRepository
    {
        private StorageContext _storageContext;
        public  ProductRepository(StorageContext storageContext)
        {
            _storageContext = storageContext;
        }

        public List<Product> GetAllProducts()
        {
            return _storageContext.Products.Include(u => u.Name).ToList();
        }

        public void SaveProduct(string name, string price)
        {
            Product product = new Product();
            product.Name = name;
            product.Price = decimal.Parse(price);
            _storageContext.Products.Add(product);
        }
    }
}
