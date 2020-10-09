using System;
using System.Collections.Generic;

namespace _1585
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Dictionary<string, int> list = new Dictionary<string, int>();
            list.Add("Emperor Penguin", 0);
            list.Add("Macaroni Penguin", 0);
            list.Add("Little Penguin", 0);
            int n = GetNumberInt();
            for (int i = 0; i < n; i++)
            {
                list[Console.ReadLine()]++;
            }
            string nameMax = "";
            int max = 0;
            foreach (var item in list)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    nameMax = item.Key;
                }
            }
            Console.WriteLine(nameMax);
        }
    }
}
