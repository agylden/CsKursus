using System;

namespace App03Opgave50_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    string k = (i*j).ToString();
                    if ((i * j) > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(k.PadLeft(4));
                }
                Console.WriteLine();
            }
        }
    }
}
