using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.DAL.Repository
{
   public interface IProductRepository
    {
        public Task<int> SaveAsync(Product product);

        public Task<Product> FindByIdAsync(int id);

        public void UpdateAsync(Product product);

        public Task<int> DeleteAsync(int id);

    }
}
