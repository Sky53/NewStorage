using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("{id}")]
        public async Task<ProductResponse> GetProductById(int id)
        {
            return await _productService.GetyIdAsync(id);
        }

        [HttpPost]
        public async Task<int> AddProduct([FromBody]ProductRequest productRequest)
        {
            throw new System.Exception();
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
            var code = await _productService.DeleteAsync(id);
           
            return Ok(code);
        }

        
    }
}
