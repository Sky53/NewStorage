using Microsoft.EntityFrameworkCore;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.DAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly StorageContext _context;

        public ProductRepository(StorageContext context)
        {
            _context = context;
        }

        public async Task<int> SaveAsync(Product product)
        {
            if (product == null)
            {
                throw new NotImplementedException();
            }

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
           
            return product.id;
        }
    }
}
