using System;

namespace _1567
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int prize = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == ' ')
                    prize++;
                else if (text[i] == ',')
                    prize += 2;
                else if (text[i] == '!')
                    prize += 3;
                else
                    prize += (text[i] - 'a') % 3 + 1;
            }
            Console.WriteLine(prize);

        }
    }
}
