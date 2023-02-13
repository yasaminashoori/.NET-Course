using System;
using System.Collections.Generic;
using System.Linq;

namespace _64_LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //access to class's method
            var studentList = StudentDatabase.GetStudentsFromDb();

            //number 1 
            var studentsName1 = studentList.Where(x => (x.StudentActvity == true) && (x.Score > 80) && (x.StudentCity == "NYC"))
                                .Select(x => x.StudentName);
            foreach (var item1 in studentsName1)
            {
                Console.WriteLine($"Students with true activity, score > 80 and NY city : {item1}");
            }

            //number 2
            var studentsName2 = studentList.Where(x => (x.Score > 80) || (x.StudentCity == "CA"))
                                .Select(x => x.StudentName);
            foreach (var item2 in studentsName2)
            {
                Console.WriteLine($"Students with score > 80, CA city : {item2}");
            }

            //number 3
            var studentsName3 = from Student in studentList
                          where (Student.StudentName[0] >= 'b' || Student.StudentName[0] <= 'B')
                          select new MinimalStudent() { StudentName = Student.StudentName };

            foreach (var item3 in studentsName3)
            {
                Console.WriteLine("The students that b/B as their first letter name in minimal class : " + item3.StudentName);
            }


            //number 4
            var studentsName4 = studentList.OrderByDescending(x => x.StudentActvity == false).Select(x => x.StudentName);
            foreach (var item4 in studentsName4)
            {
                Console.WriteLine($"Students with false activity ordered descending by their score : {item4}");
            }

            // number 5
            var studentsName5 = (studentList.Average(x => x.Score));
            Console.WriteLine($"The average of scores : {studentsName5}");

            //number 6
            var studentsName6 = studentList.Where(x => (x.StudentActvity == true) && (x.StudentCity == "CA")).Select(x => x.StudentName);
            List<string> xstudent = new List<string>(studentList.Select(x => x.StudentName));
            IEnumerable<string> final = xstudent.Where(
                                x => x.Contains("R") || x.Contains("r") || x.Contains("d") || x.Contains("D"));
            foreach (string stname in final)
            {
                Console.WriteLine(stname);
            }
        }
    }
}
