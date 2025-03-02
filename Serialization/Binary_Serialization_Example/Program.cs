using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Serialization_Example
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Ahmed Emad", Age = 30 };
            // Binary serialization
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("person.bin", FileMode.Create))
            {
                formatter.Serialize(stream, person);
            }


            // Deserialize the object back
            using (FileStream stream = new FileStream("person.bin", FileMode.Open))
            {
                Person deserializedPerson = (Person)formatter.Deserialize(stream);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
                Console.ReadKey();
            }
        }
    }
}
