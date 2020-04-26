using System;
using System.Collections.Generic;

namespace _1110
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

        static int GetRemainder(int x, int n, int m)
        {
            if (x == 0)
                return 0;
            if (x == 1)
                return 1;
            int remainder = x % m;
            int power = 1;
            int rest = remainder;
            while (power < n)
            {
                rest = rest * remainder % m;
                power++;
            }
            return rest;
        }

        static void Main(string[] args)
        {
            int[] array = GetArrayInt();
            int n = array[0], m = array[1], y = array[2];
            List<int> list = new List<int>();
            for (int i = 0; i <= m - 1; i++)
            {
                if (GetRemainder(i, n, m) == y)
                    list.Add(i);
            }
            if (list.Count == 0)
                Console.WriteLine(-1);
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write("{0} ", list[i]);
                }
            }
        }
    }
}
