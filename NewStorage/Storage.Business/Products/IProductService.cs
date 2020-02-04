using Storage.Business.Products.DTO;
using Storage.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Storage.Business.Products
{
    public interface IProductService
    {
        public Task<List<ProductResponse>> GetAllAsync();

        public Task<int> AddAsync(ProductRequest productRequest);

        public Task<ProductResponse> GetByIdAsync(int id);

        public Task<ProductResponse> UpdateAsync(int id, ProductRequest productRequest);

        public Task DeleteAsync(int id);
    }
}
