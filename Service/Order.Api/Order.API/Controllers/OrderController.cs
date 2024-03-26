using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.API.Models;

namespace Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var items = new List<OrderDto>
            {
                new OrderDto{Id = 101, TotalPrice = 1500, CustomerName = "SAM"},
                new OrderDto{Id = 102, TotalPrice = 2500, CustomerName = "G+"},
                new OrderDto{Id = 103, TotalPrice = 3500, CustomerName = "Shahab"},
            };
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new OrderDto { Id = 101, TotalPrice = 1500, CustomerName = "SAM" });
        }

        [HttpPost]
        public IActionResult Post(OrderDto model)
        {
            return Ok(model);
        }
    }
}
