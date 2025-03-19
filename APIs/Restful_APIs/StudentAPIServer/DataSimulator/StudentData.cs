using StudentAPIServer.Model;

namespace StudentAPIServer.DataSimulator
{
    public class StudentData
    {
        public static readonly List<Student> StudentList = new List<Student>
        {
            new Student{ID = 1, Name = "Bob", Age = 12, Grade = 7},
            new Student{ID = 2, Name = "Joe", Age = 13, Grade = 8},
            new Student{ID = 3, Name = "Jim", Age = 14, Grade = 9},
            new Student{ID = 4, Name = "Sue", Age = 13, Grade = 8},
            new Student{ID = 5, Name = "Tom", Age = 14, Grade = 9},
        };
    }
}
