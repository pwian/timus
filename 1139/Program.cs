using System;

namespace _1139
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

        static void Fraction(ref int m, ref int n)
        {
            int i = 2;
            while (i <= m && i <= n)
            {
                while (true)
                {
                    if (m % i == 0 && n % i == 0)
                    {
                        m = m / i;
                        n = n / i;
                    }
                    else
                        break;
                }
                i++;
            }
        }

        static void Main(string[] args)
        {
            int[] array = GetArrayInt();
            int n = array[0] - 1, m = array[1] - 1;
            if (n > m)
            {
                int buf = n;
                n = m;
                m = buf;
            }
            int m2 = m, n2 = n;
            Fraction(ref m2, ref n2);
            int countAngle = m / m2;
            if (m % m2 == 0)
                countAngle--;
            int countArea = m + (n - 1) - countAngle;
            Console.WriteLine(countArea);
        }
    }
}
