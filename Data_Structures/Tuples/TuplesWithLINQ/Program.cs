using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesWithLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(int ID, string Name, int Age)> people = new List<(int ID, string Name, int Age)>
            {
                (1,"Alice",30),
                (2,"Bob",25),
                (3,"Charlie",35),
                (4,"David",40),
                (5,"Eve",20)
            };
            //Filter people with age greater than 30
            var filteredPeople = people.Where(p => p.Age > 30);
            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"ID: {person.ID}, Name: {person.Name}, Age: {person.Age}");
            }
            //Find average age of people
            var averageAge = people.Average(p => p.Age);
            Console.WriteLine($"Average Age: {averageAge}");
            Console.ReadKey();
        }
    }
}
