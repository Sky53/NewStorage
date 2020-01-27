using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Storage.Business;
using Storage.Business.DTO;
using Storage.Domain;
﻿using Microsoft.AspNetCore.Mvc;
using Storage.Business;
using Storage.Business.DTO;
using System.Threading.Tasks;

namespace Storage.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<int> AddProduct([FromBody]ProductDTO  productDTO)
        {
            return await _productService.AddProductAsync(productDTO);
        }

        [HttpGet("{id:int}")]
        public async Task<ProductDTO> GetProductById(int id)
        {
            return await _productService.FindProductAsyncById(id);
        }

        [HttpPut]
        public  void UpdateProduct([FromBody]ProductDTO productDTO)
        {
 
            _productService.UpdateProdctAsync(productDTO);
        }

        [HttpDelete("{id:int}")]
        public async Task<int> DeleteProduct(int id)
        {
            return await _productService.DeleteProductAsync(id);

        }
    }
}
