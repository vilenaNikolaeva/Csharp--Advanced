using System;

namespace Overview
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var list = new CustomList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            var count = list.Count;
            Console.WriteLine(count);


            //////////////////////////////////////////////////

            var stack = new CustomStack(3);

            stack.Push(10);
            stack.Push(20);
            var result = stack.Pop();
            Console.WriteLine(result);
            
            var peekResult=stack.Peek();
            Console.WriteLine(peekResult);
            Console.WriteLine(stack.Count);
            stack.Foreach(n => Console.WriteLine(n * 10));

        }
    }
}
