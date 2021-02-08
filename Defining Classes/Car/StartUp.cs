using System;

namespace Car
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Audi";
            car.Model = "X5";
            car.Year = 2000;
            Console.WriteLine($"Make: {car.Make}\n Model: {car.Model}\n Year: {car.Year}");
        }
    }
}
