using System;
using System.Collections.Generic;

namespace Generic_Count_Method_Doubles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var numbers = new List<double>();

            for (int i = 0; i < counter; i++)
            {
                var input = double.Parse(Console.ReadLine());
                numbers.Add(input);
            }

            var comparableNumber = double.Parse(Console.ReadLine());

            var box = new Box<double>(numbers);
            var result = box.ComapreNumberInSequance(numbers, comparableNumber);

            Console.WriteLine(result);

        }
    }
}
