using System;
using System.Linq;

namespace Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            StackBox<int> stack = new StackBox<int>();


            while ((input=Console.ReadLine())!="END")
            {
                var splited = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = splited[0];
                var elements = splited.Skip(1)
                    .Select(i=>i.Split(",").First())
                    .Select(int.Parse)
                    .ToArray();

                switch (command)
                {
                    case "Push":
                        stack.Push(elements);
                        break;

                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException invalid)
                        {
                            Console.WriteLine(invalid.Message);
                        }
                        break;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
