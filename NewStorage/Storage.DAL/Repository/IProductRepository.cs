using Storage.Domain;
using System.Threading.Tasks;

namespace Storage.DAL.Repository
{
   public interface IProductRepository
    {
        public Task<int> SaveAsync(Product product);

        public Task<Product> FindByIdAsync(int id);

        public Task<int> UpdateAsync(Product product);

        public Task<int> DeleteAsync(int id);

    }
}
