using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int d1 = 0; d1 <= 9; d1++)
            {
                for (int d2 = 0; d2 <= 9; d2++)
                {
                    for (int d3 = 0; d3 <= 9; d3++)
                    {
                        for (int d4 = 0; d4 <= 9; d4++)
                        {
                            if (d1 + d4 == n)
                            {
                                if (d2 % 2 != 0)
                                {
                                    if (d3 == 4 || d3 == 7)
                                    {
                                        Console.Write($"{d1}{d2}{d3}{d4} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
