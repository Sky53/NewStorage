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
    //serv/api/
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public Product GetAll()
        {
            return _productService.GetProduct();
        } 
        [HttpPost]
        public string AddProduct([FromBody]Product product)
        {
               return _productService.AddProduct(product);
        }
    }
}
