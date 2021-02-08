using System;
using System.Linq;

namespace Recursive_Array_Sum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var index = 0;
            var result = Sum(input, index);
            Console.WriteLine(result);
        }
        private static int Sum(int[] arr,int index)
        {
            if (arr.Length - 1 == index)
            {
                return arr[index];
            }
            return arr[index] + Sum(arr, index + 1);
        }
    }
}
