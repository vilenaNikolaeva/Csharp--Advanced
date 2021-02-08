using System;

namespace Treeuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var count = 3;
            
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (i==0)
                {
                    var names = input[0]+input[1];
                    var addres = input[2];
                    var town = input[3];
                    Treeuple<string, string, string> first = new Treeuple<string, string, string>
                        (names, addres, town);
                    Console.WriteLine(first);
                }
                else if (i==1)
                {
                    var name = input[0];
                    var liters= int.Parse(input[1]);
                    bool drunkOrNot;
                    if (input[2]=="drunk")
                    {
                        drunkOrNot = true;
                    }
                    else
                    {
                        drunkOrNot = false;
                    }
                    Treeuple<string, int, bool> second = new Treeuple<string, int, bool>
                        (name,liters,drunkOrNot);
                    Console.WriteLine(second);
    
                }
                else if (i==2)
                {
                    var name = input[0];
                    var accountBalance =Math.Abs(double.Parse(input[1]));
                    var bankName = input[2];
                    Treeuple<string, double, string> tird = new Treeuple<string, double, string>
                       (name, accountBalance, bankName);
                    Console.WriteLine(tird);
                }
            }
        }
    }
}
