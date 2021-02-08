using System;

namespace Guild
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Guilds guild = new Guilds("Weekend Raiders", 20);
            Players players = new Players("Mark", "Rogue");

            Console.WriteLine(players);
        }
    }
}
