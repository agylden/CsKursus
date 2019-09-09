using System;

namespace App06Opgave105_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kursist k = new Kursist() { Id = 1, Navn = "a" };
            k.Skriv1();
            k.Skriv2();

            // nej
            //Person p = new Person();

        }
    }

    abstract class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }

        public void Skriv1()
        {
            Console.WriteLine($"Person med id {Id} og navn {Navn}");
        }

        public abstract void Skriv2();
        // nej denne kan ikke indeholde kode.
        //{
        //    Console.WriteLine("Kan denne skriv2 indeholde kode?");
        //}
    }

    class Kursist : Person
    {
        public override void Skriv2()
        {
            Console.WriteLine($"Kursist med id {Id} og navn {Navn}");
        }
    }
}
