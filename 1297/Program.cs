using System;
using System.Linq;

namespace _1297
{
    class Program
    {
        static bool Polyndrom(string line)
        {
            for (int i = 0; i < line.Length / 2; i++)
            {
                if (line[i] != line[line.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reverse = new String(text.ToCharArray().Reverse().ToArray());
            string maxLine = "";
            for (int i = 0; i < text.Length - maxLine.Length; i++)
            {
                string currentLine;
                for (int j = i + maxLine.Length; j < text.Length; j++)
                {
                    currentLine = text.Substring(i, j - i + 1);
                    if (reverse.Contains(currentLine))
                    {
                        if (Polyndrom(currentLine))
                            maxLine = currentLine;
                    }
                    else
                        break;

                }
            }
            Console.WriteLine(maxLine);
        }
    }
}
