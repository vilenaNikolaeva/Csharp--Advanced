using System;

namespace Box_of_T
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var box = new BoxOfT<int>();
            box.Add(10);
            box.Add(20);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());
        }
    }
}
