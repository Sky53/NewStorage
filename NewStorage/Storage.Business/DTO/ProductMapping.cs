using AutoMapper;
using Storage.Domain;

namespace Storage.Business.DTO
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
