using System;

namespace _1073
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

            byte[] answer = new byte[n + 1];
            ushort[] square = new ushort[(int)Math.Sqrt(n) + 2];
            for (ushort i = 0; i < square.Length; i++)
            {
                square[i] = (ushort)(i * i);
            }
            answer[0] = 0;
            answer[1] = 1;

            byte squareIndex = 1;
            byte minCount;
            byte sum;
            for (ushort i = 2; i < n + 1; i++)
            {
                if (square[squareIndex + 1] <= i)
                    squareIndex++;



                if (square[squareIndex] == i)
                    minCount = 1;
                else
                {
                    minCount = (byte)(answer[square[squareIndex]] + answer[i - square[squareIndex]]);


                    ushort currntJ = (ushort)(squareIndex - 1);
                    while (currntJ > 0)
                    {
                        ushort j = square[currntJ];
                        sum = (byte)(answer[j] + answer[i - j]);
                        if (sum < minCount)
                        {
                            minCount = sum;
                            if (minCount == 2)
                                break;
                        }
                        currntJ--;
                    }
                }
                answer[i] = minCount;
            }

            Console.WriteLine(answer[n]);
        }
    }
}
