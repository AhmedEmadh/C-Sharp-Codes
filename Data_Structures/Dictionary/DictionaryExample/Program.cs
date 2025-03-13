using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>();
            fruitBasket.Add("Apple", 5);
            fruitBasket.Add("Banana", 10);
            fruitBasket.Add("Orange", 15);
            // Accessing and updating elements in a Dictionary
            fruitBasket["Apple"] = 6;

            Console.WriteLine("Dictionary elements:");
            foreach (KeyValuePair<string, int> item in fruitBasket)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            fruitBasket.Remove("Banana");
            Console.WriteLine("Dictionary elements after removing Banana:");
            foreach (KeyValuePair<string, int> item in fruitBasket)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            // Using TryGetValue method
            int value;
            if (fruitBasket.TryGetValue("Apple", out value))
            {
                Console.WriteLine("Value of Apple: {0}", value);
            }
            else
            {
                Console.WriteLine("Apple not found in the dictionary");
            }
            // Using wrong key
            //Console.WriteLine(fruitBasket["Grapes"]);
            // Gives KeyNotFoundException


        }


    }
}
