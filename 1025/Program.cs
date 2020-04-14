using System;

namespace _1025
{
    class Program
    {

        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            int n = GetNumberInt(), k = GetNumberInt();
            long a1 = (k - 1) * k, a2 = k * k - 1;
            if (n == 2)
                a2 = a1;
            else
            {
                for (int i = 3; i < n; i++)
                {
                    a2 = (k - 1) * a2 + a1;
                    a1 = a2 - a1;
                }
                a2 = (k - 1) * a2;
            }
            Console.WriteLine(a2);
        }
    }
}
