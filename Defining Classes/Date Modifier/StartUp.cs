using System;
using System.Linq;

namespace Date_Modifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            DateModifier date = new DateModifier();

            Console.WriteLine(date.GetTheDiference(firstDate,secondDate));
        }
    }
}
