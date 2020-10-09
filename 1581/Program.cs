using System;
using System.Collections.Generic;

namespace _1581
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
            int b = GetNumberInt();
            int[] a = GetArrayInt();
            List<int> list = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                while (i < a.Length - 1)
                {
                    if (a[i] == a[i + 1])
                        count++;
                    else
                        break;
                    i++;
                }
                list.Add(count);
                list.Add(a[i]);

            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }
        }
    }
}
