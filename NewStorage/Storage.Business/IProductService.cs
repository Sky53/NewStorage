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
        public Task<int> AddProductAsync(ProductDTO productDTO);

        public Task<ProductDTO> FindProductAsyncById(int id);

        public void UpdateProdctAsync(ProductDTO productDTO);

        public Task<int> DeleteProductAsync(int id);

    }
}
