using Storage.Domain;
using System;
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
            var productDelete = await _context.Products.FindAsync(id);

            if (productDelete == null)
            {
                throw new NotImplementedException();
            }

            var product = _context.Products.Remove(productDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
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

        public async Task<Product> UpdateAsync(Product product)
        {
            if (product == null)
            {
                throw new NotImplementedException();
            }

            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return product;
        }
    }
}
