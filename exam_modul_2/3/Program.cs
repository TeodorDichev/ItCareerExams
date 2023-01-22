using System;
using System.Linq;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int maxPoints = 0;
            string maxName = null;
            while (input != "END OF GAME")
            {
                int points = 0;
                if (input.Last() == 'a') points += 10;
                else if (input.Last() == 'v') points += 13;
                if (input.Length >= 7) points += 33;
                else points += 22;
                if (points > maxPoints)
                {
                    maxPoints = points;
                    maxName = input;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Winner is name: {maxName}");
            Console.WriteLine($"Points: {maxPoints}");
        }
    }
}