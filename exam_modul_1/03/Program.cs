using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int kameri = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double area = width * length;
            switch (name)
            {
                case "Dogramichka4You":
                    if (kameri == 3) Console.WriteLine($"Goshko has to spend {area*12:f2} leva.");
                    else if (kameri == 4) Console.WriteLine($"Goshko has to spend {area * 15:f2} leva.");
                    else if (kameri == 5) Console.WriteLine($"Goshko has to spend {area * 20:f2} leva.");
                    break;
                case "TihoToplo":
                    if (kameri == 3) Console.WriteLine($"Goshko has to spend {area * 15:f2} leva.");
                    else if (kameri == 4) Console.WriteLine($"Goshko has to spend {area * 14:f2} leva.");
                    else if (kameri == 5) Console.WriteLine($"Goshko has to spend {area * 18:f2} leva.");
                    break;
                case "ChukChuk":
                    if (kameri == 3) Console.WriteLine($"Goshko has to spend {area * 14:f2} leva.");
                    else if (kameri == 4) Console.WriteLine($"Goshko has to spend {area * 20:f2} leva.");
                    else if (kameri == 5) Console.WriteLine($"Goshko has to spend {area * 22:f2} leva.");
                    break;
            }
        }
    }
}
