using Storage.DAL.Exception;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task DeleteAsync(int id)
        {
            var productDelete = new Product()
            {
                id = id
            };

            _context.Products.Remove(productDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public  List<Product> GetProducts()
        {
            return  _context.Products.ToList();
        }

        public async Task<int> SaveAsync(Product product)
        {
            if (product == null)
            {
                throw new StorageException("received an empty object");
            }

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product.id;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            if (product == null)
            {
                throw new StorageException("received an empty object");
            }

            _context.Products.Update(product);

            await _context.SaveChangesAsync();

            return product;
        }
    }
}
