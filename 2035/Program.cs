using System;

namespace _2035
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

        static long GetNumberLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }

        struct User
        {
            public string password;
            public bool loogin;
        }
        static void Main(string[] args)
        {
            int[] array = GetArrayInt();
            int x = array[0], y = array[1], c = array[2];

            if (x + y < c)
                Console.WriteLine("Impossible");
            else
            {
                int a = 0, b = 0;
                if (x < y)
                {
                    b = c;
                    if (b > y)
                    {
                        b = y;
                        a = c - b;
                    }
                }
                else
                {
                    a = c;
                    if (a > x)
                    {
                        a = x;
                        b = c - a;
                    }
                }
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
