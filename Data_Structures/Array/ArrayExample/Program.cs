﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{

    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleArrayExample();
            AdvancedArrayOperations();
            MultiDimensionalArray();
            CopyingArray();
            LinqOperationsOnArray();
            AdvancedLinqOperationsOnArray();
            AdvancedLINQFilteringAndAggregation();
            JoiningandProjectingData();

        }
        static void SimpleArrayExample()
        {
            // Declaring an integer array
            int[] numbers = new int[5];


            // Initializing an array with values
            string[] names = { "Alice", "Bob", "Charlie" };


            // Display the names
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
        static void AdvancedArrayOperations()
        {
            // Initializing an array
            int[] numbers = { 5, 3, 1, 4, 2 };


            // Sorting the array
            Array.Sort(numbers);


            // Display the sorted array
            Console.WriteLine("Sorted array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            // Searching for an element, this will return the index for the element you searched for.
            int index = Array.IndexOf(numbers, 4);
            Console.WriteLine("\nIndex of 4: " + index);
            Console.ReadKey();

        }
        static void MultiDimensionalArray()
        {
            // Declaring a 2D array
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };


            // Iterating over a 2D array
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void CopyingArray()
        {
            /* Performs Shallow Copy */
            // Original array
            int[] original = { 1, 2, 3, 4, 5 };


            // Array to hold the copy
            int[] copy = new int[5];


            // Copying array
            Array.Copy(original, copy, original.Length);


            // Displaying the copied array
            Console.WriteLine("Copied Array:");
            foreach (int element in copy)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
        static void LinqOperationsOnArray()
        {
            // Array of numbers
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Using LINQ to filter and transform data
            var evenSquares = numbers.Where(n => n % 2 == 0).Select(n => n * n);

            // Displaying results
            Console.WriteLine("Squares of even numbers:");
            foreach (var num in evenSquares)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
        static void AdvancedLinqOperationsOnArray()
        {
            // Array of people with Name and Age
            var people = new[]
            {
            new { Name = "Alice", Age = 30 },
            new { Name = "Bob", Age = 25 },
            new { Name = "Charlie", Age = 35 },
            new { Name = "Diana", Age = 30 },
            new { Name = "Ethan", Age = 25 }
            };

            // Grouping people by Age, then ordering within each group
            var groupedByAge = people.GroupBy(p => p.Age)
                                     .Select(group => new
                                     {
                                         Age = group.Key,
                                         People = group.OrderBy(p => p.Name)
                                     });


            // Displaying the results
            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"Age Group: {group.Age}");
                foreach (var person in group.People)
                {
                    Console.WriteLine($" - {person.Name}");
                }
            }

            Console.ReadKey();
        }
        static void AdvancedLINQFilteringAndAggregation()
        {
            // Array of numbers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Filtering to get only even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            // Aggregating - calculating the sum of even numbers
            int sumOfEvenNumbers = evenNumbers.Sum();

            // Displaying the results
            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nSum of Even Numbers: {sumOfEvenNumbers}");
            Console.ReadKey();
        }
        static void JoiningandProjectingData()
        {
            // Array of employees
            var employees = new[]
            {
            new { Id = 1, Name = "Alice", DepartmentId = 2 },
            new { Id = 2, Name = "Bob", DepartmentId = 1 }
            };


            // Array of departments
            var departments = new[]
            {
            new { Id = 1, Name = "Human Resources" },
            new { Id = 2, Name = "Development" }
            };


            // Joining employees with departments and projecting the result
            var employeeDetails = employees.Join(
                departments,             // Second collection (departments)
                e => e.DepartmentId,     // Key from employees (foreign key)
                d => d.Id,               // Key from departments (primary key)
                (e, d) => new { e.Name, Department = d.Name } // Project result
            );

            // Displaying the results
            foreach (var detail in employeeDetails)
            {
                Console.WriteLine($"Employee: {detail.Name}, Department: {detail.Department}");
            }
            Console.ReadKey();

        }
    }
}
