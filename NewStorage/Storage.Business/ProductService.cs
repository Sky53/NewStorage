using AutoMapper;
using Storage.Business.DTO;
using Storage.DAL.Repository;
using Storage.Domain;
using System.Threading.Tasks;

namespace Storage.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public async Task<int> AddProductAsync(ProductRequest productRequest)
        {
            var product = _mapper.Map<Product>(productRequest);

            return await _productRepository.SaveAsync(product);
        }

        public async Task<int> DeleteProductAsync(int id)
        {
            return await _productRepository.DeleteAsync(id);
        }

        public async Task<ProductResponse> FindProductAsyncById(int id)
        {
            var product = await _productRepository.FindByIdAsync(id);

            return _mapper.Map<ProductResponse>(product);
        }

        public void UpdateProdctAsync(ProductRequest productRequest)
        {
            var product = _mapper.Map<Product>(productRequest);
            _productRepository.UpdateAsync(product);
        }
    }
}
