using Part2_HW1.Interfaces;
using WebApplication1.Models;

namespace Part2_HW1
{
    public class ManagementCars : IManagementCars
    {
        public string GetCarName(int carId)
        {
            var cars = GetAllCars();
            var car = cars.FirstOrDefault(c => c.Id == carId);
            return car?.Make + " " + car?.Model;
        }

        public string GetCarEngine(int carId)
        {
            var cars = GetAllCars();
            var car = cars.FirstOrDefault(c => c.Id == carId);
            return car?.Engine;
        }

        public int GetCarAge(int carId)
        {
            var cars = GetAllCars();
            var car = cars.FirstOrDefault(c => c.Id == carId);
            if (car != null)
            {
                return DateTime.Now.Year - car.Year;
            }
            return -1;
        }

        private List<Car> GetAllCars()
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
