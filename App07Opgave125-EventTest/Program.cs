using System;

namespace App07Opgave125_EventTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k = new Konto(100);
            k.KontoIMinus += (s, e) => Console.WriteLine("MINUS..");
            k.Indsæt(10);
            Console.WriteLine(k.Saldo);
            k.Udtræk(50);
            Console.WriteLine(k.Saldo);
            k.Udtræk(10);
            Console.WriteLine(k.Saldo);
            k.Udtræk(60);
            Console.WriteLine(k.Saldo);
        }
    }

    class Konto
    {
        public double Saldo { get; private set; }
        public event EventHandler KontoIMinus;
        public Konto(double saldo)
        {
            Saldo = saldo;
        }

        public void Indsæt(double beløb)
        {
            Saldo += beløb;
            if (Saldo < 0)
                KontoIMinus?.Invoke(this, new EventArgs());
        }

        public void Udtræk(double beløb)
        {
            Saldo -= beløb;
            if (Saldo < 0)
                KontoIMinus?.Invoke(this, new EventArgs());
        }
    }
}
