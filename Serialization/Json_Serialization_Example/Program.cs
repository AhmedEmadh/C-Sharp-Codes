using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Json_Serialization_Example
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
            // Create a JSON serializer
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
            // Serialize the object
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, person);
                string JsonString = Encoding.UTF8.GetString(stream.ToArray());
                File.WriteAllText("person.json", JsonString);
            }
            // Deserialize the object back
            using (FileStream stream = new FileStream("person.json", FileMode.Open))
            {
                Person deserializedPerson = (Person)serializer.ReadObject(stream);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            }

        }
    }
}
