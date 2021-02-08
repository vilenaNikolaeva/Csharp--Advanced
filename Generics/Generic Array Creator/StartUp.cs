using System;

namespace Generic_Array_Creator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var names = ArrayCreator.Create(5, "Bubka");
            var numbers = ArrayCreator.Create(10,33);
        }
    }
}
