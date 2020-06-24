using System;

namespace _1404
{
    class Program
    {
        static int[] CharNumber(string line)
        {
            int[] word = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                word[i] = line[i] - 'a';
            }
            return word;
        }

        static int CountK(ref int number)
        {
            int k = 0;
            while (number < 0)
            {
                k++;
                number += 26;
            }
            return k;
        }

        static string IntToString(int[] word)
        {
            string text = "";
            for (int i = 0; i < word.Length; i++)
            {
                text += (char)('a' + word[i]);
            }
            return text;
        }

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int[] shifr = CharNumber(line);
            int[] word = new int[shifr.Length];
            int k = 0;
            word[0] = shifr[0] - 5;
            if (word[0] < 0)
            {
                word[0] += 26;
                k = 1;
            }
            for (int i = 1; i < word.Length; i++)
            {
                word[i] = shifr[i] - shifr[i - 1] - 26 * k;
                k = CountK(ref word[i]);
            }
            Console.WriteLine(IntToString(word));
        }
    }
}