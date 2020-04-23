using System;
using System.Collections.Generic;

namespace _1100
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[] GetArrayInt()
        {
            string[] @string = Console.ReadLine().Split(' ');
            int[] array = new int[@string.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(@string[i]);
            }
            return array;
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();

            int[,] list = new int[n, 2];

            SortedList<int, int> sort = new SortedList<int, int>();

            for (int i = 0; i < n; i++)
            {
                int[] array = GetArrayInt();
                
                list[i, 0] = array[0];
                list[i, 1] = array[1];
                if (!sort.ContainsKey(array[1]))
                    sort.Add(array[1], array[0]);

            }

            for (int i = sort.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < list.GetLength(0); j++)
                {
                    if (sort.Keys[i] == list[j, 1])
                        Console.WriteLine("{0} {1}", list[j, 0], list[j, 1]);
                }
            }
        }
    }
}
