using System;
using System.Text;

namespace _1654
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder line = new StringBuilder(text.Length);
            line.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (line.Length > 0 && text[i] == line[line.Length - 1])
                {
                    line.Remove(line.Length - 1, 1);
                }
                else
                    line.Append(text[i]);
            }
            Console.WriteLine(line);
        }
    }
}
