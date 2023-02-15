using System;
using System.Linq;
using _61_LINQ;

namespace _63_LINQ_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = StudentDatabase.GetStudentsFromDb();

            var sortedByScore = studentList.OrderBy(x => x.Score)
                                .Select(x => x.Score);
            foreach (var item in sortedByScore)
            {
                Console.WriteLine(item);
            }
            

            var sortedByScore2 = studentList.OrderBy(x => x.Score)
                                .Select(x => new MinimalStudent()
                                {
                                    Score = x.Score,
                                    StudentName = x.StudentName
                                });
            foreach (var item in sortedByScore2)
            {
                Console.WriteLine(item.StudentName);
            }


            var grouepdByCity = studentList.GroupBy(x => x.StudentCity).Select(x => x.Key);
            foreach (var item in grouepdByCity)
            {
                Console.WriteLine(item);
            }

            var hasAllStudentPassed = studentList.All(x => x.Score > 80);
            Console.WriteLine(hasAllStudentPassed);

            var hasAllStudentFailed = studentList.Any(x => x.Score > 80);
            Console.WriteLine(hasAllStudentFailed);

            if (studentList.Any(x => x.Score > 40))
            {
                Console.WriteLine("They should again take this course.");
            }

            var names = new string[] {"yas", "fatheme", "zahra"};
            if (names.Contains("yas"))
            {
                Console.WriteLine("this name is Available");
            }
        }
    }
}
