using System;

namespace _2100
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
            int count = 2;
            int n = GetNumberInt();
            for (int i = 0; i < n; i++)
            {
                string guest = Console.ReadLine();
                if (guest.Contains("+one"))
                    count += 2;
                else
                    count++;
            }
            if (count == 13)
                count++;
            Console.WriteLine(count * 100);
        }
    }
}
