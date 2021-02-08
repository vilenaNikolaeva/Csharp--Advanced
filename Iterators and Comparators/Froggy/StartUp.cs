using System;
using System.Linq;

namespace Froggy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splited = input
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(splited);
            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
