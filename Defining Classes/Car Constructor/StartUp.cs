using System;
using System.Collections.Generic;

namespace Car_Constructor
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var make = Console.ReadLine();
            var model = Console.ReadLine();
            var year = int.Parse(Console.ReadLine());
            var fuelQuantity = double.Parse(Console.ReadLine());
            var fuelConsumption = double.Parse(Console.ReadLine());
            
            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car tirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            Console.WriteLine(firstCar.Details());
            Console.WriteLine(secondCar.Details());
            Console.WriteLine(tirdCar.Details());
        }
    }
}
