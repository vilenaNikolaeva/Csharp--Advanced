using System;

namespace Implement_the_CutomList
{
    class StartUp
    {
        static void Main(string[] args)
        { 
            var list = new CustomList(2);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            var count = list.Count;

            list.Foreach(n=>Console.WriteLine(n));

           
        }
    }
}
