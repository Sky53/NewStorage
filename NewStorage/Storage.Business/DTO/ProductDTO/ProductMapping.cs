using AutoMapper;
using Storage.Domain;

namespace Storage.Business.DTO.ProductDTO
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<ProductRequest, Product>();
            CreateMap<Product, ProductResponse>();
        }
    }
}
