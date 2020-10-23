using System;

namespace _1712
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

        static void Tranparent(ref int[,] matr)
        {
            int n = 4;
            int m = 4;
            int[,] transMatr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    transMatr[j, n - i - 1] = matr[i, j];
                }
            }
            matr = transMatr;
        }

        static string GetShifr(int[,] matr, char[,] shifr)
        {
            string line = "";
            int n = 4;
            int m = 4;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matr[i, j] != 0)
                        line += shifr[i, j];
                }
            }
            return line;
        }
        static void Main(string[] args)
        {
            int[,] matr = new int[4, 4];
            char[,] shifr = new char[4, 4];
            string password = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < 4; j++)
                {
                    if (line[j] == 'X')
                        matr[i, j] = 1;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < 4; j++)
                {
                    shifr[i, j] = line[j];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                password += GetShifr(matr, shifr);
                Tranparent(ref matr);
            }
            Console.WriteLine(password);
        }
    }
}
