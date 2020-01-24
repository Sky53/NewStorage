using Microsoft.AspNetCore.Mvc;
using Storage.Business;
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

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<int> AddProduct([FromBody]Product product)
        {
            return await _productService.AddProductAsync(product);
        }

        [HttpGet]
        public Product GetProduct()
        {
            return new Product()
            {
                SKU = "SKUString",
                Price = 11.00m
            };
        }
    }
}
