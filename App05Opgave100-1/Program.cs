using System;

namespace App05Opgave100_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person eksempel:");
            Person p = new Person();
            p.Fornavn = "Andreas";
            p.Efternavn = "Gylden";
            Console.WriteLine(p.Fornavn);
            Console.WriteLine(p.Efternavn);
            Console.WriteLine(p.Fuldtnavn());

            Console.WriteLine();
            Console.WriteLine("Elev eksempel:");
            Elev e = new Elev();
            e.Fornavn = "AndreasElev";
            e.Efternavn = "GyldenElev";
            Console.WriteLine(e.Fornavn);
            Console.WriteLine(e.Efternavn);
            Console.WriteLine(e.Fuldtnavn());

            Console.WriteLine();
            Console.WriteLine("Instruktør eksempel:");
            Instruktør i = new Instruktør();
            i.Fornavn = "AndreasInstruktør";
            i.Efternavn = "GyldenInstruktør";
            Console.WriteLine(i.Fornavn);
            Console.WriteLine(i.Efternavn);
            Console.WriteLine(i.Fuldtnavn());

            Console.WriteLine("Færdig - øvelse er succesfuldt afsluttet. :-)");
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string Fuldtnavn()
        {
            return (this.Fornavn + " " + this.Efternavn);
        }
    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}
