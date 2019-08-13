using System;

namespace App03Opgave65_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalTrialsAllowed = 3;
            int TrialNumber = 1;
            while (TrialNumber <= TotalTrialsAllowed)
            {
                try
                {
                    Run();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The following error has occured: " + ex.Message);
                    TrialNumber++;
                    if (TrialNumber == 4)
                    {
                        Console.WriteLine("Total number of trials reached.");
                    }
                }
            }
        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
        }
    }
}
