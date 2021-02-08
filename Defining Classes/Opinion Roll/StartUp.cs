using System;
using System.Collections.Generic;
using System.Linq;

namespace Opinion_Roll
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());

           Family peoples = new Family();

            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var member = new Person(input[0], int.Parse(input[1]));
                peoples.AddMember(member);
            }

            List<Person> result = peoples.GetPeopleAbove30();
            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name}-{person.Age}");
            }
        }
    }
}
