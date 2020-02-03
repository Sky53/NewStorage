using AutoMapper;
using Storage.Business.Products.DTO;
using Storage.Business.Users.DTO;
using Storage.Domain;

namespace Storage.Business
{
    public class StorageMapping : Profile
    {
        public StorageMapping()
        {
            CreateMap<ProductRequest, Product>();
            CreateMap<Product, ProductResponse>();

            CreateMap<UserRequest, User>();
            CreateMap<User, UserResponse>();
        }
    }
}
