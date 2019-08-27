using System;

namespace App05Opgave87_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person k1 = new Person();
            Person k2 = new Person();
            k1.Id = 1;
            k2.Id = 2;
            Console.WriteLine(k1.Id);
            Console.WriteLine(k2.Id);

            k1 = k2;
            Console.WriteLine(k1.Id);
            Console.WriteLine(k2.Id);

            k1.Id = 3;
            Console.WriteLine(k1.Id);
            Console.WriteLine(k2.Id);
        }
    }

    class Person
    {
        public int Id;
    }
}
