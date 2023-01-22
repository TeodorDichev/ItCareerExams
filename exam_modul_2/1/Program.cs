using System;
using System.Linq;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int computer = 0, chair = 0, desk = 0;
            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                switch (item)
                {
                    case "computer":
                        computer++;
                        break;
                    case "chair":
                        chair++;
                        break;
                    case "desk":
                        desk++;
                        break;
                }
            }
            Console.WriteLine($"{computer* 5899 + chair * 1699 + desk* 1789:f2}");
        }
    }
}