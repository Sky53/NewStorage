using AutoMapper;
using Storage.Domain;

namespace Storage.Business.DTO
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();

            
        }
    }
}
