﻿using Microsoft.AspNetCore.Mvc;
using Storage.Business;
using Storage.Business.DTO;
using System.Threading.Tasks;

namespace Storage.API.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<int> AddProduct([FromBody]ProductRequest  productRequest)
        {
            return await _productService.AddProductAsync(productRequest);
        }
    }
}
