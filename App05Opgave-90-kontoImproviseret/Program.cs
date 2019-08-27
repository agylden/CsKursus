using System;
using System.Collections.Generic;

namespace App05Opgave_90_kontoImproviseret
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k = new Konto();
            k.TilføjTransaktion(new Transkation(new DateTime(2019, 1, 1), "Indsat", 100));
            k.TilføjTransaktion(new Transkation(new DateTime(2019, 2, 1), "Indsat", 100));
            k.TilføjTransaktion(new Transkation(new DateTime(2019, 3, 1), "Hævet", -75));
            Console.WriteLine(k.Saldo());
        }
    }

    public class Transkation
    {
        // felter
        public DateTime dato;
        public string tekst;
        public decimal beløb;

        public Transkation(DateTime dato, string tekst, decimal beløb)
        {
            // vi kunne fx. skrive valideringskode her...
            this.dato = dato;
            this.tekst = tekst;
            this.beløb = beløb;
        }
    }

    public class Konto
    {
        private List<Transkation> transaktioner;

        public Konto()
        {
            transaktioner = new List<Transkation>();
        }

        public void TilføjTransaktion(Transkation t)
        {
            transaktioner.Add(t);
        }

        public decimal Saldo()
        {
            decimal sum = 0;
            foreach (var item in transaktioner)
            {
                sum = sum + item.beløb;
            }
            return sum;
        }

    }
}
