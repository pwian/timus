using System;
using System.Collections.Generic;

namespace _1496
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
            Dictionary<string, int> list = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string team = Console.ReadLine();
                if (list.ContainsKey(team))
                    list[team]++;
                else
                    list.Add(team, 1);
            }
            foreach (var item in list)
            {
                if (item.Value > 1)
                    Console.WriteLine(item.Key);
            }
        }
    }
}
