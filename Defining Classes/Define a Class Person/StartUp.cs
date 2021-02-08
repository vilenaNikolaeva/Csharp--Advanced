using System;

namespace Define_a_Class_Person
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = Console.ReadLine();
            person.Age = int.Parse(Console.ReadLine());
            Console.WriteLine($"{person.Name} {person.Age}");
        }
    }
}