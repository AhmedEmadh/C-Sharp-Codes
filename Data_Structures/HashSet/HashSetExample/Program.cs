using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> fruits = new HashSet<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");
            HashSet<string> moreFruits = new HashSet<string> { "Orange", "Pineapple", "Apple" };
            //Try to add duplicate item
            fruits.Add("Apple"); // This will not be added
            //Checking if the item is present in the HashSet
            if (fruits.Contains("Apple"))
            {
                Console.WriteLine("Apple is present in the HashSet");
            }
            else
            {
                Console.WriteLine("Apple is not present in the HashSet");
            }
            //Remove an item from the HashSet
            fruits.Remove("Apple");
            //Display the items in the HashSet
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            //Count of items in the HashSet
            Console.WriteLine("Count of items in the HashSet: " + fruits.Count);

        }
    }
}
