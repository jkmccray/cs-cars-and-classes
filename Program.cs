using System;
using System.Collections.Generic;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(10000);
            car1.Make = "Ford";
            car1.Model = "Explorer";
            car1.Year = 1999;
            car1.Price = 1000.50;

            Car car2 = new Car(80000)
            {
                Make = "Mazda",
                Model = "B2500",
                Price = 115.99,
                Year = 1999
            };

            Car car3 = new Car(15000)
            {
                Make = "Nissan",
                Model = "GTR",
                Price = 79999.99,
                Year = 2018
            };

            List<Car> garage = new List<Car>();
            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);


            foreach (Car car in garage)
            {
                car.Accelerate();
                Console.WriteLine(car.CalculateAge());
                Console.WriteLine(car.Description);
                car.Drive(1000);
                Console.WriteLine($"Mileage: {car.TotalMiles}");
                car.Drive(1500);
                Console.WriteLine($"New Mileage: {car.TotalMiles}");
            }

            // how to get today's date/time;
            Console.WriteLine(DateTime.Now);
        }
    }
}
