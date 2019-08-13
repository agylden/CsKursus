using System;

namespace App03Opgave48_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kulør Kort1 = Kulør.Hjerter;
            Console.WriteLine("Første kort: " + Kort1.ToString() + " " + (int)Kort1);
            
            Kulør Kort2 = Kulør.Klør;
            Console.WriteLine("Andet kort: " + Kort2.ToString() + " "  + (int)Kort2);
        }
    }

    enum Kulør
    {
        Spar = 0,
        Hjerter = 1,
        Ruder = 2,
        Klør = 3
    }
}
