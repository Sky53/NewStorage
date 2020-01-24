using AutoMapper;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;

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
