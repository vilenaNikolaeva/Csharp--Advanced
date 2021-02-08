using System;
using System.Linq;

namespace Merge_Sort
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var arr = input
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();

            Merge<int>.Sort(arr);
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
