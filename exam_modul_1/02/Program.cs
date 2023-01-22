using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double price1 = double.Parse(Console.ReadLine());
            double price2 = 0.2 * price1;
            double price3 = 0.7 * price2;
            double price4 = 0.5 * price2;
            double total = price1 + price2 + price3 + price4;
            if (budget>=total)
                Console.WriteLine($"Yes! {budget - total:f2} leva left.");
            else
                Console.WriteLine($"No! {total - budget:f2} leva needed.");
        }
    }
}
