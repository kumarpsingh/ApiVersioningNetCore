using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVersioning.Controllers
{
    [ApiController]
    [Route("api/v{version:ApiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    public class ProductsController : ControllerBase
    {
        [HttpGet("GetProduct")]
        [MapToApiVersion("1.0")]
        public IActionResult GetProductsV1()// While calling this method 'GetProductsV1' is not being used. use api/v1.0/products
        {   
            return Ok(new {name="Pen", Price=10, Version="1.0"});
        }

        [HttpGet("GetProduct")]
        [MapToApiVersion("1.1")]
        public IActionResult GetProductsV11() // While calling this method 'GetProductsV2' is not being used. use api/v2.0/products
        {
            return Ok(new { productName = "Pen", Price = 10, Version = "1.1" });
        }

        [HttpGet("GetProduct")]
        [MapToApiVersion("2.0")]
        public IActionResult GetProductsV2() // While calling this method 'GetProductsV2' is not being used. use api/v2.0/products
        {
            return Ok(new { productName = "Pen", Price = 10, Version = "2.0" });
        }

        [HttpGet("GetProduct")]
        [MapToApiVersion("3.0")]
        public IActionResult GetProductsV3() // While calling this method 'GetProductsV2' is not being used. use api/v2.0/products
        {
            return Ok(new { productName = "Pen", Price = 10, Version = "3.0" }); 
        }


    }
}