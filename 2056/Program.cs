using System;
using System.Linq;

namespace _2056
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
            int[] mark = new int[n];
            for (int i = 0; i < n; i++)
            {
                mark[i] = GetNumberInt();
            }
            if (mark.Contains(3))
                Console.WriteLine("None");
            else
            {
                double avr = mark.Average();
                if (avr == 5)
                    Console.WriteLine("Named");
                else if (avr >= 4.5)
                    Console.WriteLine("High");
                else
                    Console.WriteLine("Common");
            }
        }
    }
}
