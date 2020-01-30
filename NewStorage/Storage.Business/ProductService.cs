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

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<int> AddAsync(ProductRequest productRequest)
        {
            var product = _mapper.Map<Product>(productRequest);

            return await _productRepository.SaveAsync(product);
        }

        public async Task DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<ProductResponse> GetByIdAsync(int id)
        {
            var product = await _productRepository.FindByIdAsync(id);

            return _mapper.Map<ProductResponse>(product);
        }

        public async Task<ProductResponse> UpdateAsync(int id, ProductRequest productRequest)
        {
            var product = _mapper.Map<Product>(productRequest);
            product.id = id;

            await _productRepository.UpdateAsync(product);

            return _mapper.Map<ProductResponse>(product);
        }
    }
}
