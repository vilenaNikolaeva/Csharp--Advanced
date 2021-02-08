using System;

namespace Rabbits
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Cage cage = new Cage("Wildness", 20);
            RabbitStore rabbit = new RabbitStore("Fluffy", "Blanc de Hotot");
            Console.WriteLine(rabbit);
        }
    }
}
