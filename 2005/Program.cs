using System;

namespace _2005
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
            int[] array;
            int[,] matr = new int[6, 6];
            for (int i = 1; i < 6; i++)
            {
                array = GetArrayInt();
                for (int j = 1; j < 6; j++)
                {
                    matr[i, j] = array[j - 1];
                }
            }
            int r1, r2, r3, r4;
            r1 = matr[1, 2] + matr[2, 3] + matr[3, 4] + matr[4, 5];
            r2 = matr[1, 4] + matr[4, 3] + matr[3, 2] + matr[2, 5];
            r3 = matr[1, 3] + matr[3, 2] + matr[2, 4] + matr[4, 5];
            r4 = matr[1, 3] + matr[3, 4] + matr[4, 2] + matr[2, 5];
            int min = Math.Min(Math.Min(r1, r2), Math.Min(r3, r4));
            if (r1 == min)
            {
                Console.WriteLine(r1);
                Console.WriteLine("1 2 3 4 5");
            }
            else if (r2 == min)
            {
                Console.WriteLine(r2);
                Console.WriteLine("1 4 3 2 5");
            }
            else if (r3 == min)
            {
                Console.WriteLine(r3);
                Console.WriteLine("1 3 2 4 5");
            }
            else if (r4 == min)
            {
                Console.WriteLine(r4);
                Console.WriteLine("1 3 4 2 5");
            }
        }
    }
}
