using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Business
{
   public interface IProductService
    {
        public Task<int> AddProductAsync(Product product);

        public Task<Product> FindProductAsyncById(int id);

        public void UpdateProdctAsync(Product product);

        public Task<int> DeleteProductAsync(int id);

    }
}
