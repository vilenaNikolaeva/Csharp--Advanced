using System;
using System.Collections.Generic;
using System.Linq;

namespace Speed_Racing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();



            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    
                var model = input[0];
                var fuel = double.Parse(input[1]);
                var consumption = double.Parse(input[2]);

                var car =new Car( model, fuel, consumption);
                cars.Add(car);
            }


            var command = string.Empty;


            while ((command=Console.ReadLine())!="End")
            {
                var splitedInput = command.Split(" ");

                var model = splitedInput[1];
                var distance = int.Parse(splitedInput[2]);

                Car car = cars.First(c => c.Model == model);

                if (!car.Drive(distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmound:f2} {car.TravelDistance}");
            }
        }
    }
}