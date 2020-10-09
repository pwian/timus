using System;
using System.Linq;
using System.Text;

namespace _1601
{
    class Program
    {
        static int IndexOf(string text, int k, params char[] c)
        {
            int index = -1;
            for (int i = k; i < text.Length; i++)
            {
                if (c.Contains(text[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        static int IndexOfFirstLetter(string text, int k)
        {
            int index = -1;
            for (int i = k; i < text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z' || text[i] >= 'A' && text[i] <= 'Z')
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        static string ChangeText(string text)
        {
            StringBuilder line = new StringBuilder();
            int currentIndex = 0;
            while (true)
            {
                int indexLetter = IndexOfFirstLetter(text, currentIndex);       //РџРµСЂРІС‹Р№ СЃРёРјРІРѕР»
                if (indexLetter != -1)
                {
                    line.Append(text.Substring(currentIndex, indexLetter - currentIndex));
                    line.Append(text[indexLetter].ToString().ToUpper());
                    currentIndex = indexLetter + 1;
                }
                else
                {
                    line.Append(text.Substring(currentIndex, text.Length - currentIndex));
                    break;
                }

                int indexEnd = IndexOf(text, currentIndex, '.', '?', '!');
                if (indexEnd != -1)
                {
                    line.Append(text.Substring(currentIndex, indexEnd - currentIndex + 1).ToLower());
                    currentIndex = indexEnd + 1;
                }
                else
                {
                    line.Append(text.Substring(currentIndex, text.Length - currentIndex).ToLower());
                    break;
                }

            }
            return line.ToString();
        }

        static void Main(string[] args)
        {
            string text = Console.In.ReadToEnd();
            Console.WriteLine(ChangeText(text));
        }
    }
}
