using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            for (int i = 1; i <= n; i++)
            {
                double scale = double.Parse(Console.ReadLine());
                if (scale > 0 && scale <= 4) p1++;
                else if (scale > 4 && scale <= 6) p2++;
                else if (scale > 6 && scale <= 7) p3++;
                else if (scale > 7) p4++;
            }
            Console.WriteLine($"Light: {p1 / n * 100:f2}%");
            Console.WriteLine($"Moderate: {p2 / n * 100:f2}%");
            Console.WriteLine($"Strong: {p3 / n * 100:f2}%");
            Console.WriteLine($"Very Strong: {p4 / n * 100:f2}%");
        }
    }
}
