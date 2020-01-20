using Microsoft.EntityFrameworkCore;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Storage.DAL.Repository
{
    public class ProductRepository : IProductRepository
    {
         private StorageContext _context;
        public ProductRepository(StorageContext context)
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.Include(u => u.Name).ToList();
        }

        public void Save(string name, string price)
        {
            Product product = new Product();
            product.Name = name;
            product.Price = decimal.Parse(price);
            _context.Products.Add(product);

        }
    }
}
