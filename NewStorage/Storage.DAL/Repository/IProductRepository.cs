using Storage.Domain;
using System.Threading.Tasks;

namespace Storage.DAL.Repository
{
   public interface IProductRepository
    {
        public Task<int> SaveAsync(Product product);

        public Task<Product> FindByIdAsync(int id);

        public Task<Product> UpdateAsync(Product product);

        public Task DeleteAsync(int id);

    }
}
