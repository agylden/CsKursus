using System;

namespace App05Opgave90_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vare a = new Vare();
            Vare a = new Vare("", 0);
            a.Navn = "Bananer";
            a.Pris = 5;
            Console.WriteLine(a.Navn);
            Console.WriteLine(a.Pris);
            Console.WriteLine(a.PrisMedMoms());
            //double b = new Vare();
            //b = a.PrisMedMoms(a.Pris);
        }
    }

    class Vare
    {
        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine("Navn er aflæst.");
                return navn; }
            set {
                Console.WriteLine("Navn er ændret.");
                navn = value; }
        }

        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("Pris er aflæst.");
                return pris; }
            set {
                Console.WriteLine("Pris er ændret.");
                pris = value; }
        }

        public Vare()
        {
            //this.Navn = "";
            //this.Pris = 0;
        }

        public Vare(string navn,double pris)
        {
            this.Navn= navn;
            this.Pris = pris;
        }

        public double PrisMedMoms()
        {
            return (this.pris*1.25);
        }
    }
}
