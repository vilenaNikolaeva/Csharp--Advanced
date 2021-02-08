using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Swap_Method_Integers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                var input = int.Parse(Console.ReadLine());
                numbers.Add(input);
            }

            var swipe = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var first = swipe[0];
            var second = swipe[1];

            var box = new Box<int>(numbers);
            box.Swipe(numbers, first, second);

            foreach (var item in box.Data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
