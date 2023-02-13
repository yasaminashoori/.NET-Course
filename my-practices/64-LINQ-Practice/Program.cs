using System;
using System.Linq;

namespace _64_LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = StudentDatabase.GetStudentsFromDb();
            var studentsName = from Student in studentList
                               where (Student.StudentActvity == true) && (Student.Score > 80) && (Student.StudentCity == "NYC")
                               select Student.StudentName;
            foreach (var item in studentsName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
