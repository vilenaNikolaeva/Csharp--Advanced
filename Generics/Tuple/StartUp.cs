using System;
using System.Linq;

namespace Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var firstName = personInfo[0];
            var lastName = personInfo[1];
            var address = personInfo[2];
            var firstCase =new Tuple<string, string>($"{firstName} "+ lastName, address);
            Console.WriteLine(firstCase);


                var personDrink = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var person = personDrink[0];
            var beerLiters =int.Parse(personDrink[1]);
            var secondCase = new Tuple<string, int>(person, beerLiters);
            Console.WriteLine(secondCase);


            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var numberInt = int.Parse(numbers[0]);
            var numberDouble =double.Parse(numbers[1]);
            var tirdCase = new Tuple<int, double>(numberInt, numberDouble);
            Console.WriteLine(tirdCase);
        }
    }
}
