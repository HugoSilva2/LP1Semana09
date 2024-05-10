using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player uno = new Player(PlayerClass.Tank, "Ana");
            Player dos = new Player(PlayerClass.Slayer, "Paulo");
            Player tres = new Player(PlayerClass.Tank, "Ana");

            HashSet<Player> setOfPlayers = new HashSet<Player>() {uno, dos ,tres};
            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}.");
            }
        }
    }
}
