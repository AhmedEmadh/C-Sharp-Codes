using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfObjects
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("John", 25),
                new Person("Jane", 30),
                new Person("Joe", 35),
                new Person("Jill", 40),
                new Person("Jack", 45),
                new Person("Jenny", 50),
                new Person("Jim", 55),
                new Person("Jill", 60),
            };
            Console.WriteLine("People List:");
            foreach (Person person in people)
            {
                Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            }
            // Using Find
            Person foundPerson = people.Find(p => p.Name == "Jill");
            if (foundPerson != null)
            {
                Console.WriteLine("\nFound Person:");
                Console.WriteLine("Name: {0}, Age: {1}", foundPerson.Name, foundPerson.Age);
            }
            Person searchResult = people.FirstOrDefault(p => p.Name == "Jill");
            if (searchResult != null)
            {
                searchResult.Age = 61;
                Console.WriteLine("\nUpdated Person:");
                Console.WriteLine("Name: {0}, Age: {1}", searchResult.Name, searchResult.Age);
            }
            // Using FindAll
            List<Person> foundPeople = people.FindAll(p => p.Name == "Jill");
            Console.WriteLine("\nFound People:");
            foreach (Person person in foundPeople)
            {
                Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            }
            // Using Any to check by name
            bool containsJill = people.Any(p => p.Name == "Jill");
            Console.WriteLine("\nContains Jill: {0}", containsJill);

            // To Array
            Person[] peopleArray = people.ToArray();
            Console.WriteLine("\nPeople Array:");
            foreach (Person person in peopleArray)
            {
                Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            }

            // To List
            List<Person> peopleList1 = new List<Person>(peopleArray);
            List<Person> peopleList2 = peopleArray.ToList();
            Console.WriteLine("\nPeople List 1:");
            foreach (Person person in peopleList1)
            {
                Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            }
            Console.WriteLine("\nPeople List 2:");
            foreach (Person person in peopleList2)
            {
                Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            }

            Console.ReadLine();
        }
    }
}
