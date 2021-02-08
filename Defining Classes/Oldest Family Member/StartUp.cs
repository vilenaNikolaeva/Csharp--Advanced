using System;
using System.Linq;

namespace Oldest_Family_Member
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            Family family = new Family();
          
            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var member = new Person(input[0],int.Parse(input[1]));

                family.AddMember(member);
            }

            Person olderMember = family.GetOlderMember();
            Console.WriteLine($"{olderMember.Name} {olderMember.Age}");
        }
    }
}
