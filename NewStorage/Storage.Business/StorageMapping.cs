using AutoMapper;
using Storage.Business.Products.DTO;
using Storage.Domain;

namespace Storage.Business
{
    public class StorageMapping : Profile
    {
        public StorageMapping()
        {
            CreateMap<ProductRequest, Product>();
            CreateMap<Product, ProductResponse>();
        }
    }
}
