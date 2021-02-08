using System;

namespace Exe_Overview
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyList = new DoublyLinkedList();

            for (int i = 0; i < 3; i++)
            {
                doublyList.AddLast(i);
            }
        }
    }
}
