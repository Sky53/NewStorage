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

        public async Task<int> AddProductAsync(ProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            return await _productRepository.SaveAsync(product);
        }

        public async Task<int> DeleteProductAsync(int id)
        {
            return await _productRepository.DeleteAsync(id);
        }

        public async Task<ProductDTO> FindProductAsyncById(int id)
        {
            var product = await _productRepository.FindByIdAsync(id);

            return _mapper.Map<ProductDTO>(product);
        }

        public  void UpdateProdctAsync(ProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
             _productRepository.UpdateAsync(product);
        }
    }
}
