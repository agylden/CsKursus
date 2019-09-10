using MCronberg;
using System;
using System.Linq;

namespace App07Opgave150_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = PersonRepositoryStatic.JustGetPeople();
            //foreach (var person in people)
            //    Console.WriteLine(person.Name);

            //var res = people.OrderBy(i => i.Name).ToList();
            //foreach (var person in res)
            //{
            //    Console.WriteLine(person.Name);
            //}

            var res1 = people.OrderBy(i => i.Gender).ThenBy(i => i.Name);
            foreach (var person in res1)
            {
                Console.WriteLine(person.Name + " " + person.Gender);
            }
        } 
    }
}
