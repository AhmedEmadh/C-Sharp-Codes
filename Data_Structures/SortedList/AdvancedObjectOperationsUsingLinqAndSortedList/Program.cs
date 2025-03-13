using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedObjectOperationsUsingLinqAndSortedList
{
    class Employee
    {
        public string Name { get; }
        public string Department { get; }
        public int Salary { get; }
        public Employee(string name, string department, int salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, Employee> employees = new SortedList<int, Employee>()
            {
                {1, new Employee("Alice", "HR", 50000) },
                {2, new Employee("Bob", "IT", 60000) },
                {3, new Employee("Charlie", "HR", 55000) },
                {4, new Employee("David", "IT", 70000) },
                {5, new Employee("Eve", "HR", 45000) },
                {6, new Employee("Frank", "Markting", 75000) }
            };
            var query = employees
                .Where(emp => emp.Value.Department == "IT")
                .OrderByDescending(emp => emp.Value.Salary)
                .Select(e => e.Value.Name);
            Console.WriteLine("IT Department Employees sorted by Salary (Descending):");
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }

        }
    }
}
