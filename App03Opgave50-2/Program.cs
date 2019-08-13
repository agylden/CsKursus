using System;

namespace App03Opgave50_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 19;
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    if (i > 15)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
