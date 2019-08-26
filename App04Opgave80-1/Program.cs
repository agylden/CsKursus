using System;

namespace App04Opgave80_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Første test uden brug af custom constructor: ");
            Person testPerson1 = new Person();
            testPerson1.Fornavn = "Andreas";
            testPerson1.Efternavn = "Gylden";
            testPerson1.Fødselsår = 1994;

            Console.WriteLine(testPerson1.Fuldtnavn());
            Console.WriteLine(testPerson1.Alder());


            Console.WriteLine("Anden test med brug af custom constructor: ");
            Person testPerson2 = new Person("Andreas","Gylden",1994);
            Console.WriteLine(testPerson2.Fuldtnavn());
            Console.WriteLine(testPerson2.Alder());
        }
    }
}
