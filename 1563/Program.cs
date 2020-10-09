using System;
using System.Collections.Generic;

namespace _1563
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
            int countBayan = 0;
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string brand = Console.ReadLine();
                if (list.Contains(brand))
                    countBayan++;
                else
                    list.Add(brand);
            }

            Console.WriteLine(countBayan);
        }
    }
}
