using System;

namespace App03Opgave45_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eksempel på brug af dateadd funktionalitet:");
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            d1 = d1.AddDays(10);
            Console.WriteLine(d1);
            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);
            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            Console.WriteLine("\nEfter oprette af d2 og d3:");
            DateTime d2 = new DateTime(2019,5,5);
            DateTime d3 = new DateTime(2019,8,5);
            TimeSpan dres = d3.Subtract(d2);
            Console.WriteLine($"Forskellen mellem de to variable d2 og d3: {dres.Days} dage.");


            Console.WriteLine("\nNæste opgave");
            TimeSpan t2 = new TimeSpan(16, 0, 0);
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(0, 30, 0);
            Console.WriteLine(t3);
            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine(t4);
            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine(t5);
        }
    }
}
