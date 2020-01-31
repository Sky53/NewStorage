using Storage.Business.DTO;
using System.Threading.Tasks;

namespace Storage.Business
{
    public interface IProductService
    {
        public Task<int> AddAsync(ProductRequest productRequest);

        public Task<ProductResponse> GetByIdAsync(int id);

        public Task<ProductResponse> UpdateAsync(int id, ProductRequest productRequest);

        public Task DeleteAsync(int id);
    }
}
