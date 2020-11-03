using System;
using System.Collections.Generic;

namespace _2031
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

        static ulong[] GetArrayULong()
        {
            string[] line = Console.ReadLine().Split(' ');
            ulong[] array = new ulong[line.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToUInt64(line[i]);
            }
            return array;
        }

        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static long GetNumberLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();
            List<string> number = new List<string>();
            number.Add("16");
            number.Add("06");
            number.Add("68");
            number.Add("88");
            if (n <= number.Count)
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0} ", number[i]);
                }
            else
                Console.WriteLine("Glupenky Pierre");

        }
    }
}
