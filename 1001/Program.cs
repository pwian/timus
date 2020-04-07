using System;
using System.Collections.Generic;

namespace _1001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> list = new List<long>();
            string str = Console.In.ReadToEnd();
            StringSplitOptions op = StringSplitOptions.RemoveEmptyEntries;
            string[] stringArray = str.Split(new char[] { ' ', '\n', '\r', '\t' }, op);
            for (int i = 0; i < stringArray.Length; i++)
            {
                list.Add(Convert.ToInt64(stringArray[i]));
            }
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine("{0:f4}", Math.Sqrt(list[i]));
            }
        }
    }
}
