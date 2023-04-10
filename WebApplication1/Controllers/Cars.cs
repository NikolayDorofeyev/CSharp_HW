using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Cars : ControllerBase
    {
        private readonly ILogger<Cars> _logger;

        public Cars(ILogger<Cars> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCar")]
        public IEnumerable<Car> Get()
        {
            var cars = new List<Car>
            {
                new Car() { Make = "BMW", Model = "X7", Year = 2020, Color = "Black" },
                new Car() { Make = "Honda", Model = "Accord", Year = 2019, Color = "Red" },
                new Car() { Make = "Toyota", Model = "RAV4", Year = 2021, Color = "White" },
                new Car() { Make = "Ford", Model = "Mustang", Year = 2022, Color = "Blue" }
            };

            return cars;
        }
    }
}