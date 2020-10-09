using System;
using System.Collections.Generic;

namespace _1545
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
            SortedList<string, int> list = new SortedList<string, int>();
            for (int i = 0; i < n; i++)
            {
                string letters = Console.ReadLine();
                if (!list.ContainsKey(letters))
                    list.Add(letters, 1);
            }
            char c = Convert.ToChar(Console.ReadLine());
            foreach (var item in list)
            {
                if (item.Key[0] == c)
                    Console.WriteLine(item.Key);
            }
        }
    }
}
