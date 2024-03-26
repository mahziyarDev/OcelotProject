using Catalog.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var items = new List<ProductDto>
            {
                new ProductDto{Id = 101, Price = 1500, Title = "SAM"},
                new ProductDto{Id = 102, Price = 2500, Title = "G+"},
                new ProductDto{Id = 103, Price = 3500, Title = "Shahab"},
            };
            return Ok(items); 
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new ProductDto { Id = 101, Price = 1500, Title = "SAM" });
        }

        [HttpPost]
        public IActionResult Post(ProductDto model)
        {
            return Ok(model);
        }
    }
}
