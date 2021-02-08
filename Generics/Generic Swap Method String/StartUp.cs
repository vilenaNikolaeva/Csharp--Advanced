using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Swap_Method_String
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var lines = new List<string>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();
                lines.Add(input);
            }
            var boxOfString = new Box<string>(lines);


            var swipe = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var first = swipe[0];
            var second = swipe[1];
            boxOfString.Swap(lines, first, second);
            foreach (var item in boxOfString.Data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
 