using System;

namespace Generic_Box_of_integer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var couner = int.Parse(Console.ReadLine());

            for (int i = 0; i < couner; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var result = new Box<int>(input);
                Console.WriteLine(result);
            }
        }
    }
}
