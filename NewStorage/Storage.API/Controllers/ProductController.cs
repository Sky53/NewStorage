using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Storage.Business;
using Storage.Business.DTO;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<int> AddProduct([FromBody]ProductDTO  productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            return await _productService.AddProductAsync(product);
        }

    }
}
