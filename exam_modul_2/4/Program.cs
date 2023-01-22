using System;
using System.Linq;
using System.Collections.Generic;

namespace _4
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, int> players = new SortedDictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "End of match")
            {
                string player = input.Split().First();
                int passes = int.Parse(input.Split().Last());
                if (players.ContainsKey(player))
                    players[player] += passes;
                else
                    players.Add(player, passes);
                input = Console.ReadLine();
            }
            foreach (var player in players)
                Console.WriteLine($"{player.Key} has passed {player.Value} passes.");
        }
    }
}