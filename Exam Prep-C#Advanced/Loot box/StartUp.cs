using System;
using System.Collections.Generic;
using System.Linq;

namespace Loot_box
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstSequance = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            var secondSequance = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();

            Queue<int> first = new Queue<int>(firstSequance);
            Stack<int> second = new Stack<int>(secondSequance);
            var sum = 0;



            while (true)
            {
                if (first.Count==0 || second.Count==0)
                {
                    break;
                }
                var stackValue = first.Peek();
                var queueValue = second.Peek();
                var valueSum = stackValue + queueValue;

                if (valueSum % 2 == 0)
                {
                    sum += stackValue + queueValue;
                    first.Dequeue();
                    second.Pop();
                }
                else
                {
                    first.Enqueue(second.Pop());
                }
            }
            if (first.Count==0)
            {
                Console.WriteLine($"First lootbox is empty");
            }
            else if (second.Count==0)
            {
                Console.WriteLine($"Second lootbox is empty");
            }
            if (sum>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }

        }
    }
}
