using System;
using System.Collections.Generic;

namespace Car_Salesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var counterEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < counterEngines; i++)
            {
                var engineInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var model = engineInput[0];
                var power =engineInput[1];

                if (engineInput.Length==2)
                {
                    engines.Add(new Engine(model,power)); 
                }
                else if (engineInput.Length==3)
                {
                    var displacement =int.Parse(engineInput[2]);
                    engines.Add(new Engine(model, power, displacement));
                }
                else if (engineInput.Length==4)
                {
                    var displacement = int.Parse(engineInput[2]);
                    var efficiency = engineInput[3];
                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
            }

            var counterCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < counterCars; i++)
            {
                var carsInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var model = carsInput[0];
                var engineModel = carsInput[1];
                Engine engine = new Engine(null, null);

                foreach (var eng in engines)
                {
                    if (eng.Model==engineModel)
                    {
                       engine =eng;
                    }
                }

                if (carsInput.Length==2)
                {
                    cars.Add(new Car(model,engine));
                }
                else if (carsInput.Length==3)
                {
                    int weight;
                    bool isWeight = int.TryParse(carsInput[2], out weight);
                    if (isWeight)
                    {
                        cars.Add(new Car(model, engine, weight));
                    }
                    else
                    {
                        var color = carsInput[2];
                        cars.Add(new Car(model,engine, color));
                    }
                }
                else if (carsInput.Length==4)
                {
                    int weight = int.Parse(carsInput[2]);
                    var color = carsInput[3];
                    cars.Add(new Car(model, engine, weight, color));
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power:{car.Engine.Power}");
                Console.WriteLine($"    Displacement:{car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency:{car.Engine.Efficiency}");
                Console.WriteLine($"  Weight:{0}",car.Weight==0 ? "n/a" : car.Weight.ToString());
                Console.WriteLine($"  Color:{car.Color}");
            }
        }
    }
}
