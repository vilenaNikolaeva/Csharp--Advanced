using System;

namespace Recursive_Factorial
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var element = int.Parse(Console.ReadLine());
            var result = Factorial(element);
            Console.WriteLine(result) ;

        }
        static long Factorial(int n)//5
        {
            if (n==0)
            {
                return 1;
            }
            return n * Factorial(n - 1); //5*4, 5*3 , 5*2 5*1
        }

    }
}
