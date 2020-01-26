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
        /**
         * Искал информацию по асинхронному удалению. Есть пакет EntityFramework.Extended, нужен ли он в этой задачи?
         */
        public async Task<int> DeleteAsync(int id)
        {
            var productDelete = await _context.Products.FindAsync(id);
            if (productDelete != null)
            {

                var product = _context.Products.Remove(productDelete);
                await _context.SaveChangesAsync();
                return product.Entity.id;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public async Task<Product> FindByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<int> SaveAsync(Product product)
        {
            if (product != null)
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
                return product.id;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async void UpdateAsync(Product product)
        {
            if (product != null)
            {
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
