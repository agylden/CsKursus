using System;

namespace App06Opgave120_1
{
    public delegate void MinDelegate1(string txt);

    class Program
    {
        static void Main(string[] args)
        {
            MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            f1.Invoke("Virker det? Ja!");

            MinDelegate1 f2 = MinSkrivTilConsole;
            f2("Virker det igen? Ja sørme ja!");

            Console.WriteLine();
            Console.WriteLine("Mellemrum");
            MinDelegate1 f3 = MinSkrivTilConsole;
            f3 += MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("Skulle også gerne virke");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;
        }
        
        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
}
