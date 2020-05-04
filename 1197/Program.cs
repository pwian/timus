using System;

namespace _1197
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static bool Possible(int x, int y)
        {
            return (x >= 1 && x <= 8 && y >= 1 && y <= 8);
        }

        static int CountAttack(string str)
        {
            int x = str[0] - 'a' + 1;
            int y = str[1] - '0';
            int count = 0;
            if (Possible(x + 2, y - 1))
                count++;
            if (Possible(x + 2, y + 1))
                count++;
            if (Possible(x - 2, y - 1))
                count++;
            if (Possible(x - 2, y + 1))
                count++;
            if (Possible(x - 1, y - 2))
                count++;
            if (Possible(x + 1, y + 2))
                count++;
            if (Possible(x + 1, y - 2))
                count++;
            if (Possible(x - 1, y + 2))
                count++;
            return count;
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(CountAttack(Console.ReadLine()));
            }


        }
    }
}
