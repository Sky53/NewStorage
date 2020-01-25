using Storage.DAL.Repository;
using Storage.Domain;
using System.Threading.Tasks;

namespace Storage.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> AddProductAsync(Product product)
        {
            return await _productRepository.SaveAsync(product);
        }

        public async Task<int> DeleteProductAsync(int id)
        {
            return await _productRepository.DeleteAsync(id);
        }

        public async Task<Product> FindProductAsyncById(int id)
        {
            return await _productRepository.FindByIdAsync(id);
        }

        public async void UpdateProdctAsync(Product product)
        {
             _productRepository.UpdateAsync(product);
        }
    }
}
