using System;
using System.Linq;

namespace _61_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentIds = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = from studentId in studentIds
                         where (studentId % 2) == 0
                         select studentId;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var studentsList = StudentDatabase.GetStudentsFromDb();

            var studentsScoreMoreThan80 = from student in studentsList
                                          where student.Score > 80
                                          select student.StudentName;
            foreach (var item in studentsScoreMoreThan80)
            {
                Console.WriteLine(item);
            }

            studentsScoreMoreThan80 = studentsList.Where(x => x.Score > 80).Select(x => x.StudentName);
            foreach (var item in studentsScoreMoreThan80)
            {
                Console.WriteLine(item);
            }
        }
    }
}
