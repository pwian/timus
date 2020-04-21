using System;

namespace _1082
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
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
