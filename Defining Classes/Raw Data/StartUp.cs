using System;
using System.Collections.Generic;
using System.Linq;

namespace Raw_Data
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Car[] cars = new Car[counter];

            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = input[0];
                var egSpeed =int.Parse( input[1]);
                var egPower =int.Parse( input[2]);
                var cargoWeight =int.Parse( input[3]);
                var cargoType = input[4];
                var tyrePressure1 = double.Parse(input[5]);
                var tireYear1 = int.Parse(input[6]);
                var tyrePressure2 = double.Parse(input[7]);
                var tireYear2= int.Parse(input[8]);
                var tyrePressure3 = double.Parse(input[9]);
                var tireYear3 = int.Parse(input[10]);
                var tyrePressure4 = double.Parse(input[11]);
                var tireYear4 = int.Parse(input[12]);

                cars[i] = new Car(model, new Engine(egSpeed, egPower)
                    , new Cargo(cargoWeight, cargoType), new List<Tyre> {
                    new Tyre(tyrePressure1,tireYear1),new Tyre(tyrePressure2,tireYear2),
                    new Tyre(tyrePressure3,tireYear3),new Tyre(tyrePressure4,tireYear4)});
            }


            var command = Console.ReadLine();
          
            

            if (command=="fragile")
            {
                cars.Where(c => c.Cargo.CargoType == "fragile")
                    .Where(c => c.Tires.Any(t => t.TirePressure < 1))
                    .Select(m => m.Model)
                    .ToList()
                    .ForEach(m=>Console.WriteLine(m));
                    
            }
            else if (command=="flamable")
            {
                cars.Where(c => c.Cargo.CargoType == "flamable")
                  .Where(c => c.Engine.EnginePower>250)
                  .Select(m => m.Model)
                  .ToList()
                  .ForEach(m => Console.WriteLine(m));
            }
        }
    }
}
