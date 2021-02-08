using System;
using System.Collections.Generic;
using System.Linq;

namespace Dating_App
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var male = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var female = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            male = RefineMatches(male);
            female = RefineMatches(female);
            Stack<int> maleStack = new Stack<int>(male);
            Queue<int> femaleQueue = new Queue<int>(female);

            var matches = 0;

            while (maleStack.Count!=0 && femaleQueue.Count!=0)
            {
                var boy  = maleStack.Peek();
                var girl = femaleQueue.Peek();

                if (boy==girl)
                {
                    femaleQueue.Dequeue();
                    maleStack.Pop();
                    matches++;
                }
                else
                {
                    femaleQueue.Dequeue();
                    maleStack.Push(maleStack.Pop() - 2);
                }

                maleStack = new Stack<int>(RefineMatches(maleStack.ToList()));
                maleStack = Reverse(maleStack);
                femaleQueue = new Queue<int>(RefineMatches(femaleQueue.ToList()));
            }

            Console.WriteLine($"Matches: {matches}");
            var malesResult = maleStack.Count == 0 ? "none" : string.Join(", ", maleStack);
            var femaleResult = femaleQueue.Count == 0 ? " none" : string.Join(", ", femaleQueue);

            Console.WriteLine($"Males left: {malesResult}");
            Console.WriteLine($"Females left: {femaleResult}");

           
        }

        private static Stack<int> Reverse(Stack<int> input)
        {
            Stack<int> temp = new Stack<int>();

            while (input.Count!=0)
            {
                temp.Push(input.Pop());
            }
            return temp;
        }

        private static List<int> RefineMatches(List<int> people)
        {
            people.RemoveAll(x => x <= 0);

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i] % 25 == 0)
                {
                    people.RemoveAt(i);
                    if (i < people.Count)
                    {
                        people.RemoveAt(i++);
                    }
                }
            }
            return people;
        }
    }
}
