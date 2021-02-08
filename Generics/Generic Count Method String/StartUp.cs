using System;
using System.Collections.Generic;

namespace Generic_Count_Method_String
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var elements = new List<string>();

            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine();
                elements.Add(input);
            }

            var comparisonElement = Console.ReadLine();
            var box = new Box<string>(elements);

           var result= box.CountGreaterElement(elements, comparisonElement);

            Console.WriteLine(result);
        }
    }
}
