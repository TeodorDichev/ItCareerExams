using System;
using System.Linq;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main()
        {
            List<string> patients = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "END OF PATIENTS")
            {
                switch (input)
                {
                    case "Add patient":
                        patients.Add(Console.ReadLine());
                        break;
                    case "Add patient on position":
                        string patient = Console.ReadLine();
                        int pos = int.Parse(Console.ReadLine());
                        patients.Insert(pos, patient);
                        break;
                    case "Remove patient on position":
                        patients.RemoveAt(int.Parse(Console.ReadLine()));
                        break;
                    case "Remove last patient":
                        patients.RemoveAt(patients.Count - 1);
                        break;
                    case "Remove first patient":
                        patients.RemoveAt(0);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", patients));
        }
    }
}