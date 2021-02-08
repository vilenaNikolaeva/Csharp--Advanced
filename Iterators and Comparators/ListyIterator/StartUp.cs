using System;
using System.Linq;

namespace ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            ListIterator<string> list = new ListIterator<string>();

            while ((input=Console.ReadLine())!="END")
            {
                var splited = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                switch (splited[0])
                {
                    case "Create":
                        list = new ListIterator<string>(splited.Skip(1).ToArray());
                        break;
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (InvalidOperationException ivalid)
                        {
                            Console.WriteLine(ivalid.Message);
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "PrintAll":
                        foreach (var item in list)
                        {
                            Console.WriteLine(item+" ");
                        }
                        break;
                       
                }
            }
        }
    }
}
