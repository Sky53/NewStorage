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

        public async Task<int> AddProductAsync(ProductRequest productRequest)
        {
            var product = _mapper.Map<Product>(productRequest);
            return await _productRepository.SaveAsync(product);
        }

    }
}
