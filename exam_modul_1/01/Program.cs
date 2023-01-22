using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceLaminate = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double pricePad = double.Parse(Console.ReadLine());
            double area = width * length;
            double total = 1.4 * (area * priceLaminate + area * pricePad);
            Console.WriteLine($"{total:f2}");
        }
    }
}
