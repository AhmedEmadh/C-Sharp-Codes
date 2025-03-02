using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Serialization_Example
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
            //Create an instance of Person Class
            Person person = new Person { Name = "Ahmed Emad", Age = 30};
            // XML Serialization
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (TextWriter writer = new StreamWriter("person.xml"))
            {
                serializer.Serialize(writer, person);
            }

            // Deserialize the object back
            using (TextReader reader = new StreamReader("person.xml"))
            {
                Person deserializedPerson = (Person)serializer.Deserialize(reader);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            }
        }
    }
}
