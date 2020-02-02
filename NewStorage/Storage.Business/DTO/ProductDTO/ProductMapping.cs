using AutoMapper;
using Storage.Business.DTO.UserDTO;
using Storage.Domain;

namespace Storage.Business.DTO.ProductDTO
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<ProductRequest, Product>();
            CreateMap<Product, ProductResponse>();

            CreateMap<UserRequest,User>();
            CreateMap<User, UserResponse>();
        }
    }
}
