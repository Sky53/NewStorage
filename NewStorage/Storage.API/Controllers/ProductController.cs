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
        public List<Product> GetAll()
        {
            return _productService.GetProducts();
        }
        [HttpPost]
        public void AddProduct(string name, string price)
        {
            _productService.AddProduct(name,price);
            //todo
        }
    }
}
