using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleApp5
{
    public class Program
    {
        public static void Main()
        {
            string str = "anysentence";
            {
            for (int i = 0; i < str.Length; i++)
            {
                bool hadPrevious = false;
                char symbol = str[i];
                for (int j = i; j >= 0; j--)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    char prevSymbol = str[j];

                    if (prevSymbol == symbol)
                    {
                        hadPrevious = true;
                        break;
                    }
                }
                if (hadPrevious)
                {
                    continue;
                }
                else
                {
                    int count = 0;
                    for (int x = 0; x < str.Length; x++)
                    {
                        char currentSymbol = str[x];
                        if (currentSymbol == symbol)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(symbol + " - " + count);
                }
            }
        }
    }

