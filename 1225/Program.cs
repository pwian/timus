using System;

namespace _1225
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();
            long a2 = 1, a1 = 1;
            long count = 0;
            if (n == 1 || n == 2)
                count = 2;
            else
            {
                long buf;
                for (int i = 2; i < n; i++)
                {
                    buf = a2 + a1;
                    a1 = a2;
                    a2 = buf;
                }
                count = 2 * a2;
            }
            Console.WriteLine(count);
        }
    }
}
