using Storage.Business.DTO;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Business
{
   public interface IProductService
    {
        public Task<int> AddProductAsync(ProductRequest productRequest);

        public Task<ProductResponse> FindProductAsyncById(int id);

        public Task<int> UpdateProdctAsync(ProductRequest productRequest);

        public Task<int> DeleteProductAsync(int id);
    }
}
