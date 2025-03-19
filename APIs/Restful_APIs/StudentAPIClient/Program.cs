// See https://aka.ms/new-console-template for more information


using StudentAPIClient;
using System.Net.Http.Json;

class Program
{
    static string EndPointString = "http://localhost:5231/api/Students/";
    static readonly HttpClient httpClient = new HttpClient();
    static async Task Main()
    {
        httpClient.BaseAddress = new Uri(EndPointString);
        await GetAllStudents();
    }
    static async Task GetAllStudents()
    {
        try
        {
            Console.WriteLine("Getting all students");
            var students = await httpClient.GetFromJsonAsync<List<Student>>("GetAllStudents");
            if (students != null)
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.ID}, Name: {student.Name},Age: {student.Age},Grade: {student.Grade}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

    }
}