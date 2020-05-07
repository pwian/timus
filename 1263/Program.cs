using System;
using System.Collections.Generic;

namespace _1263
{
    class Program
    {
        static int[] GetArrayInt()
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] array = new int[line.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(line[i]);
            }
            return array;
        }

        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int[] b = GetArrayInt();
            int n = b[0], m = b[1];
            SortedList<int, int> list = new SortedList<int, int>();
            for (int i = 0; i < m; i++)
            {
                int number = GetNumberInt();
                if (list.ContainsKey(number))
                    list[number]++;
                else
                    list.Add(number, 1);
            }

            for (int i = 1; i <= n; i++)
            {
                if (list.ContainsKey(i))
                    Console.WriteLine("{0:f2}%", 100.0 * list[i] / m);
                else
                    Console.WriteLine("{0:f2}%", 0.0 / m);
            }
        }
    }
}
