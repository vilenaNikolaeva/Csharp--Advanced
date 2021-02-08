using System;

namespace Car_Extension
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Audi";
            car.Model = "X5";
            car.Year = 2000;
            car.FuelQuantity = 1000;
            car.FuelConsumption = 6;
            car.Drive(200);
            Console.WriteLine(car.Details());
        }
    }
}
