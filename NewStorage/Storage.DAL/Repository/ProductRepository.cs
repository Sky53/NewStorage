using Storage.Domain;
using System;
using System.Collections.Generic;
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
        public void Save(string name, string price)
        {
            Product product = new Product();
            product.Name = name;
            product.Price = decimal.Parse(price);
            _context.Products.Add(product);

        }
    }
}
