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
        private  readonly StorageContext _context;
        public ProductRepository(StorageContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public string Save(Product product)
        {
            if (product != null)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return product.ToString();
            } else
            {
                throw new NotImplementedException();
            }
        }
    }
}
