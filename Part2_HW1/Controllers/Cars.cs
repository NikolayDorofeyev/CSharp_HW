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
        public IEnumerable<Car> GetAllCars()
        {
            var cars = new List<Car>
            {
                new Car() { Id = 1, Make = "BMW", Model = "X7", Year = 2020, Engine = "Diesel" },
                new Car() { Id = 2, Make = "Honda", Model = "Accord", Year = 2019, Engine = "Petrol" },
                new Car() { Id = 3, Make = "Toyota", Model = "RAV4", Year = 2021, Engine = "Hybrid" },
                new Car() { Id = 4, Make = "Ford", Model = "Focus", Year = 2022, Engine = "Electric" }
            };

            return cars;
        }
    }
}