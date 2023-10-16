using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static List<string> permutations = new List<string>();
    static void Main(string[] args)
    {
        string[] elements = Console.ReadLine().Split(' ').ToArray();
        int k = int.Parse(Console.ReadLine());
        int[] output = new int[k];
        string[] priorityElement = Console.ReadLine().Split(' ').ToArray();
        FindSubsets(output, 0, 0, elements.Length, elements);

        for (int j = 0; j < permutations.Count; j++)
        {
            List<string> words = permutations.ElementAt(j).Split(' ').ToList();
            for (int i = priorityElement.Length - 1; i >= 0; i--)
            {
                for (int s = 0; s < words.Count; s++)
                {
                    if(words[s] == priorityElement[i])
                    {
                        words.RemoveAt(s);
                        words.Insert(0, priorityElement[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(' ', words));
        }
    }
    static void FindSubsets(int[] arr, int index, int start, int end, string[] wordsArr)
    {
        if (index >= arr.Length)
        {
            string str = null;
            for (int i = 0; i < arr.Length; i++)
            {
                str += wordsArr[arr[i]];
                str += " ";
            }
            permutations.Add(str);
        }
        else
            for (int i = start; i < end; i++)
            {
                arr[index] = i;
                FindSubsets(arr, index + 1, i + 1, end, wordsArr);
            }
    }
}
