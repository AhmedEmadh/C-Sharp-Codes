﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayWithLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a jagged array
            int[][] jaggedArray = new int[][]{
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9, 10 }
            };


            // Flatten the jagged array and sum all elements
            int totalSum = jaggedArray.SelectMany(subArray => subArray).Sum();
            Console.WriteLine("Total Sum: " + totalSum);


            // Find the maximum element in the jagged array
            int maxElement = jaggedArray.SelectMany(subArray => subArray).Max();
            Console.WriteLine("Maximum Element: " + maxElement);


            // Filter arrays having more than 3 elements and select their first element
            var firstElements = jaggedArray.Where(subArray => subArray.Length > 3)
                                           .Select(subArray => subArray.First());
            Console.Write("First Elements of Long Rows: ");
            foreach (var element in firstElements)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}
