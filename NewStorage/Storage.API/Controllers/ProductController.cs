using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Storage.Business.Products;
using Storage.Business.Products.DTO;
using Storage.DAL.Exception;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Storage.API.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<ProductResponse> GetProductById(int id)
        {
            return await _productService.GetByIdAsync(id);
        }

        [HttpGet]
        public async Task<List<ProductResponse>> GetList()
        {
            return await _productService.GetAll();
        }

        [HttpPost]
        public async Task<int> AddProduct([FromBody]ProductRequest productRequest)
        {
            return await _productService.AddAsync(productRequest);
        }

        [HttpPut("{id}")]
        public async Task<ProductResponse> UpdateProduct(int id, [FromBody]ProductRequest productRequest)
        {
            return await _productService.UpdateAsync(id, productRequest);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteAsync(id);

            return Ok();
        }
    }
}
