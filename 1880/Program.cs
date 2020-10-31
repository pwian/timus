using System;

namespace _1880
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
            int n1 = GetNumberInt();
            int[] a1 = GetArrayInt();
            int n2 = GetNumberInt();
            int[] a2 = GetArrayInt();
            int n3 = GetNumberInt();
            int[] a3 = GetArrayInt();
            int j = 0, k = 0;
            int count = 0;
            for (int i = 0; i < n1; i++)
            {
                while (j < n2 && a2[j] < a1[i])
                {
                    j++;
                }
                if (j < n2)
                {
                    if (a2[j] == a1[i])
                    {
                        while (k < n3 && a3[k] < a1[i])
                        {
                            k++;
                        }
                        if (k < n3)
                        {
                            if (a3[k] == a1[i])
                                count++;
                        }
                        else
                            break;
                    }

                }
                else
                    break;
            }
            Console.WriteLine(count);
        }
    }
}
