using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> fruitBasket = new Dictionary<string, int>
            {
                {"Apples", 3},
                {"Bananas", 2},
                {"Orange", 5}
            };
            // Using LINQ to transform Items in Dictionary
            var fruitInfo = fruitBasket.Select(keyValuePair => new {keyValuePair.Key, keyValuePair.Value });
            foreach (var item in fruitInfo)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }
            // Using LINQ to filter Items in Dictionary
            var fruitWithMoreThan2 = fruitBasket.Where(keyValuePair => keyValuePair.Value > 2);
            foreach (var item in fruitWithMoreThan2)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }
            // Using LINQ to sort Items in Dictionary
            var sortedFruit = fruitBasket.OrderBy(keyValuePair => keyValuePair.Value);
            foreach (var item in sortedFruit)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }
            // Using LINQ to sort Items in Dictionary in descending order
            var sortedFruitDesc = fruitBasket.OrderByDescending(keyValuePair => keyValuePair.Value);
            foreach (var item in sortedFruitDesc)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }
            // Using LINQ to Aggregate Items in Dictionary
            var totalFruit = fruitBasket.Sum(keyValuePair => keyValuePair.Value);
            Console.WriteLine($"Total Fruit: {totalFruit}");
        }
    }
}
