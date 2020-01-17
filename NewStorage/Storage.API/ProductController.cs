using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Storage.Business;
using Storage.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.API
{
    [ApiController]
    //serv/api/
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private ProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productService = new ProductService(productRepository);
        }
    }
}
